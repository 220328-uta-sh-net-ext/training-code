using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonModels;
using PokemonBL;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using PokemonApi.Repository;
using Microsoft.AspNetCore.Cors;

namespace PokemonApi.Controllers
{
    //Routes are used to configure the endpoints of the api, we can keep it predefined as in the standard or even customized it
    [Route("api/[controller]")]
    //anything in the [] is known as decorator/attribute : its like processing the before the class or method
    [ApiController]
    [EnableCors("pokemonPolicy")]
    public class PokemonController : ControllerBase// Controller base class has the logic to interact with HTTP and communication with client
    {
        private readonly IJWTManagerRepository repository;
        private IPokemonLogic _pokeBL;
        private IMemoryCache memoryCache;

        public PokemonController(IPokemonLogic _pokeBL, IMemoryCache memoryCache, IJWTManagerRepository repository)//Constructor dependency
        {
            this._pokeBL = _pokeBL;
            this.memoryCache = memoryCache;
            this.repository = repository;
        }
        [HttpGet]//http method
        [ProducesResponseType(200, Type=typeof(List<Pokemon>))]
        public ActionResult<List<Pokemon>> Get()
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            try
            {
                if (!memoryCache.TryGetValue("pokeList", out pokemons))
                {
                    pokemons = _pokeBL.SearchAll();
                    memoryCache.Set("pokeList", pokemons, new TimeSpan(0,1,0));
                }
            }
            catch(SqlException ex)
            {
                return NotFound(ex.Message);
            }
            catch(Exception ex) {
                return BadRequest(ex.Message);
            }
            return Ok(pokemons);
        }

        [HttpGet("Search")]
        //[DisableCors]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(404)]        
        public ActionResult<Pokemon> Get([FromQuery]string name)// primitive type so model binder will look for these values as querystring
        {
            var poke = _pokeBL.SearchPokemon(name);
            if (poke==null)
                return NotFound($"Pokemon {name} you are looking for is not in the database");
            return Ok(poke);
        }
        [HttpPost]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] Pokemon poke)// Complex type so model binder will look for these values from request body
        {
            if (poke == null)
                return BadRequest("Invalid pokemon, please try again with valid values");
            _pokeBL.AddPokemon(poke);
            return CreatedAtAction("Get",poke);
        }
        [HttpPut]
        [Authorize]
        public ActionResult Put([FromBody]Pokemon poke, [FromQuery]string name) //non-Default
        {
            if (name == null)
                return BadRequest("Cannot modify pokemon without name");
            try
            {
                var pokemon = _pokeBL.SearchPokemon(name);
                if (pokemon == null)
                    return NotFound("Pokemon not found");
                pokemon.Name = poke.Name;
                pokemon.Attack = poke.Attack;
                pokemon.Level = poke.Level;
                pokemon.Defense = poke.Defense;
                pokemon.Health = poke.Health;
                _pokeBL.Update(pokemon);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            return Created("Get",poke);
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Delete(int id)
        {
            if (id == null)
                return BadRequest("Cannot modify pokemon without name");
            var pokemon = _pokeBL.SearchPokemonById(id);
            if (pokemon == null)
                return NotFound("Pokemon not found");
            _pokeBL.Remove(id);
            return Ok();
        }

    }
}

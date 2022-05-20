using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonModels;
using PokemonBL;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using PokemonApi.Repository;

namespace PokemonApi.Controllers
{
    //Routes are used to configure the endpoints of the api, we can keep it predefined as in the standard or even customized it
    [Route("api/[controller]")]
    //anything in the [] is known as decorator/attribute : its like processing the before the class or method
    [ApiController]
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

        private static List<Pokemon> _pokemons = new List<Pokemon> { 
            new Pokemon{ Name="Pikachu", Attack = 50, Defense = 50, Health = 50, Level = 1},
            new Pokemon{ Name="Ditto", Attack = 48, Defense = 48, Health = 48, Level = 1}
             };

        
        //Action Methods : ways to access or manipulate the resources, it uses the HTTP Verbs/methods (GET, PUT, POST, DELETE, PATCH, HEAD etc....)
     //   [Authorize]
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

        [HttpGet("name")]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(404)]
        
        public ActionResult<Pokemon> Get(string name)// primitive type so model binder will look for these values as querystring
        {
            var poke = _pokeBL.SearchPokemon(name);
            if (poke.Count<=0)
                return NotFound($"Pokemon {name} you are looking for is not in the database");
            return Ok(poke);
        }
        [HttpPost]
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
        public ActionResult Put([FromQuery]Pokemon poke, [FromBody]string name) //non-Default
        {
            if (name == null)
                return BadRequest("Cannot modify pokemon without name");
            try
            {
                var pokemon = _pokemons.Find(x => x.Name.Contains(name));
                if (pokemon == null)
                    return NotFound("Pokemon not found");
                pokemon.Name = poke.Name;
                pokemon.Attack = poke.Attack;
                pokemon.Level = poke.Level;
                pokemon.Defense = poke.Defense;
                pokemon.Health = poke.Health;
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            return Created("Get",poke);
        }

        [HttpDelete]
        public ActionResult Delete(string name)
        {
            if (name == null)
                return BadRequest("Cannot modify pokemon without name");
            var pokemon = _pokemons.Find(x => x.Name.Contains(name));
            if (pokemon == null)
                return NotFound("Pokemon not found");
            _pokemons.Remove(pokemon);
            return Ok($"Pokemon {name} Deleted");
        }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonModels;
using PokemonBL;

namespace PokemonApi.Controllers
{
    //Routes are used to configure the endpoints of the api, we can keep it predefined as in the standard or even customized it
    [Route("api/[controller]")]
    //anything in the [] is known as decorator/attribute : its like processing the before the class or method
    [ApiController]
    // 
    public class PokemonController : ControllerBase// Controller base class has the logic to interact with HTTP and communication with client
    {
        private IPokemonLogic _pokeBL;

        public PokemonController(IPokemonLogic _pokeBL)//Constructor dependency
        {
            this._pokeBL = _pokeBL;
        }

        private static List<Pokemon> _pokemons = new List<Pokemon> { 
            new Pokemon{ Name="Pikachu", Attack = 50, Defense = 50, Health = 50, Level = 1},
            new Pokemon{ Name="Ditto", Attack = 48, Defense = 48, Health = 48, Level = 1}
             };
        //Action Methods : ways to access or manipulate the resources, it uses the HTTP Verbs/methods (GET, PUT, POST, DELETE, PATCH, HEAD etc....)
        [HttpGet]//http method
        [ProducesResponseType(200, Type=typeof(List<Pokemon>))]
        public ActionResult<List<Pokemon>> Get()
        {
              var pokemons=_pokeBL.SearchAll();
              return Ok(pokemons);
        }

        [HttpGet("name")]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(404)]
        public ActionResult<Pokemon> Get(string name)
        {
            var poke = _pokeBL.SearchPokemon(name);
            if (poke.Count<=0)
                return NotFound($"Pokemon {name} you are looking for is not in the database");
            return Ok(poke);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] Pokemon poke)
        {
            if (poke == null)
                return BadRequest("Invalid pokemon, please try again with valid values");
            _pokeBL.AddPokemon(poke);
            return CreatedAtAction("Get",poke);
        }
        [HttpPut]
        public ActionResult Put([FromBody] Pokemon poke, string name)
        {
            if (name == null)
                return BadRequest("Cannot modify pokemon without name");
            var pokemon = _pokemons.Find(x => x.Name.Contains(name));
            if (pokemon == null)
                return NotFound("Pokemon not found");
            pokemon.Name = poke.Name;
            pokemon.Attack = poke.Attack;
            pokemon.Level = poke.Level;
            pokemon.Defense = poke.Defense;
            pokemon.Health = poke.Health;
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

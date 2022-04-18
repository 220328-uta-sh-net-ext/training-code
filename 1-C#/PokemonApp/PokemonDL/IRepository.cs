using System.Collections.Generic;
using PokemonModels;

namespace PokemonDL
{
    public interface IRepository
    {
        /// <summary>
        /// Add a pokemon to the database
        /// </summary>
        /// <param name="poke"></param>
        /// <returns>The pokemon added</returns>
        Pokemon AddPokemon(Pokemon poke);
        /// <summary>
        /// This method returns all the pokemons from the database
        /// </summary>
        /// <returns>Returns a collection of pokemon as Generic List</returns>
        List<Pokemon> GetAllPokemons();
    }
}

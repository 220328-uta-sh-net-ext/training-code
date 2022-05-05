using PokemonModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokemonDL;

/// <summary>
/// - Data layer project is responsible for interacting with our database and doing CRUD operations
/// - C - Create, R - Read, U - Update, D - Delete
/// - It must not have logical operation that will also manipulate the data it is grabbing
/// - Just think of Data layer as the delivery man of your uber eats. You definitely don't want your delivery man to touch
/// the food he is delivering and just give it to you so you can do whatever you want with it.
/// </summary>
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
    Task<List<Pokemon>> GetAllPokemonsAsync();

    //Ability GetAbility(string name);
}

using PokemonModels;

namespace PokemonBL;

/// <summary>
/// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
/// What kind of processing? That all depends on the type of functionality you will be doing
/// It can also hold any computation logic like calculating average, max or min values etc....
/// </summary>
public interface IPokemonLogic:IPokemonSearch
{
    /// <summary>
    /// Add pokemon to the database
    /// initial addition of a pokemon will give some sort of a randon stats
    /// Can only have a total of 4 pokemons in the Database
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    Pokemon AddPokemon(Pokemon p);

    /// <summary>
    /// We will give the list of pokemons that are related to searched name
    /// </summary>
    /// <param name="name">This name parameter is used to filter pokemons</param>
    /// <returns>Give the list of filtered pokemons via name</returns>
    List<Pokemon> SearchPokemon(string name);

}
public interface IPokemonSearch
{
    /// <summary>
    /// This method returns all the pokemons from the database on Azure Sql. This is an asynchronus method so use await keyword 
    /// </summary>
    /// <returns>List<Pokemons></returns>
    Task<List<Pokemon>> SearchAllAsync();
    List<Pokemon> SearchAll();
}

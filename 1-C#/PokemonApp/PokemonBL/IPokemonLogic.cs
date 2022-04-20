using PokemonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBL
{
    /// <summary>
    /// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
    /// What kind of processing? That all depends on the type of functionality you will be doing
    /// It can also hold any computation logic like calculating average, max or min values etc....
    /// </summary>
    public interface IPokemonLogic
    {
        /// <summary>
        /// Add pokemon to the database
        /// initial addition of a pokemon will give some sort of a randon stats
        /// Can only have a total of 4 pokemons in the Database
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        Pokemon AddPokemon(Pokemon p);
    }
}

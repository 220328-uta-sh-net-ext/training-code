using PokemonDL;
using PokemonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBL
{
    public class PokemonLogic : IPokemonLogic
    {
        public Pokemon AddPokemon(Pokemon p)
        {
            Random random = new Random();
            //process data to meet conditions
            //It will either substract or add a range from -5 to 5
            p.Attack = random.Next(-5, 5);
            p.Defense = random.Next(-5, 5);
            p.Health = random.Next(-5, 5);

            //Validation process
            IRepository repo = new Repository();
            var pokemons=repo.GetAllPokemons();
            if (pokemons.Count<4)
            {
                return repo.AddPokemon(p);
            }
            else
            {
                throw new Exception("You cannot exceed to add more than 4 pokemons");
            }
        }
    }
}

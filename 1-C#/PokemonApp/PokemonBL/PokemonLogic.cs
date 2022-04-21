using PokemonDL;
using PokemonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBL
{
    public class PokemonLogic : IPokemonLogic//, IPokemonSearch
    {
        IRepository repo = new Repository();
        public Pokemon AddPokemon(Pokemon p)
        {
            Random random = new Random();
            //process data to meet conditions
            //It will either substract or add a range from -5 to 5
            p.Attack = random.Next(-5, 5);
            p.Defense = random.Next(-5, 5);
            p.Health = random.Next(-5, 5);

            //Validation process            
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

        public List<Pokemon> SearchPokemon(string name)
        {
            
            
            var pokemons=repo.GetAllPokemons();
            /*var filteredPokemons=from p in pokemons               //Query Syntax
                                    where p.Name.Contains(name)
                                    select p;*/

            var filteredPokemons = pokemons.Where(p => p.Name.Contains(name)).ToList(); // Method Syntax

            /*List<Pokemon> filteredPokemons = new List<Pokemon>();
            foreach (var poke in pokemons)
            {
                if (poke.Name.Contains(name))
                {
                    filteredPokemons.Add(poke);
                }
            }*/
            return filteredPokemons;

        }
        /*Pokemon p = new Pokemon();
        Pokemon CheckName(string p)
        {   
            p.Name.Contains(p);
            return p;
        }*/
    }
}

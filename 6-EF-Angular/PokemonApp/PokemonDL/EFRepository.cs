using PokemonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDL
{
    public class EFRepository : IRepository
    {
        private PokemonDbContext db;
        public EFRepository(PokemonDbContext db)
        {
            this.db = db;
        }
        public Pokemon AddPokemon(Pokemon poke)
        {
            db.Pokemons.Add(poke);
            db.SaveChanges();
            return poke;
        }

        public void DeletePokemon(int id)
        {
            var pokemonToDelete=db.Pokemons.Where(p => p.Id == id).FirstOrDefault();
            if(pokemonToDelete != null)
                db.Pokemons.Remove(pokemonToDelete);
        }

        public List<Pokemon> GetAllPokemons()
        {
            return db.Pokemons.ToList();
        }

        public Task<List<Pokemon>> GetAllPokemonsAsync()
        {
            throw new NotImplementedException();
        }

        public Pokemon GetPokemonById(int id)
        {
            return db.Pokemons.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemonByName(string name)
        {
            return db.Pokemons.Where(p => p.Name == name).FirstOrDefault();
        }

        public Pokemon Update(Pokemon pokemon)
        {
            db.Pokemons.Update(pokemon);
            db.SaveChanges();
            return pokemon;
        }
    }
}

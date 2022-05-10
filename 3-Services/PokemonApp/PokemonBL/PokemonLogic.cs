using PokemonDL;
using PokemonModels;

namespace PokemonBL;

public class PokemonLogic : IPokemonLogic
{
    const int MaxPokemons = 4000;
    readonly IRepository repo;

    public PokemonLogic(IRepository repo)
    {
        this.repo = repo;
    }

    public Pokemon AddPokemon(Pokemon p)
    {
        var random = new Random();
        //process data to meet conditions
        //It will either substract or add a range from -5 to 5
        p.Attack = random.Next(-5, 5);
        p.Defense = random.Next(-5, 5);
        p.Health = random.Next(-5, 5);

        //Validation process
        List<Pokemon>? pokemons = repo.GetAllPokemons();
        if (pokemons.Count < MaxPokemons)
        {
            return repo.AddPokemon(p);
        }
        else
        {
            throw new Exception("You cannot exceed to add more than 4 pokemons");
        }
    }


    public List<Pokemon> SearchAll()
    {
        return repo.GetAllPokemons();
    }

    public async Task<List<Pokemon>> SearchAllAsync()
    {
        return await repo.GetAllPokemonsAsync();
    }

    public List<Pokemon> SearchPokemon(string name)
    {
        List<Pokemon>? pokemons = repo.GetAllPokemons();
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

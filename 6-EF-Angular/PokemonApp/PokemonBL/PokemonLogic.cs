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

    public void Remove(int id)
    {
        repo.DeletePokemon(id);
    }

    public List<Pokemon> SearchAll()
    {
        return repo.GetAllPokemons();
    }

    public async Task<List<Pokemon>> SearchAllAsync()
    {
        return await repo.GetAllPokemonsAsync();
    }

    public Pokemon SearchPokemon(string name)
    {
        var pokemon = repo.GetPokemonByName(name);        
        return pokemon;

    }

    public Pokemon SearchPokemonById(int id)
    {
        var pokemon = repo.GetPokemonById(id);
        return pokemon;
    }

    public Pokemon Update(Pokemon p)
    {
        repo.Update(p);
        return p;
    }
}

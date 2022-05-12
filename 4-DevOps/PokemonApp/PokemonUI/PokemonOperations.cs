using PokemonDL;
using PokemonModels;

namespace PokemonUI;

class PokemonOperations
{
    readonly IRepository repository;

    public PokemonOperations(IRepository repository)
    {
        this.repository = repository;
    }

    public void GetAllPokemons()
    {
        List<Pokemon>? pokemons = repository.GetAllPokemons();
        foreach (Pokemon? poke in pokemons)
        {
            Console.WriteLine(poke);
            Console.WriteLine("=======================");
        }
    }
    /// <summary>
    /// only for testing purpose to check if pokemon was added
    /// </summary>
    public void AddDummyPokemon()
    {
        var pokemon1 = new Pokemon()
        {
            Name = "Pikachu",
            Level = 4,
            Attack = 40,
            Defense = 45,
            Health = 50,
            Abilities = new List<Ability>() {
                new Ability()
                {
                    Name = "ThunderBolt",
                    Accuracy = 100,
                    Power = 90,
                    PP = 15
                }
            }
        };

        repository.AddPokemon(pokemon1);
    }
}

using PokemonBL;

namespace PokemonUI;

class SearchPokemonMenu : IMenu
{
    readonly IPokemonLogic logic;

    public SearchPokemonMenu(IPokemonLogic logic)
    {
        this.logic = logic;
    }

    public void Display()
    {
        Console.WriteLine("Please select an option to filter the pokemon database");
        Console.WriteLine("Press <1> By Name");
        Console.WriteLine("Press <0> Go Back");
    }

    public string UserChoice()
    {
        // Console.ReadLine returns null if redirecting from a file and the file ends
        if (Console.ReadLine() is not string userInput)
            throw new InvalidDataException("end of input");

        switch (userInput)
        {
            case "0":
                return "MainMenu";
            case "1":
                // Logic to display results
                Console.Write("Please enter the name ");
                if (Console.ReadLine() is not string name)
                    throw new InvalidDataException("end of input");
                List<PokemonModels.Pokemon>? results = logic.SearchPokemon(name);
                if (results.Count > 0)
                {
                    foreach (PokemonModels.Pokemon? r in results)
                    {
                        Console.WriteLine("=================");
                        Console.WriteLine(r.ToString());
                    }
                }
                else
                {
                    Console.WriteLine($"Pokemon with search string {name} not found");
                }
                Console.WriteLine("Press <enter> to continue");
                Console.ReadLine();
                return "MainMenu";
            default:
                Console.WriteLine("Please enter a valid response");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                return "SearchPokemon";
        }
    }
}

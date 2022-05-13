using PokemonBL;
using PokemonModels;

namespace PokemonUI;

class AddPokemonMenu : IMenu
{
    //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
    static readonly Pokemon newPokemon = new();

    readonly IPokemonLogic logic;

    public AddPokemonMenu(IPokemonLogic logic)
    {
        this.logic = logic;
    }

    public void Display()
    {
        Console.WriteLine("Enter Pokemon Information");
        //feel free to add more options here like for Defense, Health etc....
        Console.WriteLine("<3> Name - " + newPokemon.Name);
        Console.WriteLine("<2> Level - " + newPokemon.Level);
        Console.WriteLine("<1> Save");
        Console.WriteLine("<0> Go Back");
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
                try
                {
                    Log.Information("Adding a pokemon - " + newPokemon.Name);
                    logic.AddPokemon(newPokemon);
                    Log.Information("Pokemon added successfully");
                }
                catch (Exception ex)
                {
                    Log.Warning("failed to add pokemon");
                    Console.WriteLine(ex.Message);

                }
                return "MainMenu";
            case "2":
                Console.Write("Please enter a level ");
                newPokemon.Level = Convert.ToInt32(Console.ReadLine());
                return "AddPokemon";
            case "3":
                Console.Write("Please enter a name! ");
                newPokemon.Name = Console.ReadLine() is string input ? input :
                    throw new InvalidDataException("end of input");
                return "AddPokemon";
            /// Add more cases for any other attributes of pokemon
            default:
                Console.WriteLine("Please input a valid response");
                Console.WriteLine("Please press Enter to continue");
                Console.ReadLine();
                return "AddPokemon";
        }
    }
}

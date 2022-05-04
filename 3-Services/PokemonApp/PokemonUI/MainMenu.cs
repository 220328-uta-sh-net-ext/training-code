namespace PokemonUI;

class MainMenu : IMenu
{
    public void Display()
    {
        Console.WriteLine("Welcome to Pokemon App");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Press <3> See All Pokemons");
        Console.WriteLine("Press <2> Search Pokemon");
        Console.WriteLine("Press <1> Add pokemon to your team");
        Console.WriteLine("Press <0> Exit");
    }

    public string UserChoice()
    {
        // Console.ReadLine returns null if redirecting from a file and the file ends
        if (Console.ReadLine() is not string userInput)
            throw new InvalidDataException("end of input");

        switch (userInput)
        {
            case "0":
                return "Exit";
            case "1":
                return "AddPokemon";
            case "2":
                return "SearchPokemon";
            case "3":
                return "GetAllPokemons";
            default:
                Console.WriteLine("Please input a valid response");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                return "MainMenu";
        }
    }
}

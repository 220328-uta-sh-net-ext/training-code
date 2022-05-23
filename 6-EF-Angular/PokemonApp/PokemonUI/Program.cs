global using Serilog;
using PokemonBL;
using PokemonDL;
using PokemonUI;

//create and configure our logger
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();

// other approaches to this besides "gitignored file"...
//  - command-line arguments (in this file with top-level statements, invisible "args" variable
//  - environment variab
string connectionStringFilePath = "../../../../PokemonDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IRepository repository = new SqlRepository(connectionString);
IPokemonLogic logic = new PokemonLogic(repository);
PokemonOperations operations = new(repository);

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchPokemon":
            //call SearchPokemon method
            Log.Debug("Displaying SearchPokemon menu to the user");
            menu = new SearchPokemonMenu(logic);
            break;
        case "AddPokemon":
            Log.Debug("Displaying AddPokemon Menu to the user");
            menu = new AddPokemonMenu(logic);
            break;
        case "GetAllPokemons":
            Log.Debug("Displaying all pokemons to the user");
            Console.WriteLine("--------------Retreiving all pokemons---------------");
            operations.GetAllPokemons();
            break;
        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Debug("Exiting the application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}
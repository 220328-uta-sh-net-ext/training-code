namespace PokemonUI
{
    /*MainMenu class implements IMenu interface but since it is a class it needs to 
     give actual implementation details to the respective methods*/
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
           string userInput = Console.ReadLine();

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
}

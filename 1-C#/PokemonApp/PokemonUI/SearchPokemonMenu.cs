using PokemonBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonUI
{
    internal class SearchPokemonMenu : IMenu
    {
        IPokemonLogic repo = new PokemonLogic();
        public void Display()
        {
            Console.WriteLine("Please select an option to filter the pokemon database");
            Console.WriteLine("Press <1> By Name");
            Console.WriteLine("Press <0> Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    // Logic to display results
                    Console.Write("Please enter the name ");
                    string name = Console.ReadLine();
                    var results=repo.SearchPokemon(name);
                    if (results.Count() > 0)
                    {
                        foreach (var r in results)
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
}

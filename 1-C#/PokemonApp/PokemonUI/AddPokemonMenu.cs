using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonModels;
namespace PokemonUI
{
    internal class AddPokemonMenu : IMenu
    {
        private static Pokemon newPokemon = new Pokemon();
        public void Display()
        {
            Console.WriteLine("Enter Pokemon Information");
            Console.WriteLine("<3> Name - " + newPokemon.Name);
            Console.WriteLine("<2> Level - " + newPokemon.Level);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddPokemon";
            }
        }
    }
}

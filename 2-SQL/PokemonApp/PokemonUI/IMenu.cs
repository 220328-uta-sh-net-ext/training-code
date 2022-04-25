using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonUI
{
    /*
     Interface are one of the best way to implement abstraction
     Every method is inplicitly abstract meaning you don't have to define your method
     Every method in interface is by default public so don't use public as a keyword
     */
    public interface IMenu
    {
        /// <summary>
        /// Will display the menu and user choices in the terminal
        /// </summary>
        void Display();

        /// <summary>
        /// Will record the user's choice and change/route your menu based on that choice
        /// </summary>
        /// <returns>Return the menu that will change your screen</returns>
        string UserChoice();

    }
    interface IMoreMenu
    {
        void Exit();

        void Continue();
    }
}

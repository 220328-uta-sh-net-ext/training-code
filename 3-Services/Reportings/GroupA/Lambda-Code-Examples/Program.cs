using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Program
    {
        static void Main(string[] args)
        {
            // => is called the Goes To operator, or the Lambda operator,
            // whatever is on the left side of the operator is the input, or the parameter,
            // whatever on the right of it is the expression.

            // there are two types of lambda expressions: lambda expression and lambda statements

            // lambda expression syntax is:   (input/parameter) => (expression) ex. var allpoke = starter.Select(p => p.name);
            // syntax for lambda statement is: (input/parameter) => {
            //                                   (statments)
            //                                 }

            // lambda expressions will return the value implicitly,
            // while with the lambda statements you'd have to explictly state the return keyword next to the expression to get your value

            List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // lambda expression
            Func<int, int, int> add = (x, y) => x + y;

            // lambda statement
            Func<int, int, int> add2 = (x, y) =>
            {
                var sum = x + y;
                return sum;
            };

            //Console.WriteLine(add(2, 3));

            //Console.WriteLine("------");

            //Console.WriteLine(add2(4, 6));

            // lambda expression for finding all the odd numbers within a list
            List<int> odd = numbers.FindAll(x => (x % 2 == 1));
            foreach (int od in odd)
            {
                //Console.WriteLine("{0} is odd", od);
                //Console.WriteLine("---------");
            }

            //list of pokemon from the first four trainer regions/generations
            var starter = new List<PokeStarter>
            {
                new PokeStarter{name = "Charmander", type = "Fire", region = "Kanto", trainer = "Ash"},
                new PokeStarter{name = "Squirtle", type = "Water", region = "Kanto", trainer = "Misty"},
                new PokeStarter{name = "Bulbasaur", type = "Grass", region = "Kanto", trainer = "Brock"},

                new PokeStarter{name = "Cyndaquil", type = "Fire", region = "Johto", trainer = "Ash"},
                new PokeStarter{name = "Totodile", type = "Water", region = "Johto", trainer = "Misty"},
                new PokeStarter{name = "Chikorita", type = "Grass", region = "Johto", trainer = "Brock"},

                new PokeStarter{name = "Torchic", type = "Fire", region = "Hoenn", trainer = "Max"},
                new PokeStarter{name = "Mudkip", type = "Water", region = "Hoenn", trainer = "Ash"},
                new PokeStarter{name = "Treecko", type = "Grass", region = "Hoenn", trainer = "May"},

                new PokeStarter{name = "Chimchar", type = "Fire", region = "Sinnoh", trainer = "Ash"},
                new PokeStarter{name = "Piplup", type = "Water", region = "Sinnoh", trainer = "Dawn"},
                new PokeStarter{name = "Turtwig", type = "Grass", region = "Sinnoh", trainer = "Brock"},
            };


            // returning pokemon from certain regions
            var kantopoke = starter.Where(p => p.region == "Kanto").Select(p => p.name);

            // returning pokemon by certain details
            var suggestedpoke = starter.Where(p => p.type == "Fire" && p.trainer == "Ash").Select(p => p.name);

            // returning all the names of the pokemon
            var allpoke = starter.Select(p => p.name);

            //sorting by the names of all the pokemon
            var sortedstarters = starter.OrderBy(x => x.name).ToList();
            
            foreach (var poke in sortedstarters)
            {
                //Console.WriteLine(string.Format("Starter's name is {0}, their type is {1}, their region is {2}, and their trainer's name is {3}.", poke.name, poke.type, poke.region, poke.trainer));
                //Console.WriteLine("-----------------------");
            }

            //Console.WriteLine(string.Join(", ", allpoke));

            Console.ReadLine();
        }
    }
}
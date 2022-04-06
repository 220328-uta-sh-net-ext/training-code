//Predefined namespace
global using System;

//User defined namespace
namespace HelloWorld
{
    //Types (Class, Enum, Struct, Delegate, interface)
    public class Program
    {
        // Main entry point - each project should have only 1 entry point (Main)
        public static void Main()
        {   
            // Comments - Single line. Comments are not processed by Compiler and CLR

            /* 
            multi
            line
            Comments
            */
            // This will print whatever is in the Paranthesis
         /**   Console.WriteLine("Welcome to Revature .Net training");
            Console.Write("Please enter your name ");
            var name = Console.ReadLine();// this will allow user to take input in string format
            var currentDate = DateTime.Now;
            // Environment.NewLine or \n or vbCrLf in vb -> line break
            // $ before "" its an interpolated Strings
            Console.WriteLine($"{Environment.NewLine}Current Date: {currentDate:d} and Current Time: {currentDate:t} \n\nHello {name}");
        **/
            Mathematics.Add();
        }
    }
   
}

namespace ExternalWorld
{
     public class Program{}
}
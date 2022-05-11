using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;

namespace Delegates
{
    public class DelegateEx2cs
    {
        public delegate void MyDelegate(string msg); //declaring a delegate

        class Program
        {
            static void Main(string[] args)
            {
                MyDelegate del = ClassA.MethodA;
                del("Hello World");

                del = ClassB.MethodB;
                del("Hello ");

                del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
                del("Hello World");
            }
        }

         class ClassA
        {
            internal static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }
        }

         class ClassB
        {
            internal static void MethodB(string message)
            {
                Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
            }
        }
    }
}
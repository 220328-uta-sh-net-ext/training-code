using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3
{
    /// <summary>
    ///Multicast delegate
    /// </summary>
    internal class ThirdExample
    { 
        class Program
        {
            public void Add(int x, int y)
            {
                Console.WriteLine("Sum is:" + (x + y));
            }
            public void Subtract(int x, int y)
            {
                Console.WriteLine("Difference is:" + (x - y));
            }
            public void Multiply(int x, int y)
            {
                Console.WriteLine("Product is:" + (x * y));
            }
            public void Divide(int x, int y)
            {
                Console.WriteLine("Quotient is:" + (x / y));
            }
        }
        public delegate void MultiCastDelegate(int a, int b);//declaring a delegate
        class ClsDelegate
        {
            static void Main()
            {
                Program obj1 = new Program();
                MultiCastDelegate objD = new MultiCastDelegate(obj1.Multiply);
                //to add reference of more functions to a delegate object, we use += operator.
                objD += obj1.Add;
                objD += obj1.Subtract;
                objD += obj1.Divide;
                objD(10, 10);
                objD -= obj1.Subtract;
                objD -= obj1.Divide;
                objD(50, 1);
                Console.ReadLine();
            }
        }
    }

}

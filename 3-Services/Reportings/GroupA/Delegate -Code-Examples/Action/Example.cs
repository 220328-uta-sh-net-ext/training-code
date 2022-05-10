using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    internal class Example
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            //Using Action delegate 
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
        }
    }
}

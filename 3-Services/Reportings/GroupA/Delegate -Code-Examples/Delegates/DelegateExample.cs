using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;

namespace MainDelegateStart
{
    public class DelegateExample
    {
          static void Display(string S) {  
            Console.WriteLine("My Name is :" + S);  
        }  
        delegate void X(string a);  //declaring a delegate
        static void Main(string[] args) {  
            X objD = new X(Display);  
            objD("Rathrola Prem Kumar");  
            Console.Read();  
        }  

    


    

    }
}

//For non-Generics
using System.Collections;
// for generics
using System.Collections.Generic;
namespace CSharpBasics
{
    public class CsharpCollections
    {
        public static void NonGenerics(){
            /*ArrayList employees=new ArrayList(); // create/initialize an arraylist
            employees.Add("Marcelle"); // we added item as string but it will be stored as object
            employees.Add("Fred");
            employees.Add(123);
            employees.Add(100.79);*/

            var employees = new ArrayList(){"Marcelle","Fred","Abacus",123, 100.79}; //another notation known as anonymous object notation
            //Console.WriteLine(employees[1]);
            Console.WriteLine($"Count - {employees.Count}");
            employees.Sort();
            foreach (var e in employees)
                {
                    Console.WriteLine(e);
                }
            
           // employees.Remove("Fred");
            Console.WriteLine($"Count - {employees.Count}");
        }

        public static void GenericList(){
            List<int> scores = new List<int>(){54,56,56,87,67,89};
            List<object> something = new List<object>(){"54",56,87,67,89}; // this is exactly like array list
            List<string> employees = new List<string>();
            employees.Add("Marcelle");
            employees.Add("Sonny");
            employees.Add("Steve");
            employees.Insert(2,"Ola");

            Console.WriteLine($"Count - {employees.Count}");
            employees.Sort();
            employees.Reverse();
            //employees.Remove("Steve");
            employees[2]="Greg";
            //employees.RemoveAt(2);
            //employees.Insert(2,"Greg");
            //Console.WriteLine(employees[1]);
            foreach (var e in employees)
            {
                Console.WriteLine(e);
            }
        }

        public static void GenericStack(){
            Stack<string> calls = new Stack<string>();
            calls.Push("9876543211");
            calls.Push("8765467898");
            calls.Push("6789876578");
            calls.Push("7890987678");

            calls.Pop();

            Console.WriteLine($" TOP of the stack {calls.Peek()}");
            foreach (var call in calls)
            {
                Console.WriteLine(call);
            }
        }
   
        public static void GenericDictionary(){
            Dictionary<int,string> employees=new Dictionary<int, string>();
            employees.Add(101,"Joe");
            employees.Add(102,"Kurt");
            employees.Add(103,"Conner");
            employees.Add(104,"John");

            employees[102] = "Bob";
            foreach (var e in employees.Keys)
            {
                Console.WriteLine($"{e} - {employees[e]}");
            }
        }

        public static void GenericLinkedList(){
            LinkedList<int> list=new LinkedList<int>();

            //add nodes to Linked list
            list.AddLast(24);
            list.AddLast(76);
            list.AddLast(100);
            list.AddLast(89);
        
            Console.WriteLine($"First - {list.First.Value}");
            Console.WriteLine($"Last - {list.Last.Value}");
            //list.Remove(list.First);
            list.AddBefore(list.First,66);
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }


        }
    }
}
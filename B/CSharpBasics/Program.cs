global using System;
using CSharpBasics;

Console.Write("Please enter a number ");
var x=Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter another number ");
var y=Convert.ToDouble(Console.ReadLine());

Mathematics obj=new Mathematics();//default constructor provides memory to the object of this class

var result=obj.Add(x,y); // pass by value

Console.WriteLine($"{x} + {y} = {result}");


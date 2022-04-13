global using System;
using CSharpBasics;

/*Console.Write("Please enter a number ");
var x = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter another number ");
var y=Convert.ToDouble(Console.ReadLine());

Mathematics obj=new Mathematics();//default constructor provides memory to the object of this class

var result=obj.Add(x,y); // pass by value

Console.WriteLine($"{x} + {y} = {result}");*/

// Arrays
//Collection.Arrays_1D();
//Collection.Arrays_MultiDimensional();
//Collection.JaggedArrays();

//int[] a = {45,0,76,0,49}; // shorthand for declaring and initializing an array
/*var result=Collection.Reverse(a);
foreach (var item in a)
{
     Console.Write(item + " ");
}
Console.WriteLine();
foreach (var item in result)
{
    Console.Write(item+ " ");
}*/

//CSharpArrays.MoveZeros(a);

//CsharpCollections.NonGenerics();

//CsharpCollections.GenericList();
//CsharpCollections.GenericStack();
//CsharpCollections.GenericDictionary();
//CsharpCollections.GenericLinkedList();

/*int numerator=0,denominator=0;
n1:
Console.Write("Please enter the numerator ");
try{
numerator = Convert.ToInt32(Console.ReadLine());
}
catch(OverflowException ex){
    Console.WriteLine("Too big number "+ ex.Message);
    goto n1;
}
catch(FormatException ex){
    Console.WriteLine("Please use a correct integer as input. "+ ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    goto n1;
}
Console.Write("Please enter the denominator ");
denominator = Convert.ToInt32(Console.ReadLine());
var result=ExceptionHandling.Divide(numerator, denominator);
Console.WriteLine(result);*/

/*try{
Temperature.CheckTemperature(80);
}
catch(TemperatureException ex){
    Console.WriteLine(ex.Message);
    //logging logic
}*/

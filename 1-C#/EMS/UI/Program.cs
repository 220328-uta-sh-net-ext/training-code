// Let's call Employee
using UI;

Employee emp = new Employee();
//emp.firstName = "Yunus";
//emp.lastName = "Khan";

//Employee.planet = "Mars"; // const can never be changed
Console.Write("Please enter first name of the employee ");
var firstName=Console.ReadLine();
Console.Write("Please enter last name of the employee ");
var lastName = Console.ReadLine();
Console.Write("Please enter id of the employee ");
var id = Console.ReadLine();
Console.Write("Please submit working hours of the employee ");
var hours= float.Parse(Console.ReadLine());

emp.DoTask(firstName,lastName,id,hours);

//Console.WriteLine($"Employee Id - {emp.id}\nEmployee Name - {emp.firstName} {emp.lastName}\nPlanet - {Employee.planet}");



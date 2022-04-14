// Let's call Employee
using UI;

Employee emp = new Employee();
//emp.firstName = "Yunus";
//emp.lastName = "Khan";

/*//Employee.planet = "Mars"; // const can never be changed
Console.Write("Please enter first name of the employee ");
var firstName=Console.ReadLine();
Console.Write("Please enter last name of the employee ");
var lastName = Console.ReadLine();
Console.Write("Please enter id of the employee ");
var id = Console.ReadLine();
Console.Write("Please submit working hours of the employee ");
var hours= float.Parse(Console.ReadLine());

emp.DoTask(firstName,lastName,id,hours);*/

Manager mgr = new Manager();
/*mgr.authority = Authority.Hire;
Console.WriteLine(mgr.GetDetails(age:45,firstName:"David", lastName:"Fay",id:"303"));*/

/*emp.FirstName = "";
Console.WriteLine(emp.FirstName);*/

//method overloading
emp.payRate = 55.60M;
emp.hours = 8;
emp.taxes = 0.3M * emp.payRate;
Console.WriteLine($"Employee Id - {emp.Id}\nEmployee Name - {emp.FirstName} {emp.LastName}\nPlanet - {Employee.planet}");
Console.WriteLine($"Salary = ${emp.CalculateSalary("100.00", "100")*20}/month");


// call method overriding

mgr.FirstName = "Steven";
mgr.LastName = "Kelsey";
mgr.Id = "Rev111";
mgr.age = 40;
mgr.authority = Authority.Delegate;

mgr.payRate = 150.00M;
mgr.hours = 8;
mgr.healthCare = 155;
mgr.taxes = 0.4M * mgr.payRate;
mgr.bonus = 100;
mgr.housing = 1000;
mgr.paidVacation = 800;

Console.WriteLine(mgr.ToString());
Console.WriteLine($"Salary = ${mgr.CalculateSalary(120,0.3M*120)*20}/month");





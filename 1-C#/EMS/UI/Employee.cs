using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    enum Authority
    {
        Hire, Fire, Delegate
    }
    // parent/super/Base
    public class Employee
    {
        // members -> variables, constants, methods, events, constructors etc......
        //variable => State of the object
        string firstName = "Joe", lastName = "Dow", id = "101";

        public string Id { 
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            // properties allows to read values
            get {
                if (string.IsNullOrEmpty(firstName))
                    throw new ArgumentNullException("firstname is blank or empty, please input a calid firstname");
                else
                    return firstName;
            } 
            set { firstName = value; }  // to enable writing
        }

        public string LastName
        {
            // properties allows to read values
            get
            {
                if (string.IsNullOrEmpty(lastName))
                    throw new ArgumentNullException("firstname is blank or empty, please input a calid firstname");
                else
                    return lastName;
            }
            set { lastName = value; }  // to enable writing
        }
        //auto-property -> which means there is no private variable declared but this would create it behind the scene
        public string Password { get; set; } 
        
        public const string planet = "Earth";
        internal int age;

        // Salary components of employees
        internal decimal payRate, taxes, healthCare, bonus, reimbursements;
        internal decimal hours, overtime;
        public virtual decimal CalculateSalary() // method with no parameter
        {
            return payRate*hours + reimbursements + bonus - healthCare - taxes;
        }

        public decimal CalculateSalary(decimal payRate, decimal taxes) //method overload with  different number of parameter
        {
            return payRate*hours - taxes;
        }

        public decimal CalculateSalary(string payRate, string taxes)//method overload with different type of parameter
        {
            return decimal.Parse(payRate) * hours - decimal.Parse(taxes);
        }
        public decimal CalculateSalary(string payRate, decimal taxes) // method with different sequence of parameters
        {
            return decimal.Parse(payRate) * hours - taxes;
        }

        //Methods=>Behaviour
        public void DoTask(string firstName, string lastName, string id, float hours)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            Console.WriteLine($"{firstName} {lastName} writes program in C# for {hours} hours over weekdays");
        }
    }
    //child/sub/derived class 
    class Manager : Employee
    {
       public Authority authority;

       internal decimal housing, paidVacation;
        // this is method overriding which means re-defining the method of base class in child class
        public override decimal CalculateSalary()
        {
         return base.payRate*base.hours + base.bonus+ base.reimbursements - base.healthCare - base.taxes+ housing + paidVacation +base.overtime;
        }

        public override string ToString()
        {
            return $"Manager Id - {base.Id}\nManager Name - {base.FirstName} {base.LastName}\nAge - {base.age}\nAuthority - {authority}\nPlanet - {Employee.planet}";
        }
        // Hiding the implementation of the method in base class
        public new decimal CalculateSalary(string payRate, string taxes)
        {
            return 0.0M;
        }
        /*public string GetDetails(string firstName, string lastName, string id, int age)
         {
             base.firstName = firstName;
             base.lastName = lastName;
             base.age = age;
             base.id = id;
             authority = Authority.Hire;
            return $"Name - {firstName} {lastName}\nAge - {age}\nEmployee id - {id}";
         }*/
    }
    
}

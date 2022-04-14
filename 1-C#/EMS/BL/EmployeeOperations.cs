using UI;
using DL;
namespace BL
{
    public abstract class EmployeeOperations
    {
        //AddEmployee -> an abstract method with only method declaration and no implementation
        public abstract void Add(DL.Employee employee);
        //RemoveEmployee
        public abstract void Delete(DL.Employee employee);
        //FindEmployee
        public abstract DL.Employee SearchEmployee(string id);
        //ModifyEmployee
        public abstract DL.Employee Update(DL.Employee employee);
        // Calculate Salary
        public virtual decimal CalculateSalary(decimal payRate, decimal taxes, int hours) //method overload with  different number of parameter
        {
            return payRate * hours - taxes;
        }
    }
    public class EmployeeImplementation : IEmployeeOperations//: EmployeeOperations //implements the abstract class
    {
        public void Add(DL.Employee employee)
        {
            //code for Adding an employee
            throw new NotImplementedException();
        }

        public void Delete(DL.Employee employee)
        {
            //code for removing an employee
            throw new NotImplementedException();
        }

        public DL.Employee SearchEmployee(string id)
        {
            //code for searching an employee
            throw new NotImplementedException();
        }

        public DL.Employee Update(DL.Employee employee)
        {
            //code for modifying an existing employee
            throw new NotImplementedException();
        }
    }
}
using DL;

namespace BL
{
    internal interface IEmployeeOperations
    {
        void Add(DL.Employee employee);
        void Delete(DL.Employee employee);
        DL.Employee SearchEmployee(string id);
        DL.Employee Update(DL.Employee employee);
    }
}

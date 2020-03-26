using APIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Repositories
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployee(int id);
        ReturnEntity SaveEmployee(Employee e);
        ReturnEntity UpdateEmployee(Employee e);
        ReturnEntity DeleteEmployee(int id);
    }
}

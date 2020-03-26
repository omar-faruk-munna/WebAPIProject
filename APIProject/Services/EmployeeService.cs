using APIProject.Models;
using APIProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Services
{
    public class EmployeeService : IEmployeeRepo
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){ EmployeeId = 101, Name = "Omar", Phone = "01985101569"},
            new Employee(){ EmployeeId = 102, Name = "Faruk", Phone = "01478123456"},
            new Employee(){ EmployeeId = 103, Name = "Munna", Phone = "01345789123"},
            new Employee(){ EmployeeId = 104, Name = "Masud", Phone = "01852456987"},
            new Employee(){ EmployeeId = 105, Name = "Sharif", Phone = "01756852494"}
        };


        public ReturnEntity DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            try
            {
                list = employees;
            }
            catch (Exception)
            {
                Employee newEmp = new Employee()
                {
                    StatusCode = "204",
                    Status = "Failed",
                    Message = "Operation Failed"
                };
                list.Add(newEmp);
            }
            return list;
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public ReturnEntity SaveEmployee(Employee e)
        {
            throw new NotImplementedException();
        }

        public ReturnEntity UpdateEmployee(Employee e)
        {
            throw new NotImplementedException();
        }
    }
}

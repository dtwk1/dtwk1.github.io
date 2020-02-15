using ServerSideSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideSPA.Interface
{
    public interface IEmployee
    {
         List<Employee> GetAllEmployees();
         void AddEmployee(Employee employee);
         void UpdateEmployee(Employee employee);
         Employee GetEmployeeData(int id);
         void DeleteEmployee(int id);
         List<Cities> GetCityData();
    }
}

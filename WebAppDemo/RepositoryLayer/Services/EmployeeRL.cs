using CommanLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services
{
    public class EmployeeRL : IEmployeeRL
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){ name = "Shreya", age = 25, phoneNumber = 41452655}
        };
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}

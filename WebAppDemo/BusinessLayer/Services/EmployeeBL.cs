using BusinessLayer.Interface;
using CommanLayer;
using RepositoryLayer.Services;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class EmployeeBL : IEmployeeBL
    {
        private IEmployeeRL Employee;
        public EmployeeBL(IEmployeeRL Employee)
        {
            this.Employee = Employee;
        }

        public List<Employee> GetEmployee()
        {
            return this.Employee.GetEmployees();
        }
    }
}

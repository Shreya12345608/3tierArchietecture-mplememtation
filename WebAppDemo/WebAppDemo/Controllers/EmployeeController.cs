
using BusinessLayer.Interface;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeBL Employee;
        public EmployeeController(IEmployeeBL employee)
        {
            this.Employee = employee;
        }

        [HttpGet]
        public ActionResult GetEmployee()
        {
            var employees = Employee.GetEmployee();
            return this.Ok(new { Success = true, Message = "Get Employee SuccessFull", Data = employees });
        }
    }
}

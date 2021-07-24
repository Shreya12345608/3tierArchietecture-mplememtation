using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //List<Employee> employees = new List<Employee> { new Employee() { Name = "ShreyaM", Address = "Nagpur", PhoneNo = "7894564444" } };
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            int count = 0;
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                id = count++,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        //[Route("Employee")]
        //[HttpGet]
        //public IEnumerable<Employee> GetEmployee()
        //{

        //    return employees;

        //}
        //[Route("employee")]
        //[HttpPost]
        //public Employee Post(Employee employee)
        //{
        //    employee.id += 1;
        //    employee.Name += " Updated From Controller";
        //    employee.Address += " Updated From Controller";
        //    employee.PhoneNo += " Updated From Controller";
        //    employees.Add(employee);
        //    return employee;
        //}
    }
}



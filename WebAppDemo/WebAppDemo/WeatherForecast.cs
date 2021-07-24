using System;

namespace WebAppDemo
{
    public class WeatherForecast
    {
        public int id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
    // Model class
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; } 

    }
}

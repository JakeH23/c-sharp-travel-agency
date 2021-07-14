﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace c_sharp_travel_agency
{
    public class Agency
    {

        public List<Employee> Employees { get; set; }
        public List<Hotel> Hotels { get; set; }

        public Agency()
        {
            Employees = GetEmployees();
            Hotels = GetHotels();
        }

        private List<Employee> GetEmployees()
        {
            var employeeDataPath = File.ReadAllText(@"../../../../c-sharp-travel-agency/data/employees.json");
            return JsonSerializer.Deserialize<List<Employee>>(employeeDataPath);

        }

        private List<Hotel> GetHotels()
        {
            var hotelDataPath = File.ReadAllText(@"../../../../c-sharp-travel-agency/data/hotels.json");
            return JsonSerializer.Deserialize<List<Hotel>>(hotelDataPath);

        }
    }
}
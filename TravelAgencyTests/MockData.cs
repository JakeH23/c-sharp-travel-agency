using System;
using System.Collections.Generic;
using System.Text;
using c_sharp_travel_agency.models;

namespace TravelAgencyTests
{
    public class MockData
    {
        public List<Employee> Employees => GetTestEmployeeData();
        public List<Hotel> Hotels => GetTestHotelData();

        private static List<Employee> GetTestEmployeeData()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jake",
                    Surname = "Heaney"
                }
            };
        }

        private static List<Hotel> GetTestHotelData()
        {
            return new List<Hotel>
            {
                new Hotel
                {
                    Name = "Hilton",
                    City = "Manchester",
                    CostPerNight = 50,
                    StarRating = 3.5
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO.Abstractions.TestingHelpers;
using System.Text.Json;
using c_sharp_travel_agency;
using Moq;
using Xunit;

namespace TravelAgencyTests
{
    public class AgencyTests
    {
        private readonly Agency _agency;
        private readonly List<Employee> _employees = AgencyDataGetterFake<Employee>(InformationType.Employees, GetTestEmployeeData());
        private readonly List<Hotel> _hotels = AgencyDataGetterFake<Hotel>(InformationType.Hotels, GetTestHotelData());

        public AgencyTests()
        {
            var agencyData = new Mock<IAgencyData>();
            agencyData.Setup(x => x.GetData<Employee>(InformationType.Employees)).Returns(_employees);
            agencyData.Setup(x => x.GetData<Hotel>(InformationType.Hotels)).Returns(_hotels);

            _agency = new Agency(agencyData.Object);
        }

        [Fact]
        public void CheckAgencyIsInitializedWithWEmployeeData()
        {
            Assert.NotEmpty(_agency.Employees);
        }

        [Fact]
        public void CheckEmployeeDataIsAsExpected()
        {
            Assert.Equal("Jake", _agency.Employees[0].FirstName);
        }

        [Fact]
        public void CheckAgencyIsInitializedWithHotelData()
        {
            Assert.NotEmpty(_agency.Hotels);
        }

        [Fact]
        public void CheckHotelDataIsAsExpected()
        {
            Assert.Equal("Manchester", _agency.Hotels[0].City);
        }

        private static List<T> AgencyDataGetterFake<T>(InformationType fileName, string fakeData)
        {
            var mockFileSystem = new MockFileSystem();
            var mockInputFile = new MockFileData(fakeData);

            mockFileSystem.AddFile($"{fileName}.json", mockInputFile);

            var path = mockFileSystem.File.ReadAllText($"{fileName}.json");
            return JsonSerializer.Deserialize<List<T>>(path);
        }

        private static string GetTestEmployeeData()
        {
            var employeeList = new List<Employee>
            {
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jake",
                    Surname = "Heaney"
                }
            };

            return JsonSerializer.Serialize(employeeList);
        }

        private static string GetTestHotelData()
        {
            var hotelList = new List<Hotel>
            {
                new Hotel
                {
                    Name = "Hilton",
                    City = "Manchester",
                    CostPerNight = 50,
                    StarRating = 3.5
                }
            };

            return JsonSerializer.Serialize(hotelList);
        }
    }
}

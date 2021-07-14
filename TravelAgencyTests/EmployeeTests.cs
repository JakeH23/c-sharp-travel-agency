using c_sharp_travel_agency;
using System;
using Xunit;

namespace TravelAgencyTests
{
    public class EmployeeTests
    {
        [Fact]
        public void CheckIdIsSetForEmployee()
        {
            var employee = new Employee();

            Assert.NotEqual(employee.Id, Guid.Empty);
        }

        [Fact]
        public void CheckFirstNameIsSetForEmployee()
        {
            var employee = new Employee();
            employee.FirstName = "jake";

            Assert.Equal("jake", employee.FirstName);
        }

        [Fact]
        public void CheckSurnameIsSetForEmployee()
        {
            var employee = new Employee();
            employee.Surname = "Heaney";

            Assert.Equal("Heaney", employee.Surname);
        }
    }
}

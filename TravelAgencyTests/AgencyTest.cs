using System;
using c_sharp_travel_agency;
using Xunit;


namespace TravelAgencyTests
{
    public class AgencyTest
    {
        [Fact]
        public void CheckAgencyIsInitializedWithWEmployeeData()
        {
            var agency = new Agency();

            Assert.NotEmpty(agency.Employees);

        }

        [Fact]
        public void CheckEmployeeDataIsAsExpected()
        {
            var agency = new Agency();

            Assert.Equal("Tom", agency.Employees[0].FirstName);

        }

        [Fact]
        public void CheckAgencyIsInitializedWithHotelData()
        {
            var agency = new Agency();

            Assert.NotEmpty(agency.Hotels);

        }
        [Fact]
        public void CheckHotelDataIsAsExpected()
        {
            var agency = new Agency();

            Assert.Equal("Paris", agency.Hotels[0].City);

        }
    }
}

using System.IO.Abstractions;
using c_sharp_travel_agency.enums;
using c_sharp_travel_agency.models;
using c_sharp_travel_agency.services;
using Moq;
using Xunit;

namespace TravelAgencyTests
{
    public class AgencyTests
    {
        private readonly Agency agency;

        public AgencyTests()
        {
            var mockData = new MockData();
            var agencyData = new Mock<IAgencyData>();
            var file = Mock.Of<IFile>();
            agencyData.Setup(x => x.GetData<Employee>(InformationType.Employees, file)).Returns(mockData.Employees);
            agencyData.Setup(x => x.GetData<Hotel>(InformationType.Hotels, file)).Returns(mockData.Hotels);

            agency = new Agency(agencyData.Object, file);
        }

        [Fact]
        public void CheckAgencyIsInitializedWithEmployeeData()
        {
            Assert.NotEmpty(agency.Employees);
        }

        [Fact]
        public void CheckEmployeeDataIsAsExpected()
        {
            Assert.Equal("Jake", agency.Employees[0].FirstName);
        }

        [Fact]
        public void CheckAgencyIsInitializedWithHotelData()
        {
            Assert.NotEmpty(agency.Hotels);
        }

        [Fact]
        public void CheckHotelDataIsAsExpected()
        {
            Assert.Equal("Manchester", agency.Hotels[0].City);
        }
    }
}

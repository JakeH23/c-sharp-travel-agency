using c_sharp_travel_agency;
using Moq;
using Xunit;

namespace TravelAgencyTests
{
    public class AgencyTests
    {
        private readonly Agency _agency;

        public AgencyTests()
        {
            var agencyData = new Mock<IAgencyData>();
            var mockAgencyDataService = new MockAgencyDataService();

            agencyData.Setup(x => x.GetEmployeeData()).Returns(mockAgencyDataService.GetEmployeeData());
            agencyData.Setup(x => x.GetHotelData()).Returns(mockAgencyDataService.GetHotelData());
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
            Assert.Equal("Tom", _agency.Employees[0].FirstName);
        }

        [Fact]
        public void CheckAgencyIsInitializedWithHotelData()
        {
            Assert.NotEmpty(_agency.Hotels);
        }

        [Fact]
        public void CheckHotelDataIsAsExpected()
        {
            Assert.Equal("Paris", _agency.Hotels[0].City);
        }
    }
}

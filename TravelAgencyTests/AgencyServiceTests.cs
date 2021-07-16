using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;
using System.Text.Json;
using c_sharp_travel_agency.enums;
using c_sharp_travel_agency.models;
using c_sharp_travel_agency.services;
using Moq;
using Xunit;

namespace TravelAgencyTests
{
    public class AgencyServiceTests
    {
        private readonly IFile file;

        public AgencyServiceTests()
        {
            file = Mock.Of<IFile>();
        }

        [Fact]
        public void CheckFileServiceReturnsEmployeeDataAsExpected()
        {
            var sut = new AgencyDataService();

            var mockData = new MockData();
            var employeeDataToString = JsonSerializer.Serialize(mockData.Employees);

            Mock.Get(file).Setup(f => f.ReadAllText(It.IsAny<string>())).Returns(AgencyDataGetterFake<Employee>(InformationType.Employees, employeeDataToString));

            var res = sut.GetData<Employee>(InformationType.Employees, file);

            Assert.NotEmpty(res);
            Assert.Equal("Jake", res[0].FirstName);
        }

        [Fact]
        public void CheckFileServiceReturnsHotelDataAsExpected()
        {
            var sut = new AgencyDataService();

            var mockData = new MockData();
            var hotelDataToString = JsonSerializer.Serialize(mockData.Hotels);

            Mock.Get(file).Setup(f => f.ReadAllText(It.IsAny<string>())).Returns(AgencyDataGetterFake<Hotel>(InformationType.Hotels, hotelDataToString));

            var res = sut.GetData<Hotel>(InformationType.Hotels, file);

            Assert.NotEmpty(res);
            Assert.Equal("Hilton", res[0].Name);
        }

        private static string AgencyDataGetterFake<T>(InformationType fileName, string fakeData)
        {
            var mockFileSystem = new MockFileSystem();
            var mockInputFile = new MockFileData(fakeData);

            mockFileSystem.AddFile($"{fileName}.json", mockInputFile);

            var t = mockFileSystem.GetFile($"{fileName}.json");
            return t.TextContents;
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace c_sharp_travel_agency
{
    public interface IAgencyData
    {
        List<Employee> GetEmployeeData();
        List<Hotel> GetHotelData();
    }

    public class AgencyDataService : IAgencyData
    {
        public List<Employee> GetEmployeeData()
        {
            var employeeDataPath = File.ReadAllText(@"../../../../c-sharp-travel-agency/data/employees.json");
            return JsonSerializer.Deserialize<List<Employee>>(employeeDataPath);
        }

        public List<Hotel> GetHotelData()
        {
            var hotelDataPath = File.ReadAllText(@"../../../../c-sharp-travel-agency/data/hotels.json");
            return JsonSerializer.Deserialize<List<Hotel>>(hotelDataPath);
        }
    }
}
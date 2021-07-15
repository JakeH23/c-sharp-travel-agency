using System.Collections.Generic;

namespace c_sharp_travel_agency
{
    public class Agency
    {
        public List<Employee> Employees { get; private set; }
        public List<Hotel> Hotels { get; private set; }

        public Agency(IAgencyData agencyData)
        {
            Employees = agencyData.GetEmployeeData();
            Hotels = agencyData.GetHotelData();
        }
    }
}

using System.Collections.Generic;
using c_sharp_travel_agency.enums;
using c_sharp_travel_agency.services;

namespace c_sharp_travel_agency.models
{
    public class Agency
    {
        public List<Employee> Employees { get; }
        public List<Hotel> Hotels { get; }

        public Agency(IAgencyData agencyData)
        {
            Employees = agencyData.GetData<Employee>(InformationType.Employees);
            Hotels = agencyData.GetData<Hotel>(InformationType.Hotels);
        }
    }
}

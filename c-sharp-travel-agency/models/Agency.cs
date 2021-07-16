using System.Collections.Generic;
using System.IO.Abstractions;
using c_sharp_travel_agency.enums;
using c_sharp_travel_agency.services;

namespace c_sharp_travel_agency.models
{
    public class Agency
    {
        public List<Employee> Employees { get; }
        public List<Hotel> Hotels { get; }

        public Agency(IAgencyData agencyData, IFile file)
        {
            Employees = agencyData.GetData<Employee>(InformationType.Employees, file);
            Hotels = agencyData.GetData<Hotel>(InformationType.Hotels, file);
        }
    }
}

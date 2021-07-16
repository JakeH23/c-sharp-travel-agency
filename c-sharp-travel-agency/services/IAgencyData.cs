using System.Collections.Generic;
using c_sharp_travel_agency.enums;

namespace c_sharp_travel_agency.services
{
    public interface IAgencyData
    {
        List<T> GetData<T>(InformationType fileName);
    }
}
using System.Collections.Generic;
using System.IO.Abstractions;
using c_sharp_travel_agency.enums;

namespace c_sharp_travel_agency.services
{
    public interface IAgencyData
    {
        List<T> GetData<T>(InformationType fileName, IFile file);
    }
}
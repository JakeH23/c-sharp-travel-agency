using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using c_sharp_travel_agency.enums;

namespace c_sharp_travel_agency.services
{
    public class AgencyDataService : IAgencyData
    {
        public List<T> GetData<T>(InformationType fileName)
        {
            var path = File.ReadAllText(@$"../../../../c-sharp-travel-agency/data/{fileName}.json");
            return JsonSerializer.Deserialize<List<T>>(path);
        }
    }
}
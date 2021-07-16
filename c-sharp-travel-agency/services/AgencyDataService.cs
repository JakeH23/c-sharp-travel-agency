using System.Collections.Generic;
using System.IO.Abstractions;
using System.Text.Json;
using c_sharp_travel_agency.enums;

namespace c_sharp_travel_agency.services
{
    public class AgencyDataService : IAgencyData
    {
        private const string DataFilePath = "../../../../c-sharp-travel-agency/data";

        public List<T> GetData<T>(InformationType fileName, IFile file)
        {
            var path = file.ReadAllText(@$"{DataFilePath}/{fileName}.json");
            return JsonSerializer.Deserialize<List<T>>(path);
        }
    }
}
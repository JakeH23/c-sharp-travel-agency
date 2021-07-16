using System.IO.Abstractions;
using c_sharp_travel_agency.services;

namespace c_sharp_travel_agency
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var dataService = new AgencyDataService();
            var file = new FileWrapper(new FileSystem());
            var console = new ConsoleService(dataService, file);

            console.InitialGreeting();
            console.DisplayOptions();
        }
    }
}

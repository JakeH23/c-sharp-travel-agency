using c_sharp_travel_agency.services;

namespace c_sharp_travel_agency
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var console = new ConsoleService(new AgencyDataService());

            console.InitialGreeting();
            console.DisplayOptions();
        }
    }
}

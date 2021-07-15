namespace c_sharp_travel_agency
{
    public class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleService(new AgencyDataService());

            console.InitialGreeting();
            console.DisplayOptions();
        }
    }
}

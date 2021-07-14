namespace c_sharp_travel_agency
{
    public class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleService();

            console.CustomGreeting("jake");
            console.DisplayOptions();
        }
    }
}

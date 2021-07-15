using System;

namespace c_sharp_travel_agency
{
    public class ConsoleService
    {
        private readonly Agency _agency;

        public ConsoleService(IAgencyData agencyData)
        {
            _agency = new Agency(agencyData);
        }

        public void CustomGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public void DisplayOptions()
        {
            while (true)
            {
                Console.WriteLine("Choose an option below:");
                Console.WriteLine("A - Read Hotels");
                Console.WriteLine("B - Read Employees");
                Console.Write("Option Chosen: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                    {
                        Console.WriteLine("Hotels");

                        foreach (var hotel in _agency.Hotels)
                        {
                            Console.WriteLine($"{hotel.Name}, {hotel.City}");
                        }
                        break;
                    }
                    case "B":
                    {
                        Console.WriteLine("Employee Names");

                        foreach (var employee in _agency.Employees)
                        {
                            Console.WriteLine($"Name: {employee.FirstName} {employee.Surname}, Id: {employee.Id}");
                        }
                        break;
                    }
                    default:
                        Console.WriteLine("Please provide a valid option");
                        continue;
                }
                break;
            }
        }
    }
}

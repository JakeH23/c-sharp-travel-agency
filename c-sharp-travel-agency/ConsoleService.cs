using System;

namespace c_sharp_travel_agency
{
    public class ConsoleService
    {
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

                var agency = new Agency();

                if (choice == "A")
                {
                    Console.WriteLine("Hotels");

                    foreach (var hotel in agency.Hotels)
                    {
                        Console.WriteLine($"{hotel.Name}, {hotel.City}");
                    }
                }
                else if (choice == "B")
                {
                    Console.WriteLine("Employee Names");

                    foreach (var employee in agency.Employees)
                    {
                        Console.WriteLine($"Name: {employee.FirstName} {employee.Surname}, Id: {employee.Id}");
                    }
                }
                else
                {
                    Console.WriteLine("Please provide a valid option");
                    continue;
                }

                break;
            }
        }
    }
}

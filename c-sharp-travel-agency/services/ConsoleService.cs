using System;
using c_sharp_travel_agency.models;

namespace c_sharp_travel_agency.services
{
    public class ConsoleService
    {
        private readonly Agency agency;
        private string userName = "";

        public ConsoleService(IAgencyData agencyData)
        {
            agency = new Agency(agencyData);
        }

        public void InitialGreeting()
        {
            Console.WriteLine("Hello, welcome to Heaney Holidays.");
            Console.Write("Please may I take your name: ");

            var name = Console.ReadLine();
            userName = name;
            Console.WriteLine($"Thanks, {name}.");
            Console.WriteLine("How can I help you today?");
        }

        public void DisplayOptions()
        {
            while (true)
            {
                Console.WriteLine("A - Read Hotels");
                Console.WriteLine("B - Read Employees");
                Console.Write("Option Chosen: ");
                var choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "A":
                        {
                            Console.WriteLine($"Here is a list of our Hotels for you {userName}");

                            foreach (var hotel in agency.Hotels)
                            {
                                Console.WriteLine($"{hotel.Name}, {hotel.City}");
                            }
                            FurtherAssistance();
                            break;
                        }
                    case "B":
                        {
                            Console.WriteLine($"Here is a list of our Employees for you {userName}");

                            foreach (var employee in agency.Employees)
                            {
                                Console.WriteLine($"Name: {employee.FirstName} {employee.Surname}, Id: {employee.Id}");
                            }
                            FurtherAssistance();
                            break;
                        }
                    default:
                        Console.WriteLine("Please provide a valid option");
                        continue;
                }
                break;
            }
        }

        private void FurtherAssistance()
        {
            while (true)
            {
                Console.Write("Is there anything else I can assist with today? (y/n) - ");
                var choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "Y":
                        DisplayOptions();
                        break;
                    case "N":
                        Console.WriteLine($"Have a great day {userName}! Goodbye!");
                        break;
                    default:
                        continue;
                }
                break;
            }
        }
    }
}

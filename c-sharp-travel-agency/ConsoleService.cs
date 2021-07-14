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
            Console.WriteLine("Choose and option below?");
            Console.WriteLine("A - Read Hotels" + " B - Read Employees");
            Console.Write("Option Chosen: ");
            var choice = Console.ReadLine();

            var agency = new Agency();

            if (choice == "A")
            {
               
              
                foreach(var hotel in agency.Hotels)
                {
                    Console.WriteLine($"Name: {hotel.Name} City: {hotel.City}");
                }
            } else if(choice == "B")
            {
                foreach (var employee in agency.Employees)
                {
                    Console.WriteLine($"Name: {employee.FirstName} {employee.Surname}, Id: {employee.Id}");
                }
            } else
            {
                Console.WriteLine("Please provide a valid option");
                DisplayOptions();
            }

        }
    }
}

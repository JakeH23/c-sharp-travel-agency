using System;

namespace c_sharp_travel_agency
{
    public class Employee
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Employee()
        {
            Id = Guid.NewGuid();
        }
    }
}
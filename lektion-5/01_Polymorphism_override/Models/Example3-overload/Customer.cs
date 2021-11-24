using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polymorphism_override.Models
{
    internal class Customer : User
    {
        public Customer()
        {

        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override void GeneratePassword()
        {
            base.GeneratePassword();
            Console.WriteLine("Generating password for customer user.");
        }

        public override void GeneratePassword(string password)
        {
            Console.WriteLine($"using password {password} for customer user.");
        }
    }
}

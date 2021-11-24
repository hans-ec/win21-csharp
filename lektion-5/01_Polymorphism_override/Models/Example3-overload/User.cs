using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polymorphism_override.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public virtual void GeneratePassword()
        {
            Console.WriteLine("Generating password for general user.");
        }

        public virtual void GeneratePassword(string password)
        {
            Console.WriteLine($"Using password {password} for general user.");
        }
    }
}

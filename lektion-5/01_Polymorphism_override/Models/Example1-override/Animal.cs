using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polymorphism_override.Models
{
    internal class Animal
    {
        public int Age { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Djuret säger: ...");
        }
    }
}

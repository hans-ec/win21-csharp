using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Enums
{
    enum Planets
    {
        Sun,
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }


    internal class EnumNamespaceExample
    {
        public static void Run()
        {
            Console.WriteLine($"{Planets.Mars} är den {(int)Planets.Mars} planeten i vårt solsystem.");
        }
    }
}

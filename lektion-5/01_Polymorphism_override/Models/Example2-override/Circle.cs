using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polymorphism_override.Models
{
    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Ritar upp en cirkel");
            base.Draw();
        }
    }
}

using _03_Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstracts.Models
{
    internal abstract class DataStorage
    {
        public virtual void Connect()
        {
            Console.WriteLine("Cleaning buffer size before connecting.");
        }

        public abstract void Create(dynamic context);

        public abstract void Get();

    }
}

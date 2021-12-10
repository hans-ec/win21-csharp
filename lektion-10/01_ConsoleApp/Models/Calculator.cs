using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp.Models
{
    public class Calculator
    {
        public decimal Total { get; private set; } = 0;

        public void Add(decimal value)
        {
            Total += value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MulipleDataPoints.App.Handlers
{
    public class CalculatorHandler
    {
        public decimal Total { get; private set; } = 0;

        public void Add(decimal number)
        {
            Total += number;
        }
    }
}

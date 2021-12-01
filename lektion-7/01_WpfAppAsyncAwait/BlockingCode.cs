using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WpfAppAsyncAwait
{
    internal class BlockingCode
    {
        public static string Step1()
        {
            Task.Delay(4000).Wait();
            return "Step 1 completed\n";
        }
    }
}

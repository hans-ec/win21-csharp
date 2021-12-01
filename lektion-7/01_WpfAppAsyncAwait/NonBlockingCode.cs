using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WpfAppAsyncAwait
{
    internal class NonBlockingCode
    {
        public static async Task<string> Step1()
        {
            await Task.Delay(4000);
            return "Step 1 completed\n";
        }
    }
}

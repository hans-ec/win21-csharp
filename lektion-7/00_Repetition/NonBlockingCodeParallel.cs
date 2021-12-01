using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition
{
    internal class NonBlockingCodeParallel
    {
        public static void Run()
        {
            Task.Run(async () => await Step1());
            Task.Run(async () => await Step2());
            Task.Run(async () => await Step3());
            Console.WriteLine("Non-BlockingCode Parallell Klart.\n");
        }

        private static async Task Step1()
        {
            Console.WriteLine("Arbetar med steg 1");
            await Task.Delay(4000);
            Console.WriteLine("Steg 1 är nu klart.");
        }

        private static async Task Step2()
        {
            Console.WriteLine("Arbetar med steg 2");
            await Task.Delay(2000);
            Console.WriteLine("Steg 2 är nu klart.");
        }

        private static async Task Step3()
        {
            Console.WriteLine("Arbetar med steg 3");
            await Task.Delay(8000);
            Console.WriteLine("Steg 3 är nu klart.");
        }
    }
}

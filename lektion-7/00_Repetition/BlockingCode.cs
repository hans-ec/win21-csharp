using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition
{
    internal class BlockingCode
    {
        public static void Run()
        {
            Step1();
            Step2();
            Step3();
            Console.WriteLine("BlockingCode Klart.\n");
        }

        private static void Step1()
        {
            Console.WriteLine("Arbetar med steg 1");
            Task.Delay(4000).Wait();
            Console.WriteLine("Steg 1 är nu klart.");
        }

        private static void Step2()
        {
            Console.WriteLine("Arbetar med steg 2");
            Task.Delay(2000).Wait();
            Console.WriteLine("Steg 2 är nu klart.");
        }

        private static void Step3()
        {
            Console.WriteLine("Arbetar med steg 3");
            Task.Delay(8000).Wait();
            Console.WriteLine("Steg 3 är nu klart.");
        }
    }


}

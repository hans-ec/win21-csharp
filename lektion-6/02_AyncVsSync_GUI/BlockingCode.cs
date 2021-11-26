using _02_AyncVsSync_GUI.Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AyncVsSync_GUI
{
    internal class BlockingCode
    {
        // Sync (Synchronous) blokerar kod och körs sekvensiellt.

        public static void MakeTacos()
        {
            TacoMincedMeat tacoMincedMeat = FryMincedMeat();
            Console.WriteLine("Köttfärsen är klar.");

            Salad salad = MakeSalad(new List<string> { "gurka", "tomat", "paprika", "isbergssallad", "lök" });
            Console.WriteLine("Salladen är klar.");

            SetTable(4, salad, tacoMincedMeat);
            Console.WriteLine("Klart för att äta");
        }


        private static TacoMincedMeat FryMincedMeat()
        {
            Console.WriteLine("Bryner på köttfärsen.");
            Task.Delay(30000).Wait();

            Console.WriteLine("Har i tacokryddan.");
            Task.Delay(5000).Wait();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Rör om i köttfärsen...");
                Task.Delay(10000).Wait();
            }

            return new TacoMincedMeat();
        }

        private static Salad MakeSalad(List<string> vegetables)
        {
            foreach (string vegetable in vegetables)
            {
                Console.WriteLine($"Förbereder {vegetable}.");
                Task.Delay(2000).Wait();
                Console.WriteLine($"Hackar {vegetable}.");
                Task.Delay(5000).Wait();
                Console.WriteLine($"Lägger {vegetable}n i en skål.");
                Task.Delay(2000).Wait();
            }

            return new Salad();
        }

        private static void SetTable(int plates, Salad salad, TacoMincedMeat tacoMincedMeat)
        {
            Console.WriteLine($"Dukar bordet för {plates} peron(er).");
            Task.Delay(plates * 2000).Wait();

            Console.WriteLine("Ställer fram salladen");
            Task.Delay(1000).Wait();

            Console.WriteLine("Ställer fram köttfärsen");
            Task.Delay(1000).Wait();
        }
    }
}

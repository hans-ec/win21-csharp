using _01_AsyncVsSync.Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AsyncVsSync
{
    internal class NonBlockingParallelExample
    {
        public static async Task MakeTacosAsync()
        {
            Task<TacoMincedMeat> tacoMincedMeat = FryMincedMeatAsync();
            Task<Salad> salad = MakeSaladAsync(new List<string> { "gurka", "tomat", "paprika", "isbergssallad", "lök" });


            await SetTableAsync(4, await salad, await tacoMincedMeat);
            Console.WriteLine("Klart för att äta");
        }


        private static async Task<TacoMincedMeat> FryMincedMeatAsync()
        {
            Console.WriteLine("Bryner på köttfärsen.");
            await Task.Delay(30000);

            Console.WriteLine("Har i tacokryddan.");
            await Task.Delay(5000);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Rör om i köttfärsen...");
                await Task.Delay(10000);
            }

            return new TacoMincedMeat();
        }

        private static async Task<Salad> MakeSaladAsync(List<string> vegetables)
        {
            foreach (string vegetable in vegetables)
            {
                Console.WriteLine($"Förbereder {vegetable}.");
                await Task.Delay(2000);
                Console.WriteLine($"Hackar {vegetable}.");
                await Task.Delay(5000);
                Console.WriteLine($"Lägger {vegetable}n i en skål.");
                await Task.Delay(2000);
            }

            return new Salad();
        }

        private static async Task SetTableAsync(int plates, Salad salad, TacoMincedMeat tacoMincedMeat)
        {
            Console.WriteLine($"Dukar bordet för {plates} peron(er).");
            await Task.Delay(plates * 2000);

            Console.WriteLine("Ställer fram salladen");
            await Task.Delay(1000);

            Console.WriteLine("Ställer fram köttfärsen");
            await Task.Delay(1000);
        }
    }
}

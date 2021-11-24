using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DisposeAndFinalizers.AdvancedExample
{
    internal static class AdvancedExample
    {
        public static void Run() 
        {
            CreateConnectionAndMemoryExample(1000000);
            Console.WriteLine($"\nTotal Allocated Memory: {ConnectionAndMemoryExample.TotalAllocatedMemory}, Total Memory Freed: {ConnectionAndMemoryExample.TotalFreeMemory}");


            GC.Collect(3);
            GC.WaitForPendingFinalizers();
            GC.Collect(3);

            Console.ReadKey();
        }

        private static void CreateConnectionAndMemoryExample(int quantiy)
        {
            Random random = new Random();
            for(int i = 0; i < quantiy; i++)
            {
                int chunkSize = random.Next(4096);
                Console.WriteLine($"chuckSize: {chunkSize}");

                /*
                    Inte ett korrekt sätt att göra det på
                        var connectionAndMemoryExample = new ConnectionAndMemoryExample(chunkSize);
                        connectionAndMemoryExample.DoWork();
                */

                using (var connectionAndMemoryExample = new ConnectionAndMemoryExample(chunkSize))
                    connectionAndMemoryExample.DoWork();
            }
        }
    }
}

namespace _01_AsyncVsSync
{
    class Program
    {
        static async Task Main()
        {
            /*  
                Sync (Synchronous) blokerar kod och körs sekvensiellt. 
                ASync (ASynchronous) blokerar inte koden och körs sekvensiellt.
                ASync (ASynchronous) med Task gör att det kan köras parallellt.
                Task.Run(() => ) används när du inte kan ändra till async Task på din metod
            */

            BlockingCodeExample.MakeTacos();
            //Task.Run(() => BlockingCodeExample.MakeTacos());

            await NonBlockingExample.MakeTacosAsync();           
            //Task.Run(async () => await NonBlockingExample.MakeTacosAsync());

            await NonBlockingParallelExample.MakeTacosAsync();
            
            Console.ReadKey();
        }
    }
}

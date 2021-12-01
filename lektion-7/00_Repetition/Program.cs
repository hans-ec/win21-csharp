/*
    Sync (Synchronous)   - STANDARD och blokerar koden som körs och allt körs sekvensiellt. Först sak 1, sen sak 2, sen sak 3 ... 
    Async (Asynchronous) - blockarar inte koden utan den väntas in istället genom att använda async - await. 
    Async med Task.Run() - Gör att vi kan köra icke blockerande kod parallellt.
*/

using _00_Repetition;

BlockingCode.Run();

await NonBlockingCode.Run();

NonBlockingCodeParallel.Run();



Console.WriteLine("Nu är allt klart.");
Console.ReadKey();
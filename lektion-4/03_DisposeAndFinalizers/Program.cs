/*
    STACK           int, double, decimal, float, bool, enum, struct
    HEAP            array, list, object, string, class, dictionary 


        +-----------------------------------------------+   +-----------------------------------+  +-------------------------------- +                  
        | List<string> tableNames = new List<string>(); |   | var tableNames = GetTableNames(); |  | var conn = new SqlConnection(); |
        +-----------------------------------------------+   +-----------------------------------+  +---------------------------------+ 
                 |                                             |                                           |
                 +---------------------------------------------+                                           |
                 |                                                          +------------------------------+
                 |                                                          |  
                 V                                                          V
            +---------+         +---------+         +---------+         +---------+
STACK       | pointer |         | pointer |         | pointer |         | pointer |
            +---------+         +---------+         +---------+         +---------+
                |                   |                   |                   |
                V                   V                   V                   V
        +----------------+  +----------------+  +----------------+  +----------------+
HEAP    | memory address |  | memory address |  | memory address |  | memory address |
        +----------------+  +----------------+  +----------------+  +----------------+
            "TableNr1"       Name = "Anki"       conn = "dfasdf"      conn = "dfasdf"
            .....
                                    ?                    ?                   

        var customer = new Customer() { Name = "Anki" };
        customer = new Customer() { Name = "Joakim"; };



    Garbage Collector  
    ------------------------------------------------------------------------------------------------------------------------------
    Dispose (IDispsible)

    I C# sker det här automatiskt vi behöver egentligen inte tänka på detta, om det inte är akut i ett speciellt fall.
    I exempelvis C/C++ så behöver vi hantera det här manuellt MALLOC() - FREE()




        Dictionary
        ------------------------------------------------------
        Är en Key-Value Pair lista där vi kan spara in ett namn och ett värde för namnet precis som ett JS objekt eller Json objekt
        
        JS          { key: value }              let js = { age: 37 }
        JSON        { "key": value }            let json = { "age": 37 }
        C#          { "Key": Value}             var dictionary = new Dictionary<string, int>();
                                                dictionary.Add("Age", 37);
*/

using _03_DisposeAndFinalizers;
using _03_DisposeAndFinalizers.AdvancedExample;

//var memoryAllocationExample = new MemoryAllocationExample();
//memoryAllocationExample.Run();

//var memoryAllocationExampleTheRightWay = new MemoryAllocationExampleTheRightWay();
//memoryAllocationExampleTheRightWay.Run();

AdvancedExample.Run();
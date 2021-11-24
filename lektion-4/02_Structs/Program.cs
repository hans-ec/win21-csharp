/*
    HEAP vs. STACK (Memory Management)
    -------------------------------------------------------------------------------------------------------------
    STACK       snabb men klarar bara av enkla saker.
                direkt association.
                static innebär att det läggs i stacken.
                litet utrymme som kan fyllas upp snabbt.
                ger en stackoverflow exception

    HEAP        långsam men klarar av mer komplexa saker
                pekar på en plats
                dynamiskt allokerat dvs instance
                not set to an instance of an object


    STRUCT vs. CLASS
    -------------------------------------------------------------------------------------------------------------
    Value Types             STACK           int, double, decimal, float, bool, enum, struct
    Reference Types         HEAP            array, list, object, string, class

    Value Types             Har en direkt koppling till sin plats i minnet där informationen lagras
    Reference Types         Använder sig av en "pekare" för att peka på en plats i minnet där information lagras
    

            Value Types                                                 Reference Types
        
        +----------------+ +------------------+         +--------------------------------------+      +--------------------------------+                    
        | int age1 = 37; | | int age2 = age1; |         | Customer customer1 = new Customer(); |      | Customer customer2 = customer; |
        +----------------+ +------------------+         +--------------------------------------+      +--------------------------------+
                |                   |                             |                                       |
                |                   |                             |  +------------------------------------+
                |                   |                             |  |
                V                   V                             V  V
        +----------------+  +----------------+                +---------+         +---------+         +---------+         +---------+
STACK   | memory address |  | memory address |                | pointer |         | pointer |         | pointer |         | pointer |
        +----------------+  +----------------+                +---------+         +---------+         +---------+         +---------+
               37                  37                              |                   |                   |                   |
                                                                   |                   |                   |                   |
                                                                   V                   V                   V                   V
                                                           +----------------+  +----------------+  +----------------+  +----------------+
HEAP                                                       | memory address |  | memory address |  | memory address |  | memory address |
                                                           +----------------+  +----------------+  +----------------+  +----------------+
                                                             Name = "Tommy"       Name = "Anki"
*/
using c = _02_Structs.Classes;
using s = _02_Structs.Structs;

/* VALUE TYPES */
int age1 = 37;
int age2 = age1;    // <- kopierar
age1 = 33;

Console.WriteLine($"VALUE TYPES\nAge1 is: {age1}\nAge2 is: {age2}\n");
Console.ReadKey();


/* REFERENCE TYPES */
c.Customer classCustomer1 = new c.Customer() { Name = "Hans", Email = "hans@domain.com" };
c.Customer classCustomer2 = classCustomer1;         // <-- Refererar
classCustomer1.Name = "Tommy";

Console.WriteLine($"REFERENCE TYPES\ncustomer1 is: {classCustomer1.Name}\ncustomer2 is: {classCustomer2.Name}\n");
Console.ReadKey();





/* USING STRUCT INSTEAD OF CLASS */
s.Customer structCustomer1 = new s.Customer() { Name = "Hans", Email = "hans@domain.com" };
s.Customer structCustomer2 = structCustomer1;         
structCustomer1.Name = "Tommy";

Console.WriteLine($"STRUCT\ncustomer1 is: {structCustomer1.Name}\ncustomer2 is: {structCustomer2.Name}\n");
Console.ReadKey();
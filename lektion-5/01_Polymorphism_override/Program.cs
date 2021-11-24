/*
    OVERRIDE/OVERLOAD (Polymorphism - OOP)
    ----------------------------------------------------------------------------------------------------------------------------- 
    OOP (1. Encapsulation, 2. Inheritance, 3. Polymorphism, 4. Abstraction)
 
    Override innebär att vi kan kan skriva över olika metoder i en klass och sedan använda oss av base.
    för att få tillgång till det ursprungliga. Ett arv krävs för att detta ska fungera.

    Overload innebär att vi kan göra flera olika konstruktors som tar olika parametrar.
    Vi kan även göra olika metoder som tar olika antal parametrar (som även kan använda override)

    Nyckelord
    -------------------------------------------------------------------------------
    virtual         vi gör metoden överskrivbar, men den behöver inte skrivas över.
    override        vi skriver över en virtual metod.
    base.           base. gör det möjligt för att att få tillgång till det som är ordinarie i en metod.
 
*/


using _01_Polymorphism_override.Models;

Animal dog = new Dog();
dog.MakeSound();

Shape circle = new Circle();
circle.Draw();

Shape rectangle = new Rectangle();
rectangle.Draw();

Customer customer1 = new Customer();
User customer2 = new Customer("Hans", "Mattin-Lassei");
User customer3 = new Customer(3, "Hans", "Mattin-Lassei");
User customer4 = new Customer() { Id = 4, FirstName = "Hans", LastName = "Mattin-Lassei" };

customer1.GeneratePassword();
customer1.GeneratePassword("BytMig123!");
Console.WriteLine();

customer2.GeneratePassword();
customer2.GeneratePassword("BytMig123!");

Console.ReadKey();
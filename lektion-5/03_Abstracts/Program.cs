/*
    ABSTRACT CLASS (Abstraction - OOP)
    ---------------------------------------------------------------------------------------------------------
    Handlar om att dölja sådant som är onödigt för användaren och bara visa det som ska visas.

    genom att göra en klass abstract (public abstract class Animal {}) så går det inte längre att
    göra en instans utav den. dvs det går inte att: Animal animal = new Animal();
*/


using _03_Abstracts.Models;


SqlStorage sql = new SqlStorage();
    sql.Connect();
    sql.Create(new { firstName = "Hans", lastName = "Mattin-Lassei", email = "hans@domain.com" });
    sql.Get();

Console.WriteLine("");

NoSqlStorage nosql = new NoSqlStorage();
    nosql.Connect();
    nosql.Create(new { firstName = "Hans", lastName = "Mattin-Lassei", email = "hans@domain.com" });
    nosql.Get();

Console.ReadKey();
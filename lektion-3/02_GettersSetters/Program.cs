/* 
    Getter Setter (Encapsulation - OOP)
    ----------------------------------------------------------------------------------
    get;        Read/Hämta          var firstName = customer.FirstName;
    set;        Write/Sätt          customer.FirstName = "Hans";

*/

using _02_GettersSetters.Models;


var c1 = new CustomerExample1() { FirstName = "Hans", LastName = "Mattin-Lassei", Email = "hans@domain.com", BirthDate = "1984-02-06" };
var c2 = new CustomerExample2("Hans", "Mattin-Lassei", "hans@domain.com", "1984-02-06");
var c3 = new CustomerExample3() { FirstName = "Hans", LastName = "Mattin-Lassei", BirthDate = "1984-02-06" };
    c3.SetEmailAddress("hans@domain.com");


Console.WriteLine($"{c1.DisplayName}, {c1.Age} år\n{c1.Email}\n");
Console.WriteLine($"{c2.DisplayName}, {c2.Age} år\n{c2.Email}\n");
Console.WriteLine($"{c3.DisplayName}, {c3.Age} år\n{c3.Email}\n");
Console.ReadKey();



using _04_Constructor;

var user1 = new User();
    user1.FirstName = "Hans";
    user1.LastName = "Mattin-Lassei";

var user2 = new User() { FirstName = "Hans", LastName = "Mattin-Lassei" };

var user3 = new User("Hans", "Mattin-Lassei");

var user4 = new User("Hans", "Mattin-Lassei", "hans.mattin-lassei@domain.com");

Console.WriteLine(user1.FullName);
Console.WriteLine(user2.FullName);
Console.WriteLine(user3.FullName);
Console.WriteLine(user4.FullName);
Console.WriteLine();

var device1 = new Device(Guid.NewGuid(), "livingroom-sensor");
var device2 = new Device("hallway-sensor");

Console.WriteLine($"{device1.DeviceId} : {device1.Name}");
Console.WriteLine($"{device2.DeviceId} : {device2.Name}");
Console.WriteLine();

var userProfile1 = new UserProfile();
Console.WriteLine(userProfile1.Address);
Console.WriteLine();


var skills = new List<string>() { "C#", "Java", "Python" };
var person1 = new Person() 
{ 
    Id = 1, 
    Name = "Hans", 
    Skills = new List<string>() { "C++", "C" }
};

Console.WriteLine(person1.Name);
foreach(var skill in person1.Skills)
    Console.WriteLine(skill);



var person2 = new Person()
{
    Id = 1,
    Name = "Hans"
};

Console.WriteLine();
Console.WriteLine(person1.Name);
foreach (var skill in person2.Skills)
    Console.WriteLine(skill);

Console.WriteLine();

var customer = new Customer() { Name = "MG Group AB" };
Console.WriteLine($"{customer.Id} : {customer.Name}");
customer.Id = Guid.NewGuid();
Console.WriteLine($"{customer.Id} : {customer.Name}");
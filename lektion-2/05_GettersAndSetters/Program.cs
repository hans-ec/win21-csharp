// GET = Read     ex. var firstName = user.FirstName;
// SET = Write    ex. user.FirstName = "Hans";

using _05_GettersAndSetters;

var user = new CreateUserModel("Hans", "Mattin-Lassei");
Console.WriteLine($"{user.Id} : {user.FullName}");

var users = new List<User>();
users.Add(new User { Id = user.Id, FirstName = user.FirstName, LastName = user.LastName });

foreach (var item in users)
    Console.WriteLine($"{item.Id} {item.FullName}");

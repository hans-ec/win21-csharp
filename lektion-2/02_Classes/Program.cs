/* 
    JS: Json
    ----------------------------------------
    let user = {
        "firstName": "Hans",
        "lastName": "Mattin-Lassei
    }    

    JS: Object
    ----------------------------------------
    let user = {
        firstName: "Hans",
        lastName: "Mattin-Lassei
    }


    C#: Object
    ----------------------------------------
    var user1 = new 
    {
        FirstName = "Hans",
        LastName = "Mattin-Lassei"
    };
 
    var user2 = new 
    {
        GivenName = "Hans",
        SurName = "Mattin-Lassei"
    };

    C#: Class
    ----------------------------------------
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    var user1 = new User()
    {
        FirstName = "Hans",
        LastName = "Mattin-Lassei"
    };
 
     var user2 = new User()
    {
        FirstName = "Hans",
        LastName = "Mattin-Lassei"
    };   

*/


using _02_Classes;

var user = new User()
{
    FirstName = "Hans",
    LastName = "Mattin-Lassei",
    Email = "hans.mattin-lassei@domain.com",
    Password = "BytMig123!"
};


/* MAP (REDUCE) */
var userViewModel = new UserViewModel
{
    Id = user.Id,
    Name = $"{user.FirstName} {user.LastName}",
    Email = user.Email
};

Console.WriteLine(userViewModel.Name);
Console.WriteLine(userViewModel.Email);
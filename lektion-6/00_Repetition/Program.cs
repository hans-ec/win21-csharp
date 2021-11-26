/*
    INTERFACE EXAMPLE
    -----------------------------------------------------------------------------------------------
    using _00_Repetition.Services;
    using _00_Repetition.Models.Authentication;

    var userManager = new UserManager();
    userManager.SignUp(new SignUpRequest
    {
        FirstName = "Hans",
        LastName = "Mattin-Lassei",
        Email = "hans@domain.com",
        Password = "BytMig123!",
        AddressLine = "Nordkapsvägen 1",
        ZipCode = "136 57", 
        City = "Vega"
    });

    var response = userManager.SignIn("hans@domain.com", "BytMig123!");
    Console.WriteLine(response.AccessToken);
*/


using _00_Repetition.Models.Authentication;
using _00_Repetition.Services;

var userManager = new UserManager();
userManager.SignUp(new SignUpRequest
{
    FirstName = "Hans",
    LastName = "Mattin-Lassei",
    Email = "hans@domain.com",
    Password = "BytMig123!",
    AddressLine = "Nordkapsvägen 1",
    ZipCode = "136 57",
    City = "Vega"
});


var response = userManager.SignIn("hans@domain.com", "BytMig123!");
Console.WriteLine(response.AccessToken);

/*
    INTERFACE (Abstraction - OOP)
    -----------------------------------------------------------------------------------------------------------
    Abstraction handlar om att dölja onödig information till användaren och bara visa det som faktiskt behövs.

    Interface är ett kontakt. Med det menas att bara det som finns i kontraktet visas. Allt annat är dolt för 
    användaren, trots att det finns andra underliggande metoder som "körs".

    Ett interface börjar i regel alltid med ett I i början av namnet (ex. IUserService, IAccess, IEnumerable)
 
    Användare är den som ska använda koden, dvs programmeraren inte själva slutanvändaren. Slutanvändare är 
    en person som kör den slutgiltiga applikationen. Såsom en kund.
 
*/

using _02_Interfaces.Services;
using _02_Interfaces.Models;
using _02_Interfaces.Interfaces;

// Med ett interface ser vi bara det vi får se och ska se utifrån vad som står i kontraktet
IAuthentication iauth = new AdminService();
    iauth.SignUp(new SignUpModel { });
    iauth.SignIn("", "");
    iauth.SignOut(1);
    iauth.VerifyAccount();

// Här använder vi inte ett kontrakt utan kan komma åt alla saker i AdminService
AdminService auth = new AdminService();
    auth.SignUp(new SignUpModel { });
    auth.SignIn("", "");
    auth.SignOut(1);
    auth.VerifyAccount();



// Ett annat exempel på exakt samma sak är IEnumerable och List
IEnumerable<string> ienum = new List<string>();
    ienum.Add("");

List<string> list = new List<string>();  
    list.Add("");






/*
 
    Ett exempel på Dependency Injection som vi kommer användare i senare kurser sen
    ----------------------------------------------------------------------------------------
    class ProductsController 
    {
        private IAuthentication _auth;

        public ProductsController(IAuthentication auth) 
        {
            _auth = auth;
        }


        public IActionResult GetProducts() 
        {
            return new OkObjectResult(_auth.GetProducts());
        }
    }
 
 
*/
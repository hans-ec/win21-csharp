/* 
 
    MVC - Model View Controller
    -------------------------------------------------------------------------------------------------
    C#,                 =       Model
    Datalagring         =       Model, (Controller)
    Asp.Net MVC         =       Model, View, Controller
    Asp.Net Web API     =       Model, (View), Controller 

        Models
        ----------------------------------------------------------------   
        User.cs                     Databas, Objekt
        UserEntity.cs               Databas
        UserModel.cs                Modifierat Objekt
        UserViewModel.cs            Modifierat Objekt för en sida



    Objektorienterad Programmering (OOP)
    --------------------------------------------------------------------------------------------------
    Encapsulation               Dölja information, skydda information       Classes, Access Modifiers
    Inheritance                 Ärva properties/fields från parent          Classes : Classes
    Polymorphism
    Abstraction


        Encapsulation
        ---------------------------------------------------------------------------
        Innebär att man grupperar ihop egenskaper till ett objekt och skyddar dessa
        med hjälp av olika access modifiers (public, private, internal, protected)

        public class User 
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        public class Customer 
        {
            public string Organization { get; set; }
            public string PhoneNumber { get; set; }
            public string JobTitle { get; set; }
        }



        Inheritance (arv)
        ---------------------------------------------------------------------------
        Innebär att man ärver egenskaper från en annan klass som utökar den befintliga
        klassen. Det skrivs på lite olika sätt beroende på språk:
        
        JAVA        public class Customer extends User {}
        JS          class Customer extends User {}
        C++         class Customer : public User {}
        C#          public class Customer : User {}


        using _00_Repetition.Models;

        var customer = new Customer()
        {
            FirstName = "Hans",                     <- kommer från klassen User
            LastName = "Mattin-Lassei",             <- kommer från klassen User
            Email = "hans@domain.com",              <- kommer från klassen User
            Organization = "EC-Utbildning AB",      <- kommer från klassen Customer
            PhoneNumber = "073-123 45 67",          <- kommer från klassen Customer
            JobTitle = "Utbildare"                  <- kommer från klassen Customer
        };

*/


using _00_Repetition.Models;

var customer = new CustomerCreateModel()
{
    FirstName = "Hans",
    LastName = "Mattin-Lassei",
    Email = "hans@domain.com",
    Password = "BytMig123!",
    AddressLine = "Nordkapsvägen 1",
    ZipCode = "136 57",
    City = "Vega",
    Organization = "EC Utbildning",
    JobTitle = "Utbildare",
    PhoneNumber = "073-123 45 67"
};

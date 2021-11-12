/*
    ARV - Inheritance
    ---------------------------------------------
    C#      public class Customer : User
    JAVA    public class Customer extends User
    JS      class Customer extends User

*/
using _03_Inheritance;

var user = new User()
{
    FirstName = "Hans",
    LastName = "Mattin-Lassei",
    Email = "hans.mattin-lassei@domain.com",
    Password = "BytMig123!"
};

var customer = new Customer()
{
    FirstName = "Hans",
    LastName = "Mattin-Lassei",
    Email = "hans.mattin-lassei@domain.com",
    Organization = "MG Group AB",
    Password = "BytMig123!"
};

var employee = new Employee()
{
    FirstName = "Hans",
    LastName = "Mattin-Lassei",
    Email = "hans.mattin-lassei@domain.com",
    JobTitle = "CEO",
    Password = "BytMig123!"
};
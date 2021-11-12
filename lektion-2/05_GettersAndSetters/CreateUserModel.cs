using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GettersAndSetters
{
    // GET = Read     ex. var firstName = user.FirstName;
    // SET = Write    ex. user.FirstName = "Hans";

    internal class CreateUserModel
    {
        public CreateUserModel(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{FirstName} {LastName}";
        }

        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; }
    }
}

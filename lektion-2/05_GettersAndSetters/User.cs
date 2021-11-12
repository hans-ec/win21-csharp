using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GettersAndSetters
{
    // GET = Read     ex. var firstName = user.FirstName;
    // SET = Write    ex. user.FirstName = "Hans";

    public class User
    {
        public Guid Id { get; set; }
        public string ? FirstName { get; set; }
        public string ? LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}

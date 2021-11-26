using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Models.Authentication
{
    internal class SignUpRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AddressLine { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; } = "Sverige";
    }
}

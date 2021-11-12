using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Constructor
{
    public class UserProfile
    {
        public UserProfile()
        {
            PhoneNumber = "";
            MobleNumber = "";
            AddressLine = "okänt";
            PostalCode = "okänt";
            City = "okänt";

            Address = $"{AddressLine}, {PostalCode} {City} {Country}";
        }

        public string PhoneNumber { get; set; }
        public string MobleNumber { get; set; }
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; } = "Tyskland";

        public string Address { get; set; }

    }
}

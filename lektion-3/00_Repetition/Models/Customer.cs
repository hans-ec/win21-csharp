using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Models
{
    internal class Customer : User
    {
        public string Organization { get; set; }
        public string PhoneNumber { get; set; }
        public string JobTitle { get; set; }

    }
}

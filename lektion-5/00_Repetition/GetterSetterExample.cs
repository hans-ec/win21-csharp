using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition
{
    internal class GetterSetterExample
    {
        private string firstName;
        private string lastName;

        public string FirstName { 
            get { return firstName; }
            set { firstName = value.Trim(); } 
        }

        public string LastName 
        { 
            get { return lastName; } 
            set { lastName = value.Trim(); } 
        }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string FullName1 => $"{FirstName} {LastName}";

    }
}

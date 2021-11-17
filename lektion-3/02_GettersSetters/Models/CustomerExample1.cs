using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_GettersSetters.Models
{
    internal class CustomerExample1
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _birthDate;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value.Trim(); }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value.Trim(); }
        }

        public string DisplayName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public string Email
        {
            get { return _email; }
            set 
            {
                var jsRegEx = "^(([^<>()[\\]\\.,;:\\s@\"]+(\\.[^<> ()[\\]\\.,;:\\s@\"]+)*)|(\".+ \"))@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$";
                var csRegEx = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";

                if(new Regex(csRegEx).IsMatch(value))
                    _email = value.Trim(); 
            }
        }

        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value.Trim(); }
        }

        public int Age
        {
            get 
            {
                var birthDate = DateTime.Parse(BirthDate);
                var age = DateTime.Now.Year - birthDate.Year;

                if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                    age--;

                return age;
            }


            /* 
             
                Validera ålder med hjälp av Javascript
                ------------------------------------------------------------------------------
                FRONTEND (FORM):        <input type="date" id="birthDate" value="1984-02-06">

                BACKEND (LOGIK):        let today = new Date();
                                        let birthDate = new Date(e.target["birthDate"].value)
                                        let age = today.getFullYear() - birthDate.getFullYear()
                                        let month = today.getMonth() - birthDate.getMonth()
                                        
                                        if (month < 0 || (month === 0 && today.getDate() < birthDate.getDate())
                                            age--
             
            */
        }

    }
}

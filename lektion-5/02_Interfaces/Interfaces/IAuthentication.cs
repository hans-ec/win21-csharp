using _02_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces.Interfaces
{
    internal interface IAuthentication
    {
        bool SignUp(SignUpModel model);
        void SignIn(string email, string password);
        void SignOut(int id);
    }
}

using _02_Interfaces.Interfaces;
using _02_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces.Services
{
    internal class UserService : IAuthentication
    {
        public void SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void SignOut(int id)
        {
            throw new NotImplementedException();
        }

        public bool SignUp(SignUpModel model)
        {
            throw new NotImplementedException();
        }
    }
}

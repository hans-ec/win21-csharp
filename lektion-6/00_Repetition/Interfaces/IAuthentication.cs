using _00_Repetition.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Interfaces
{
    internal interface IAuthentication
    {
        void SignUp(SignUpRequest signUpRequest);
        SignInResponse SignIn(string email, string password);
        void SignOut(Guid id);
    }
}

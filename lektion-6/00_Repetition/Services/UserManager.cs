using _00_Repetition.Abstracts;
using _00_Repetition.Interfaces;
using _00_Repetition.Models.Authentication;
using _00_Repetition.Models.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Services
{


    /*  
    
    INTERFACE IMPLEMENTATION
    ---------------------------------------------------------------------------------------------
    internal class UserManager : IAuthentication, IUserManagement, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public User GetCurrentUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public SignInResponse SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void SignOut(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SignUp(SignUpRequest signUpRequest)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Guid id, UpdateUserRequest updateUserRequest)
        {
            throw new NotImplementedException();
        }
    }
    */


    internal class UserManager : Authentication
    {
        public override void SignUp(SignUpRequest signUpRequest)
        {
            Console.WriteLine("Saving user information to Sql Database. \n");
        }

        public override SignInResponse SignIn(string email, string password)
        {
            password = "KalleAnka";
            Console.WriteLine("I changed the password");

            return base.SignIn(email, password);
        }
    }

}

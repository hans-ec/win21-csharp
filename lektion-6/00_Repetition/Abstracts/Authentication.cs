using _00_Repetition.Interfaces;
using _00_Repetition.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Abstracts
{
    internal abstract class Authentication : IAuthentication, IDisposable
    {
        public abstract void SignUp(SignUpRequest signUpRequest);

        public virtual SignInResponse SignIn(string email, string password)
        {
            Console.WriteLine($"Checking if user with email address: {email} exists.");
            Console.WriteLine($"Checking if user password is same as provided password.");
            
            if (password == "BytMig123!")
            {
                return new SignInResponse
                {
                    UserId = Guid.Parse("fd4bb508-6a76-4d7c-aa71-32e8f152cd1e"),
                    AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c"
                };
            }

            return new SignInResponse { };
        }

        public void SignOut(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

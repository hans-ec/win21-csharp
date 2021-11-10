using _01_Namespaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Namespaces.Services
{
    internal class UserService
    {

        /// <summary>
        /// This will create a new user and save it to the database
        /// </summary>
        /// <param name="user">UserModel Object</param>
        /// <returns>Returns a user object</returns>
        public User CreateUser(User user)
        {
            return user;
        }
    }
}

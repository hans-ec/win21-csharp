using _01_Namespaces.Models;
using _01_Namespaces.Services;
using System;

namespace _01_Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var userService = new UserService();

            userService.CreateUser(user);
        }
    }
}

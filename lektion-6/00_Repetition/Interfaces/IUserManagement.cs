using _00_Repetition.Models.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Interfaces
{
    internal interface IUserManagement
    {
        User GetCurrentUser(Guid id);
        IEnumerable<User> GetUsers();
        void UpdateUser(Guid id, UpdateUserRequest updateUserRequest);
    }
}

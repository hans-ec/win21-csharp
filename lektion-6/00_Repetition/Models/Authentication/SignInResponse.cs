using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Models.Authentication
{
    internal class SignInResponse
    {
        public Guid UserId { get; set; }
        public string AccessToken { get; set; }
    }
}

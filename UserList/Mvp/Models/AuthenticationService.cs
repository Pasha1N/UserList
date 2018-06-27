using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Models
{
    internal class AuthenticationService
    {
        public bool Login(User user)
        {
            return Database.UserSearch(user);
        }

        public bool PasswordValidation(string password)
        {
            bool successfulVerification = true;

            if (password.Length < 1)
            {
                successfulVerification = false;
            }

            return successfulVerification;
        }

        public bool UsernameValidation(string username)
        {
            bool successfulVerification = true;

            if (username.Length < 5)
            {
                successfulVerification = false;
            }

            return successfulVerification;
        }
    }
}
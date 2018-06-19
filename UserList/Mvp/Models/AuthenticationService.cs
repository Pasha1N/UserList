using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Models
{
    class AuthenticationService //: IAuthenticationService
    {
        public bool Login(User user)
        {
            return Database.UserSearch(user);
        }

        public bool Validation(string username, string password)
        {
            bool successfulVerification = true;

            if (username.Length<5)
            {
                successfulVerification = false;
            }
            else if(password.Length<1)
            {
                successfulVerification = false;
            }

            return successfulVerification;
        }
    }
}
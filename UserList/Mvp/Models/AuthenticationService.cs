using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Models
{
    class AuthenticationService : IAuthenticationService
    {
        public bool Login(User user)
        {
            return Database.UserSearch(user);
        }
    }
}
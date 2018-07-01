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
    }
}
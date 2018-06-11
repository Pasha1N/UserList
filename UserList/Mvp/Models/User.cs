using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Models
{
    internal sealed class User
    {
        private readonly string password;
        private readonly string username;

        public User(string username, string password)
        {
            this.password = password;
            this.username = username;
        }

        public string Password => password;

        public string Username => username;
    }
}
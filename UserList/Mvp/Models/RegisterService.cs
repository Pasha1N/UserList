using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Models
{
    internal class RegisterService
    {
        //private readonly string username;
        //private readonly string password;
        //private readonly string repeatPassword;

        //public RegisterService(string username,string password,string repeatPassword)
        //{
        //    this.username = username;
        //    this.password = password;
        //    this.repeatPassword = repeatPassword;
        //    SavingData();
        //}

        public void SavingData(string username, string password, string repeatPassword)
        {
                User user = new User(username, password);
                Database.AddUser(user);
        }
    }
}
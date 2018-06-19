using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Models
{
    internal class RegisterService
    {
        private  string username;
        private  string password;
        private  string repeatPassword;

        public bool CheckIn(string username,string password,string confirmPassword)
        {
            bool successfulRegistration = false;
            this.username = username;
            this.password = password;
            this.repeatPassword = confirmPassword;

            if (password == confirmPassword)
            {
                SavingData(username, password, confirmPassword);
                successfulRegistration = true;
            }

            return successfulRegistration;
        }

        public bool Validation(string username, string password, string confirmPassword)
        {
            bool successfulVerification = true;

            if (username.Length < 5)
            {
                successfulVerification = false;
            }
            else if (password.Length < 1)
            {
                successfulVerification = false;
            }
            else if(confirmPassword.Length <1)
            {
                successfulVerification = false;
            }

            return successfulVerification;
        }

        public void SavingData(string username, string password, string repeatPassword)
        {
                User user = new User(username, password);
                Database.AddUser(user);
        }
    }
}
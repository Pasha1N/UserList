namespace UserList.Date.Mvp.Models
{
    internal class RegisterService
    {
        private string confirmedPassword;
        private string username;
        private string password;

        public bool CheckIn(string username, string password, string confirmedPassword)
        {
            bool successfulRegistration = false;
            this.username = username;
            this.password = password;
            this.confirmedPassword = confirmedPassword;

            if (!Database.UserSearch(username))
            {
                if (password == confirmedPassword)
                {
                    SavingData(username, password, confirmedPassword);
                    successfulRegistration = true;
                }
            }
            return successfulRegistration;
        }

        public void SavingData(string username, string password, string repeatPassword)
        {
            User user = new User(username, password);
            Database.AddUser(user);
        }
    }
}
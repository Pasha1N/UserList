namespace UserList.Mvp.Models
{
    internal sealed class User
    {
        private readonly string username;
        private readonly string password;

        public User(string username, string password)
        {
            this.password = password;
            this.username = username;
        }

        public string Password => password;

        public string Username => username;
    }
}
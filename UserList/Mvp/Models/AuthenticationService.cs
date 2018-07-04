namespace UserList.Date.Mvp.Models
{
    internal class AuthenticationService
    {
        public bool Login(User user)
        {
            return Database.UserSearch(user);
        }
    }
}
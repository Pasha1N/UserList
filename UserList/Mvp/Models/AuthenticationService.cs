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
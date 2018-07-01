using System;
using System.Drawing;

namespace UserList.Mvp.Views
{
    internal interface IViewAuthentication : IView
    {
        string Password { set; get; }

        Image PasswordSetPicture { set; }

        string Username { set; get; }

        Image UsernameSetPicture { set; }

        event EventHandler<EventArgs> Login;

        event EventHandler<EventArgs> Register;

        event EventHandler<EventArgs> Validation;

        void EnabledLogin(bool enabled);

        void ShowError(string message);
    }
}
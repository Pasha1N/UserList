using System;
using System.Drawing;

namespace UserList.Date.Mvp.Views
{
    internal interface IViewAuthentication : IView
    {
        string Password { set; get; }
        Image PasswordPicture { set; }
        string Username { set; get; }
        Image UsernamePicture { set; }

        event EventHandler<EventArgs> Login;
        event EventHandler<EventArgs> Register;
        event EventHandler<EventArgs> Validation;

        void EnabledLogin(bool enabled);
        void ShowError(string message);
    }
}
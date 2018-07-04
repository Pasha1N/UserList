using System;
using System.Drawing;

namespace UserList.Date.Mvp.Views
{
    internal interface IViewRegister : IView
    {
        string ConfirmedPassword { set; get; }

        Image ConfirmedPasswordSetPicture { set; }

        string Password { set; get; }

        Image PasswordSetPicture { set; }

        string Username { set; get; }

        Image UsernameSetPicture { set; }

        event EventHandler<EventArgs> Register;

        event EventHandler<EventArgs> Validation;

        event EventHandler<EventArgs> ClickButtonCancel;

        void EnabledRegister(bool enabled);

        void ShowError(string message);
    }
}
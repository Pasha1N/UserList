using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Views
{
    internal interface IViewRegister : IView
    {
        string Password { set; get; }

        Image PasswordSetPicture { set; }

        string Username { set; get; }

        Image UsernameSetPicture { set; }

        string ConfirmedPassword { set; get; }

        Image ConfirmedPasswordSetPicture { set; }

        event EventHandler<EventArgs> Register;

        event EventHandler<EventArgs> Validation;

        event EventHandler<EventArgs> ClickButtonCancel;

        void EnabledRegister(bool enabled);

        void ShowError(string message);
    }
}
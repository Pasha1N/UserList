using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Views
{
    internal interface IViewRegister : IView
    {
        string Password { get; }

        string Username { get; }

        string ConfirmPassword { get; }

        event EventHandler<EventArgs> Register;

        event EventHandler<EventArgs> Validation;

        event EventHandler<EventArgs> ClickButtonCancel;

        void EnabledRegister(bool enabled);

        void ShowError(string message);
    }
}
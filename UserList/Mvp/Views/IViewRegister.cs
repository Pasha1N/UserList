using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Views
{
    internal interface IViewRegister:IView
    {
        string Password { get; }

        string Username { get; }

        string ConfirmPassword { get; }

        event EventHandler<EventArgs> Register;

        void ShowError(string message);
    }
}
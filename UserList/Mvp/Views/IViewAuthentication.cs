using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Views
{
    interface IViewAuthentication:IView
    {
        string Password { get; }
        string Username { get; }

        event EventHandler<EventArgs> Login;

        event EventHandler<EventArgs> Register;

        void ShowError(string message);
    }
}

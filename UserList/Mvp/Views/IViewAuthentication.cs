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

        void ShowError(string message);
    }
}

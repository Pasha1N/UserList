using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Views
{
   internal interface IViewAuthentication:IView
    {
        string Password { get; }

        string Username { get; }

        event EventHandler<EventArgs> Login;

        event EventHandler<EventArgs> Register;

        event EventHandler<EventArgs> Validation;

        void EnabledLogin(bool enabled);
        
        void ShowError(string message);
    }
}

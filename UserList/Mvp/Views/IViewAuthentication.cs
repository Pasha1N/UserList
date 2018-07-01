using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList.Mvp.Views
{
   internal interface IViewAuthentication:IView
    {
        string Password { set; get; }

        string Username { set; get; }

        Image UsernameSetPicture { set; }

        Image PasswordSetPicture { set; }

        event EventHandler<EventArgs> Login;

        event EventHandler<EventArgs> Register;

        event EventHandler<EventArgs> Validation;

        void EnabledLogin(bool enabled);
        
        void ShowError(string message);
    }
}

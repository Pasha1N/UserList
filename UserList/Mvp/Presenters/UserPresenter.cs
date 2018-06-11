using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.Mvp.Views;

namespace UserList.Mvp.Presenters
{
    class UserPresenter : IPresenter
    {
        private readonly IViewUserList view;
        public UserPresenter(IViewUserList view)
        {
            this.view = view;
        }

        public void Run()
        {
            view.Show();
        }
    }
}
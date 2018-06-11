using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.Mvp.Views;

namespace UserList.Mvp.Presenters
{
    class RegisterPresenter:IPresenter
    {
        private readonly IViewRegister view;
        
        public RegisterPresenter(IViewRegister view)
        {
            this.view = view;
        }

        public void Run()
        {

        }

    }
}

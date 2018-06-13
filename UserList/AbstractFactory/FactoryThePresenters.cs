using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.Mvp.Presenters;
using UserList.Mvp.Views;

namespace UserList.AbstractFactory
{
    class FactoryThePresenters:IFactoryThePresenters
    {
        IViewRegister viewRegister;
        IViewUserList viewUserList;

       public FactoryThePresenters(IViewRegister viewRegister, IViewUserList viewUserList)
        {
            this.viewUserList = viewUserList;
            this.viewRegister = viewRegister;
        }

        public IPresenter CreateUserPresenter()
        {
            return new UserPresenter(viewUserList);
        }

        public IPresenter CreateRegisterPresenter()
        {
            return new RegisterPresenter(viewRegister);
        }
    }
}

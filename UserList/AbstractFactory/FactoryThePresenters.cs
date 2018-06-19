using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.Mvp.Models;
using UserList.Mvp.Presenters;
using UserList.Mvp.Views;

namespace UserList.AbstractFactory
{
    class FactoryThePresenters : IFactoryThePresenters
    {
        private IViewRegister viewRegister;
        private IViewUserList viewUserList;
        private RegisterService registerService;

        public FactoryThePresenters(IViewRegister viewRegister, IViewUserList viewUserList, RegisterService registerService)
        {
            this.viewUserList = viewUserList;
            this.viewRegister = viewRegister;
            this.registerService = registerService;
        }

        public IPresenter CreateUserPresenter()
        {
            return new UserPresenter(viewUserList);
        }

        public IPresenter CreateRegisterPresenter()
        {
            return new RegisterPresenter(viewRegister, this, registerService);
        }
    }
}
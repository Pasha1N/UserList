using UserList.Mvp.Models;
using UserList.Mvp.Presenters;
using UserList.Mvp.Views;

namespace UserList.AbstractFactory
{
    internal class FactoryThePresenters : IFactoryThePresenters
    {
        private RegisterService registerService;
        private IViewRegister viewRegister;
        private IViewUserList viewUserList;

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
            return new RegisterPresenter(viewRegister, registerService);
        }
    }
}
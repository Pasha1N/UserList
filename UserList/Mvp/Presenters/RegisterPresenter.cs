using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.AbstractFactory;
using UserList.Mvp.Models;
using UserList.Mvp.Views;

namespace UserList.Mvp.Presenters
{
    class RegisterPresenter : IPresenter
    {
        private readonly IViewRegister view;
        private readonly IFactoryThePresenters mainPresenter;
        private RegisterService registerService;

        public RegisterPresenter(IViewRegister view, IFactoryThePresenters mainPresenter, RegisterService registerService)
        {
            this.mainPresenter = mainPresenter;
            this.view = view;
            this.registerService = registerService;
            SubscribeToViewEvents();
        }

        public void CheckIn(object sendler,EventArgs e)
        {
           if(view.Password==view.ConfirmPassword)
            {
                registerService.CheckIn(view.Username,view.Password, view.ConfirmPassword);
            }
           else
            {
                view.ShowError("Passwords do not match");
            }
        }

        private void SubscribeToViewEvents()
        {
            view.Register += CheckIn;
        }

        public void Run()
        {
            view.Show();
        }

    }
}
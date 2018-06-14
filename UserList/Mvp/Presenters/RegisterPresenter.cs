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

        private readonly RegisterService registerService;
        private readonly IFactoryThePresenters mainPresenter;


        public RegisterPresenter(IViewRegister view, IFactoryThePresenters mainPresenter, RegisterService registerService)
        {
            this.registerService = registerService;
            this.mainPresenter = mainPresenter;
            this.view = view;
            SubscribeToViewEvents();
        }

        public void CheckIn(object sendler,EventArgs e)
        {

            if(view.Password==view.ConfirmPassword)
            {
                registerService.SavingData(view.Username, view.Password, view.ConfirmPassword);
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
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
        private IViewUserList viewUserList;

        public RegisterPresenter(IViewRegister view, IFactoryThePresenters mainPresenter, RegisterService registerService, IViewUserList viewUserList)
        {
            this.mainPresenter = mainPresenter;
            this.view = view;
            this.registerService = registerService;
            this.viewUserList = viewUserList;
            SubscribeToViewEvents();
        }

        public void CheckIn(object sendler, EventArgs e)
        {
            if (view.Password == view.ConfirmPassword)
            {
                if (registerService.CheckIn(view.Username, view.Password, view.ConfirmPassword))
                {
                    viewUserList.Show();
                }
            }
            else
            {
                view.ShowError("Confirmed password does not match");
            }
        }

        public void ClickButton_Cancel(object sendler, EventArgs e)
        {
            view.Close();
        }

        private void SubscribeToViewEvents()
        {
            view.Register += CheckIn;
            view.Validation += verification;
            view.ClickButtonCancel += ClickButton_Cancel;
        }

        public void verification(object sendler, EventArgs e)
        {
            if (registerService.Validation(view.Username, view.Password, view.ConfirmPassword))
            {
                view.EnabledRegister(true);
            }
            else
            {
                view.EnabledRegister(false);
            }
        }

        public void Run()
        {
            view.Show();
        }

    }
}
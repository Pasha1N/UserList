using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.AbstractFactory;
using UserList.Mvp.Models;
using UserList.Mvp.Views;
using UserList.Properties;

namespace UserList.Mvp.Presenters
{
    class RegisterPresenter : IPresenter
    {
        private readonly IViewRegister view;
        private readonly IFactoryThePresenters mainPresenter;
        private RegisterService registerService;
        private IViewUserList viewUserList;
        private CheckingInputData checkingInput = new CheckingInputData();

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
            if (view.Password == view.ConfirmedPassword)
            {
                if (registerService.CheckIn(view.Username, view.Password, view.ConfirmedPassword))
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
            view.ConfirmedPassword = string.Empty;
            view.Password = string.Empty;
            view.Username = string.Empty;
        }

        private void SubscribeToViewEvents()
        {
            view.Register += CheckIn;
            view.Validation += verification;
            view.ClickButtonCancel += ClickButton_Cancel;
        }

        public void verification(object sendler, EventArgs e)
        {
            view.PasswordSetPicture = checkingInput.PasswordValidation(view.Password)
                ? Resources.Correct : Resources.Incorrect;

            view.UsernameSetPicture = checkingInput.UsernameValidation(view.Username)
                ? Resources.Correct : Resources.Incorrect;

           view.ConfirmedPasswordSetPicture = checkingInput.CheckPasswordConfirmation(view.Password,view.ConfirmedPassword)
                ? Resources.Correct : Resources.Incorrect;

            if (checkingInput.PasswordValidation(view.Password) &&
                checkingInput.UsernameValidation(view.Username) &&
                checkingInput.CheckPasswordConfirmation(view.Password, view.ConfirmedPassword))
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
using System;
using UserList.Date.AbstractFactory;
using UserList.Date.Mvp.Models;
using UserList.Date.Mvp.Views;
using UserList.Date.Properties;

namespace UserList.Date.Mvp.Presenters
{
    internal class AuthenticationPresenter : IPresenter
    {
        private readonly AuthenticationService authenticationService;
        private readonly IFactoryThePresenters mainPresenter;
        private readonly IViewAuthentication view;

        public AuthenticationPresenter(IViewAuthentication view, IFactoryThePresenters mainPresenter, AuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
            this.mainPresenter = mainPresenter;
            this.view = view;
            SubscribeToViewEvents();
        }

        public void Authentication(object sender, EventArgs e)
        {
            User user = new User(view.Username, view.Password);

            if (authenticationService.Login(user))
            {
                mainPresenter.CreateUserPresenter().Run();
                view.Close();
            }
            else
            {
                view.ShowError("Wrong login or password");
            }
        }

        public void Run()
        {
            view.Show();
        }

        public void ShowRegistrationWindow(object sendler, EventArgs e)
        {
            view.Password = string.Empty;
            view.Username = string.Empty;
            mainPresenter.CreateRegisterPresenter().Run();
        }

        private void SubscribeToViewEvents()
        {
            view.Login += Authentication;
            view.Register += ShowRegistrationWindow;
            view.Validation += verification;
        }

        public void verification(object sendler, EventArgs e)
        {
            CheckingInputData checkingInput = new CheckingInputData();

            view.PasswordSetPicture = checkingInput.PasswordValidation(view.Password) ? Resources.Correct : Resources.Incorrect;
            view.UsernameSetPicture = checkingInput.UsernameValidation(view.Username) ? Resources.Correct : Resources.Incorrect;

            if (checkingInput.PasswordValidation(view.Password) && checkingInput.UsernameValidation(view.Username))
            {
                view.EnabledLogin(true);
            }
            else
            {
                view.EnabledLogin(false);
            }
        }
    }
}
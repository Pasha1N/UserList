using System;
using UserList.AbstractFactory;
using UserList.Mvp.Models;
using UserList.Mvp.Views;
using UserList.Date.Properties;

namespace UserList.Mvp.Presenters
{
    internal class AuthenticationPresenter : IPresenter
    {
        private readonly AuthenticationService authenticationService;
        private CheckingInputData checkingInput = new CheckingInputData();
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
            view.Validation += Verification;
        }

        public void Verification(object sendler, EventArgs e)
        {
            if (checkingInput.UsernameValidation(view.Username))
            {
                view.UsernamePicture = Resources.Correct;
                PictureKeys.AuthenticationUsernamePicture = "Correct";
            }
            else
            {
                view.UsernamePicture = Resources.Incorrect;
                PictureKeys.AuthenticationUsernamePicture = "Incorrect";
            }

            if (checkingInput.PasswordValidation(view.Password))
            {
                view.PasswordPicture = Resources.Correct;
                PictureKeys.AuthenticationPasswordPicture = "Correct";
            }
            else
            {
                view.PasswordPicture = Resources.Incorrect;
                PictureKeys.AuthenticationPasswordPicture = "Incorrect";
            }

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
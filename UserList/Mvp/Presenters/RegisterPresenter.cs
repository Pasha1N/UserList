using System;
using System.Windows.Forms;
using UserList.Mvp.Models;
using UserList.Mvp.Views;
using UserList.Data.Properties;
using UserList.Data;

namespace UserList.Mvp.Presenters
{
    internal class RegisterPresenter : IPresenter
    {
        private CheckingInputData checkingInput = new CheckingInputData();
        private RegisterService registerService;
        private IViewRegister view;

        public RegisterPresenter(IViewRegister view, RegisterService registerService)
        {
            this.view = view;
            this.registerService = registerService;
            SubscribeToViewEvents();
        }

        public void CheckIn(object sendler, EventArgs e)
        {
            if (view.Password == view.ConfirmedPassword)
            {
                if (registerService.CheckIn(view.Username, view.Password, view.ConfirmedPassword))
                {
                    view.Close();
                    MessageBox.Show($"User {view.Username} successfully registered.");
                    view.Username = string.Empty;
                    view.Password = string.Empty;
                    view.ConfirmedPassword = string.Empty;
                }
                else
                {
                    view.ShowError("A user with this name already exists");
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

        public void Run()
        {
            view.Show();
        }

        private void SubscribeToViewEvents()
        {
            view.Register += CheckIn;
            view.Validation += Verification;
            view.ClickButtonCancel += ClickButton_Cancel;
        }

        public void Verification(object sendler, EventArgs e)
        {
            view.PasswordSetPicture = checkingInput.PasswordValidation(view.Password)
                ? Resources.Correct : Resources.Incorrect;

            PictureKeys.RegistrationPasswordPicture =
                checkingInput.PasswordValidation(view.Password) == true ? "Correct" : "Incorrect";

            PictureKeys.RegistrationUsernamePicture = Database.UserSearch(view.Username)
               == true ? "Incorrect" : "Correct";

            view.UsernameSetPicture = checkingInput.UsernameValidation(view.Username) && !Database.UserSearch(view.Username)
               ? Resources.Correct : Resources.Incorrect;

            view.ConfirmedPasswordSetPicture = checkingInput.CheckPasswordConfirmation(view.Password, view.ConfirmedPassword)
                 ? Resources.Correct : Resources.Incorrect;

            PictureKeys.PictureConfirmedPassword =
                checkingInput.CheckPasswordConfirmation(view.Password, view.ConfirmedPassword) == true ? "Correct" : "Incorrect";

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
    }
}
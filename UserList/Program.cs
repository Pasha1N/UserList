using System;
using System.Windows.Forms;
using UserList.Date.AbstractFactory;
using UserList.Mvp.Models;
using UserList.Mvp.Presenters;
using UserList.Date.Properties;

namespace UserList.Date
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database.Initialisation();
            ApplicationContext applicationContext = new ApplicationContext();
            Authentication authentication = new Authentication(applicationContext);
            AuthenticationService authenticationService = new AuthenticationService();
            Registration registration = new Registration();
            RegisterService registerService = new RegisterService();
            UserList userList = new UserList(applicationContext, registration, authentication);
            UserPresenter userPresenter = new UserPresenter(userList);
            FactoryThePresenters factoryThePresenters = new FactoryThePresenters(registration, userList, registerService);
            AuthenticationPresenter authenticationPresenter = new AuthenticationPresenter(authentication, factoryThePresenters, authenticationService);

            authentication.PasswordPicture = Resources.Incorrect;
            authentication.UsernamePicture = Resources.Incorrect;
            registration.PasswordSetPicture = Resources.Incorrect;
            registration.UsernameSetPicture = Resources.Incorrect;
            registration.ConfirmedPasswordSetPicture = Resources.Incorrect;

            authenticationPresenter.Run();
        }
    }
}
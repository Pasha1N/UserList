using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserList.AbstractFactory;
using UserList.Mvp.Models;
using UserList.Mvp.Presenters;
using UserList.Mvp.Views;

namespace UserList
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationContext applicationContext = new ApplicationContext();
            Authentication authentication = new Authentication(applicationContext);
            AuthenticationService authenticationService = new AuthenticationService();
            Registration registration = new Registration();
            RegisterService registerService = new RegisterService();
            UserList userList = new UserList(applicationContext, registration, authentication);
            UserPresenter userPresenter = new UserPresenter(userList);
            FactoryThePresenters factoryThePresenters = new FactoryThePresenters(registration, userList,registerService);
            AuthenticationPresenter authenticationPresenter = new AuthenticationPresenter(authentication, factoryThePresenters, authenticationService);
            authenticationPresenter.Run();
        }
    }
}

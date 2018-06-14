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
            UserList userList = new UserList(applicationContext);
            UserPresenter userPresenter=new UserPresenter(userList);
            AuthenticationService authenticationService = new AuthenticationService();
            Registration registration = new Registration();

            FactoryThePresenters factoryThePresenters = new FactoryThePresenters(registration, userList);

            AuthenticationPresenter authenticationPresenter = new AuthenticationPresenter(authentication, factoryThePresenters, authenticationService);
            authenticationPresenter.Run();
        }
    }
}

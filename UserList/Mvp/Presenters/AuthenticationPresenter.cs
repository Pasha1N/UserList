﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.AbstractFactory;
using UserList.Mvp.Models;
using UserList.Mvp.Views;

namespace UserList.Mvp.Presenters
{
    class AuthenticationPresenter:IPresenter
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

        public void Register(object sendler,EventArgs e)
        {
            mainPresenter.

        }

        private void SubscribeToViewEvents()
        {
            view.Login += Authentication;
        }


        public void Run()
        {
            view.Show();
        }
    }
}
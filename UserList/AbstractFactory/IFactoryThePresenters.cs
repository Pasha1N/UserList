using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserList.Mvp.Presenters;

namespace UserList.AbstractFactory
{
    internal interface IFactoryThePresenters
    {
        IPresenter CreateUserPresenter();

        IPresenter CreateRegisterPresenter();
    }
}
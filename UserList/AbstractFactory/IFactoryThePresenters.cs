using UserList.Mvp.Presenters;

namespace UserList.Date.AbstractFactory
{
    internal interface IFactoryThePresenters
    {
        IPresenter CreateUserPresenter();
        IPresenter CreateRegisterPresenter();
    }
}
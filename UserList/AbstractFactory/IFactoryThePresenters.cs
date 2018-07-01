using UserList.Mvp.Presenters;

namespace UserList.AbstractFactory
{
    internal interface IFactoryThePresenters
    {
        IPresenter CreateUserPresenter();

        IPresenter CreateRegisterPresenter();
    }
}
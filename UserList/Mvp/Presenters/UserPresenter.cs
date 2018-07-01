using UserList.Mvp.Views;

namespace UserList.Mvp.Presenters
{
    internal class UserPresenter : IPresenter
    {
        private readonly IViewUserList view;

        public UserPresenter(IViewUserList view)
        {
            this.view = view;
        }

        public void Run()
        {
            view.Show();
        }
    }
}
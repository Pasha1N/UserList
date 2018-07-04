using UserList.Date.Mvp.Views;

namespace UserList.Date.Mvp.Presenters
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
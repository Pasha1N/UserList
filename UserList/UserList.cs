using System;
using System.Windows.Forms;
using UserList.Mvp.Models;
using UserList.Mvp.Views;

namespace UserList.Date
{
    internal partial class UserList : Form, IViewUserList
    {
        private IViewAuthentication authentication;
        private readonly ApplicationContext context;
        private IViewRegister registration;

        public UserList(ApplicationContext context, IViewRegister registration, Authentication authentication)
        {
            InitializeComponent();
            this.context = context;
            this.registration = registration;
            this.authentication = authentication;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Database.DeleteUser(listUsers.SelectedItem.ToString());
            listUsers.Items.Remove(listUsers.SelectedItem);
            deleteButton.Enabled = false;
        }

        private void ListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
        }

        public void Initialization()
        {
            foreach (User user in Database.Users)
            {
                listUsers.Items.Add(user.Username);
            }
        }

        public new void Show()
        {
            Initialization();

            context.MainForm = this;
            registration.Close();
            authentication.Close();
            base.Show();
        }
    }
}
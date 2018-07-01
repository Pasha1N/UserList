using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserList.Mvp.Models;
using UserList.Mvp.Views;

namespace UserList
{
    internal partial class UserList : Form, IViewUserList
    {
        private readonly ApplicationContext context;
        private IViewRegister registration;
        private IViewAuthentication authentication;

        public UserList(ApplicationContext context, IViewRegister registration, Authentication authentication)
        {
            InitializeComponent();
            this.context = context;
            this.registration = registration;
            this.authentication = authentication;
        }

        public new void Show()
        {
            Initialization();

            context.MainForm = this;
            registration.Close();
            authentication.Close();
            base.Show();
        }

        public void Initialization()
        {
            foreach (User user in Database.ListUsers)
            {
                listUsers.Items.Add(user.Username);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Database.DeleteUser(listUsers.SelectedItem.ToString());
            listUsers.Items.Remove(listUsers.SelectedItem);
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
        }
    }
}
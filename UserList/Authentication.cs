using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserList.Mvp.Views;

namespace UserList
{
    public partial class Authentication : Form, IViewAuthentication
    {
        private readonly ApplicationContext context;

        public Authentication(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        public string Password => passwordTextBox.Text;

        public string Username => usernameTextBox.Text;

        public event EventHandler<EventArgs> Login;

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login?.Invoke(this, EventArgs.Empty);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        public void ShowError(string messege)
        {
            MessageBox.Show(messege, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public new void Show()
        {
            context.MainForm = this;
            Application.Run(context);
        }
    }
}
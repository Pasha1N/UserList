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
    public partial class Registration : Form,IViewRegister
    {
        public Registration()
        {
            InitializeComponent();
        }

        public string Password => passwordtextBox.Text;

        public string ConfirmPassword => confirmPasswordtextBox.Text;

        public string Username => usernameTextBox.Text;

        public event EventHandler<EventArgs> Register;

        public new void Show()
        {
            ShowDialog();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register?.Invoke(this, EventArgs.Empty);
        }

        public void ShowError(string message)
        {

        }
    }
}
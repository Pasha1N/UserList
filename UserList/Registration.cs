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
    internal partial class Registration : Form, IViewRegister
    {
        public Registration()
        {
            InitializeComponent();
        }

        public string Password
        {
            get => passwordtextBox.Text;
            set { passwordtextBox.Text = value; }
        }

        public Image PasswordSetPicture
        {
            set { passwordPicture.Image = value; }
        }

        public string ConfirmedPassword
        {
            get => confirmPasswordtextBox.Text;
            set { confirmPasswordtextBox.Text = value; }
        }

        public Image ConfirmedPasswordSetPicture
        {
            set { confirmPasswordPicture.Image = value; }
        }

        public string Username
        {
            get => usernameTextBox.Text;
            set { usernameTextBox.Text = value; }
        }

        public Image UsernameSetPicture
        {
            set { usernamePicture.Image = value; }
        }

        public event EventHandler<EventArgs> Register;

        public event EventHandler<EventArgs> Validation;

        public event EventHandler<EventArgs> ClickButtonCancel;

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            Validation?.Invoke(this, EventArgs.Empty);
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {
            Validation?.Invoke(this, EventArgs.Empty);
        }

        private void confirmPasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            Validation?.Invoke(this, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClickButtonCancel?.Invoke(this, EventArgs.Empty);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register?.Invoke(this, EventArgs.Empty);
        }

        public void EnabledRegister(bool enabled)
        {
            if (enabled)
            {
                registerButton.Enabled = true;
            }
            else
            {
                registerButton.Enabled = false;
            }
        }

        public new void Show()
        {
            registerButton.Enabled = false;
            ShowDialog();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
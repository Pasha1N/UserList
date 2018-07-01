using System;
using System.Drawing;
using System.Windows.Forms;
using UserList.Mvp.Views;

namespace UserList
{
    internal partial class Authentication : Form, IViewAuthentication
    {
        private readonly ApplicationContext context;

        public Authentication(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        public string Password
        {
            get => passwordTextBox.Text;
            set { passwordTextBox.Text = value; }
        }

        public Image PasswordSetPicture
        {
            set { passwordPicture.Image = value; }
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

        public event EventHandler<EventArgs> Login;

        public event EventHandler<EventArgs> Register;

        public event EventHandler<EventArgs> Validation;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login?.Invoke(this, EventArgs.Empty);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Validation?.Invoke(this, EventArgs.Empty);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register?.Invoke(this, EventArgs.Empty);
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            Validation?.Invoke(this, EventArgs.Empty);
        }

        public void EnabledLogin(bool enabled)
        {
            if (enabled)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        public new void Show()
        {
            context.MainForm = this;
            Application.Run(context);
        }

        public void ShowError(string messege)
        {
            MessageBox.Show(messege, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
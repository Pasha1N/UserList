using System;
using System.Drawing;
using System.Windows.Forms;
using UserList.Mvp.Views;

namespace UserList.Date
{
    internal partial class Registration : Form, IViewRegister
    {
        public Registration()
        {
            InitializeComponent();
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

        public string Password
        {
            get => passwordtextBox.Text;
            set { passwordtextBox.Text = value; }
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

        public event EventHandler<EventArgs> ClickButtonCancel;
        public event EventHandler<EventArgs> Register;
        public event EventHandler<EventArgs> Validation;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClickButtonCancel?.Invoke(this, EventArgs.Empty);
        }

        private void ConfirmPasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            Validation?.Invoke(this, EventArgs.Empty);
        }

        private void ConfirmPasswordPicture_MouseEnter(object sender, EventArgs e)
        {
            toolTips.Active = PictureKeys.PictureConfirmedPassword == "Incorrect";
            toolTips.SetToolTip(confirmPasswordPicture, "Confirmation password cannot be empty.");
        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            Validation?.Invoke(this, EventArgs.Empty);
        }

        private void PasswordPicture_MouseEnter(object sender, EventArgs e)
        {
            toolTips.Active = PictureKeys.RegistrationPasswordPicture == "Incorrect";
            toolTips.SetToolTip(passwordPicture, "Password cannot be empty.");
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register?.Invoke(this, EventArgs.Empty);
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            Validation?.Invoke(this, EventArgs.Empty);
        }

        private void UsernamePicture_MouseEnter(object sender, EventArgs e)
        {
            toolTips.Active = PictureKeys.RegistrationUsernamePicture == "Incorrect";
            toolTips.SetToolTip(usernamePicture, "Username already exist.");
        }

        public void EnabledRegister(bool enabled)
        {
            registerButton.Enabled = enabled;
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
namespace UserList
{
    partial class Authentication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLable = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordPicture = new System.Windows.Forms.PictureBox();
            this.UsenamePicture = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsenamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLable
            // 
            this.usernameLable.AutoSize = true;
            this.usernameLable.Location = new System.Drawing.Point(9, 13);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(55, 13);
            this.usernameLable.TabIndex = 0;
            this.usernameLable.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(11, 39);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(70, 10);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(169, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(70, 36);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(169, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // PasswordPicture
            // 
            this.PasswordPicture.Image = global::UserList.Properties.Resources.Incorrect;
            this.PasswordPicture.Location = new System.Drawing.Point(245, 36);
            this.PasswordPicture.Name = "PasswordPicture";
            this.PasswordPicture.Size = new System.Drawing.Size(19, 20);
            this.PasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordPicture.TabIndex = 6;
            this.PasswordPicture.TabStop = false;
            // 
            // UsenamePicture
            // 
            this.UsenamePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UsenamePicture.ErrorImage = global::UserList.Properties.Resources.Incorrect;
            this.UsenamePicture.Image = global::UserList.Properties.Resources.Incorrect;
            this.UsenamePicture.InitialImage = global::UserList.Properties.Resources.Correct;
            this.UsenamePicture.Location = new System.Drawing.Point(245, 10);
            this.UsenamePicture.Name = "UsenamePicture";
            this.UsenamePicture.Size = new System.Drawing.Size(19, 20);
            this.UsenamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsenamePicture.TabIndex = 5;
            this.UsenamePicture.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Location = new System.Drawing.Point(156, 65);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(80, 20);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Location = new System.Drawing.Point(70, 65);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(80, 20);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 99);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.PasswordPicture);
            this.Controls.Add(this.UsenamePicture);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLable);
            this.Name = "Authentication";
            this.Text = "Authentication";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsenamePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox UsenamePicture;
        private System.Windows.Forms.PictureBox PasswordPicture;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
    }
}
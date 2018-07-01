namespace UserList
{
   internal partial class Registration
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
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.usernamePicture = new System.Windows.Forms.PictureBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPasswordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Location = new System.Drawing.Point(110, 95);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(80, 20);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Location = new System.Drawing.Point(196, 95);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 20);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // passwordPicture
            // 
            this.passwordPicture.Image = global::UserList.Properties.Resources.Incorrect;
            this.passwordPicture.Location = new System.Drawing.Point(282, 43);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.Size = new System.Drawing.Size(19, 20);
            this.passwordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPicture.TabIndex = 14;
            this.passwordPicture.TabStop = false;
            // 
            // usernamePicture
            // 
            this.usernamePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernamePicture.ErrorImage = global::UserList.Properties.Resources.Incorrect;
            this.usernamePicture.Image = global::UserList.Properties.Resources.Incorrect;
            this.usernamePicture.InitialImage = global::UserList.Properties.Resources.Correct;
            this.usernamePicture.Location = new System.Drawing.Point(282, 17);
            this.usernamePicture.Name = "usernamePicture";
            this.usernamePicture.Size = new System.Drawing.Size(19, 20);
            this.usernamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamePicture.TabIndex = 13;
            this.usernamePicture.TabStop = false;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(107, 43);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(169, 20);
            this.passwordtextBox.TabIndex = 12;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(107, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(169, 20);
            this.usernameTextBox.TabIndex = 11;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // confirmPasswordtextBox
            // 
            this.confirmPasswordtextBox.Location = new System.Drawing.Point(107, 69);
            this.confirmPasswordtextBox.Name = "confirmPasswordtextBox";
            this.confirmPasswordtextBox.Size = new System.Drawing.Size(169, 20);
            this.confirmPasswordtextBox.TabIndex = 18;
            this.confirmPasswordtextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordtextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirm password";
            // 
            // confirmPasswordPicture
            // 
            this.confirmPasswordPicture.Image = global::UserList.Properties.Resources.Incorrect;
            this.confirmPasswordPicture.Location = new System.Drawing.Point(282, 69);
            this.confirmPasswordPicture.Name = "confirmPasswordPicture";
            this.confirmPasswordPicture.Size = new System.Drawing.Size(19, 20);
            this.confirmPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.confirmPasswordPicture.TabIndex = 19;
            this.confirmPasswordPicture.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 209);
            this.Controls.Add(this.confirmPasswordPicture);
            this.Controls.Add(this.confirmPasswordtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.passwordPicture);
            this.Controls.Add(this.usernamePicture);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox passwordPicture;
        private System.Windows.Forms.PictureBox usernamePicture;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPasswordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox confirmPasswordPicture;
    }
}
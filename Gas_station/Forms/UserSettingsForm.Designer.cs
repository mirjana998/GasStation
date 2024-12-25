namespace Gas_station.Forms
{
    partial class UserSettingsForm
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
            lblAccountSettings = new Label();
            cbTheme = new ComboBox();
            tbNewPassword = new TextBox();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            tbConfirmPassword = new TextBox();
            btnUpdatePassword = new Button();
            lblTheme = new Label();
            btnUpdateTheme = new Button();
            lblLanguage = new Label();
            cbLanguage = new ComboBox();
            btnUpdateLanguage = new Button();
            lblUser = new Label();
            btnSeeNewPassword = new Button();
            btnSeeConfirmPassword = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblAccountSettings
            // 
            lblAccountSettings.AutoSize = true;
            lblAccountSettings.Location = new Point(12, 9);
            lblAccountSettings.Name = "lblAccountSettings";
            lblAccountSettings.Size = new Size(120, 20);
            lblAccountSettings.TabIndex = 0;
            lblAccountSettings.Text = "Account Settings";
            // 
            // cbTheme
            // 
            cbTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTheme.FormattingEnabled = true;
            cbTheme.Items.AddRange(new object[] { "light", "dark", "blue" });
            cbTheme.Location = new Point(332, 109);
            cbTheme.Name = "cbTheme";
            cbTheme.Size = new Size(195, 28);
            cbTheme.TabIndex = 6;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(12, 110);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(195, 27);
            tbNewPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 74);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "New Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(12, 162);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(130, 20);
            lblConfirmPassword.TabIndex = 12;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(12, 200);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(195, 27);
            tbConfirmPassword.TabIndex = 3;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.Image = Properties.Resources.update;
            btnUpdatePassword.Location = new Point(66, 262);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(94, 40);
            btnUpdatePassword.TabIndex = 5;
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Location = new Point(332, 74);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(111, 20);
            lblTheme.TabIndex = 15;
            lblTheme.Text = "Change Theme:";
            // 
            // btnUpdateTheme
            // 
            btnUpdateTheme.Image = Properties.Resources.update;
            btnUpdateTheme.Location = new Point(564, 104);
            btnUpdateTheme.Name = "btnUpdateTheme";
            btnUpdateTheme.Size = new Size(93, 40);
            btnUpdateTheme.TabIndex = 7;
            btnUpdateTheme.UseVisualStyleBackColor = false;
            btnUpdateTheme.Click += btnUpdateTheme_Click;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(332, 162);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(131, 20);
            lblLanguage.TabIndex = 17;
            lblLanguage.Text = "Change Language:";
            // 
            // cbLanguage
            // 
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Items.AddRange(new object[] { "Serbian(LAT)", "English(US)" });
            cbLanguage.Location = new Point(332, 201);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(195, 28);
            cbLanguage.TabIndex = 8;
            // 
            // btnUpdateLanguage
            // 
            btnUpdateLanguage.Image = Properties.Resources.update;
            btnUpdateLanguage.Location = new Point(564, 194);
            btnUpdateLanguage.Name = "btnUpdateLanguage";
            btnUpdateLanguage.Size = new Size(93, 40);
            btnUpdateLanguage.TabIndex = 9;
            btnUpdateLanguage.UseVisualStyleBackColor = false;
            btnUpdateLanguage.Click += btnUpdateLanguage_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(480, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(55, 20);
            lblUser.TabIndex = 20;
            lblUser.Text = "lblUser";
            // 
            // btnSeeNewPassword
            // 
            btnSeeNewPassword.BackColor = SystemColors.ButtonShadow;
            btnSeeNewPassword.Image = Properties.Resources.see;
            btnSeeNewPassword.Location = new Point(204, 110);
            btnSeeNewPassword.Name = "btnSeeNewPassword";
            btnSeeNewPassword.Size = new Size(57, 29);
            btnSeeNewPassword.TabIndex = 2;
            btnSeeNewPassword.UseVisualStyleBackColor = false;
            btnSeeNewPassword.Click += btnSeeNewPassword_Click;
            // 
            // btnSeeConfirmPassword
            // 
            btnSeeConfirmPassword.Image = Properties.Resources.see;
            btnSeeConfirmPassword.Location = new Point(204, 200);
            btnSeeConfirmPassword.Name = "btnSeeConfirmPassword";
            btnSeeConfirmPassword.Size = new Size(57, 29);
            btnSeeConfirmPassword.TabIndex = 4;
            btnSeeConfirmPassword.UseVisualStyleBackColor = false;
            btnSeeConfirmPassword.Click += btnSeeConfirmPassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonShadow;
            btnCancel.Image = Properties.Resources._return;
            btnCancel.Location = new Point(480, 263);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 40);
            btnCancel.TabIndex = 21;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UserSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            CancelButton = btnCancel;
            ClientSize = new Size(687, 333);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSeeConfirmPassword);
            Controls.Add(btnSeeNewPassword);
            Controls.Add(lblUser);
            Controls.Add(btnUpdateLanguage);
            Controls.Add(cbLanguage);
            Controls.Add(lblLanguage);
            Controls.Add(btnUpdateTheme);
            Controls.Add(lblTheme);
            Controls.Add(btnUpdatePassword);
            Controls.Add(tbConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(tbNewPassword);
            Controls.Add(cbTheme);
            Controls.Add(lblAccountSettings);
            MaximizeBox = false;
            MaximumSize = new Size(705, 380);
            MinimumSize = new Size(705, 380);
            Name = "UserSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountSettings;
        private ComboBox cbTheme;
        private Button btnUpdateUsername;
        private TextBox tbNewPassword;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox tbConfirmPassword;
        private Button btnUpdatePassword;
        private Label lblTheme;
        private Button btnUpdateTheme;
        private Label lblLanguage;
        private ComboBox cbLanguage;
        private Button btnUpdateLanguage;
        private Label lblUser;
        private Button btnSeeNewPassword;
        private Button btnSeeConfirmPassword;
        private Button btnCancel;
    }
}
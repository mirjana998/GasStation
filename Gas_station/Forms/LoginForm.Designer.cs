namespace Gas_station
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbGasStation = new PictureBox();
            lblUsername = new Label();
            tbUsername = new TextBox();
            lblPassword = new Label();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            pbPassword = new PictureBox();
            pbUsername = new PictureBox();
            btnSee = new Button();
            ((System.ComponentModel.ISupportInitialize)pbGasStation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).BeginInit();
            SuspendLayout();
            // 
            // pbGasStation
            // 
            pbGasStation.ErrorImage = Properties.Resources.gas_station_logo;
            pbGasStation.Image = Properties.Resources.gas_station_logo;
            pbGasStation.Location = new Point(137, -6);
            pbGasStation.Name = "pbGasStation";
            pbGasStation.Size = new Size(219, 169);
            pbGasStation.TabIndex = 1;
            pbGasStation.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Sitka Banner Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(66, 166);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(96, 29);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.Gainsboro;
            tbUsername.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(32, 202);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(405, 30);
            tbUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(71, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 29);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.Gainsboro;
            tbPassword.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(32, 302);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(364, 30);
            tbPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonShadow;
            btnLogin.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Image = Properties.Resources.logintr;
            btnLogin.Location = new Point(126, 363);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(219, 42);
            btnLogin.TabIndex = 4;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonShadow;
            btnCancel.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.canceltr;
            btnCancel.Location = new Point(126, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(219, 42);
            btnCancel.TabIndex = 5;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.passwordtr;
            pbPassword.Location = new Point(6, 236);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(59, 60);
            pbPassword.TabIndex = 8;
            pbPassword.TabStop = false;
            // 
            // pbUsername
            // 
            pbUsername.Image = Properties.Resources.usertr;
            pbUsername.Location = new Point(6, 133);
            pbUsername.Name = "pbUsername";
            pbUsername.Size = new Size(59, 62);
            pbUsername.TabIndex = 9;
            pbUsername.TabStop = false;
            // 
            // btnSee
            // 
            btnSee.BackColor = SystemColors.ButtonShadow;
            btnSee.Image = Properties.Resources.see;
            btnSee.Location = new Point(392, 302);
            btnSee.Name = "btnSee";
            btnSee.Size = new Size(45, 30);
            btnSee.TabIndex = 3;
            btnSee.UseVisualStyleBackColor = false;
            btnSee.Click += btnSee_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(482, 523);
            ControlBox = false;
            Controls.Add(btnSee);
            Controls.Add(pbUsername);
            Controls.Add(pbPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(lblPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblUsername);
            Controls.Add(pbGasStation);
            Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(500, 570);
            MinimumSize = new Size(500, 570);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)pbGasStation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbGasStation;
        private Label lblUsername;
        private TextBox tbUsername;
        private Label lblPassword;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnCancel;
        private PictureBox pbPassword;
        private PictureBox pbUsername;
        private Button btnSee;
    }
}

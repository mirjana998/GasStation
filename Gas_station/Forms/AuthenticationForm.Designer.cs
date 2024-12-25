namespace Gas_station.Forms
{
    partial class AuthenticationForm
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
            btnConfirm = new Button();
            lblEnterPassword = new Label();
            btnReturn = new Button();
            tbPassword = new TextBox();
            btnSee = new Button();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Image = Properties.Resources.confirm;
            btnConfirm.Location = new Point(225, 167);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(106, 40);
            btnConfirm.TabIndex = 4;
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblEnterPassword
            // 
            lblEnterPassword.AutoSize = true;
            lblEnterPassword.Location = new Point(36, 44);
            lblEnterPassword.Name = "lblEnterPassword";
            lblEnterPassword.Size = new Size(174, 20);
            lblEnterPassword.TabIndex = 1;
            lblEnterPassword.Text = "Please enter password:";
            // 
            // btnReturn
            // 
            btnReturn.Image = Properties.Resources._return;
            btnReturn.Location = new Point(60, 167);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(106, 40);
            btnReturn.TabIndex = 3;
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(36, 98);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(271, 27);
            tbPassword.TabIndex = 1;
            // 
            // btnSee
            // 
            btnSee.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSee.Image = Properties.Resources.see;
            btnSee.Location = new Point(305, 96);
            btnSee.Margin = new Padding(3, 4, 3, 4);
            btnSee.Name = "btnSee";
            btnSee.Size = new Size(57, 29);
            btnSee.TabIndex = 2;
            btnSee.UseVisualStyleBackColor = true;
            btnSee.Click += btnSee_Click;
            // 
            // AuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReturn;
            ClientSize = new Size(402, 233);
            ControlBox = false;
            Controls.Add(btnSee);
            Controls.Add(tbPassword);
            Controls.Add(btnReturn);
            Controls.Add(lblEnterPassword);
            Controls.Add(btnConfirm);
            Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(420, 280);
            MinimumSize = new Size(420, 280);
            Name = "AuthenticationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Label lblEnterPassword;
        private Button btnReturn;
        private TextBox tbPassword;
        private Button btnSee;
    }
}
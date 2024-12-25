namespace Gas_station.Forms
{
    partial class NewSupplierForm
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
            lblCreateNew = new Label();
            lblName = new Label();
            tbName = new TextBox();
            tbAddress = new TextBox();
            lblAddress = new Label();
            lblEmail = new Label();
            tbEmail = new TextBox();
            lblImage = new Label();
            btnImage = new Button();
            tbChosenImage = new TextBox();
            btnReturn = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblCreateNew
            // 
            lblCreateNew.AutoSize = true;
            lblCreateNew.Location = new Point(32, 40);
            lblCreateNew.Name = "lblCreateNew";
            lblCreateNew.Size = new Size(98, 20);
            lblCreateNew.TabIndex = 0;
            lblCreateNew.Text = "New Supplier";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(32, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(32, 140);
            tbName.Name = "tbName";
            tbName.Size = new Size(190, 27);
            tbName.TabIndex = 2;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(32, 240);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(190, 27);
            tbAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(32, 200);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(280, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(280, 140);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(190, 27);
            tbEmail.TabIndex = 6;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(280, 200);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(107, 20);
            lblImage.TabIndex = 7;
            lblImage.Text = "Choose image:";
            // 
            // btnImage
            // 
            btnImage.Image = Properties.Resources.image;
            btnImage.Location = new Point(410, 190);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(60, 40);
            btnImage.TabIndex = 8;
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // tbChosenImage
            // 
            tbChosenImage.Location = new Point(280, 240);
            tbChosenImage.Name = "tbChosenImage";
            tbChosenImage.ReadOnly = true;
            tbChosenImage.Size = new Size(190, 27);
            tbChosenImage.TabIndex = 9;
            // 
            // btnReturn
            // 
            btnReturn.Image = Properties.Resources._return;
            btnReturn.Location = new Point(32, 340);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(190, 40);
            btnReturn.TabIndex = 10;
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(280, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 40);
            btnSave.TabIndex = 11;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // NewSupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 429);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(btnReturn);
            Controls.Add(tbChosenImage);
            Controls.Add(btnImage);
            Controls.Add(lblImage);
            Controls.Add(tbEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblAddress);
            Controls.Add(tbAddress);
            Controls.Add(tbName);
            Controls.Add(lblName);
            Controls.Add(lblCreateNew);
            Name = "NewSupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewSupplierForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateNew;
        private Label lblName;
        private TextBox tbName;
        private TextBox tbAddress;
        private Label lblAddress;
        private Label lblEmail;
        private TextBox tbEmail;
        private Label lblImage;
        private Button btnImage;
        private TextBox tbChosenImage;
        private Button btnReturn;
        private Button btnSave;
    }
}
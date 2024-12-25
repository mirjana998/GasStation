namespace Gas_station.Forms
{
    partial class SupplierDetailsForm
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
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            lblTextId = new Label();
            pbSupplier = new PictureBox();
            btnReturn = new Button();
            btnUpdate = new Button();
            tbName = new TextBox();
            tbAddress = new TextBox();
            tbEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbSupplier).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(15, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(84, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Supplier Id:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Supplier Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(15, 120);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 170);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblTextId
            // 
            lblTextId.AutoSize = true;
            lblTextId.Location = new Point(190, 20);
            lblTextId.Name = "lblTextId";
            lblTextId.Size = new Size(66, 20);
            lblTextId.TabIndex = 4;
            lblTextId.Text = "lblTextId";
            // 
            // pbSupplier
            // 
            pbSupplier.Location = new Point(410, 12);
            pbSupplier.Name = "pbSupplier";
            pbSupplier.Size = new Size(210, 230);
            pbSupplier.TabIndex = 8;
            pbSupplier.TabStop = false;
            // 
            // btnReturn
            // 
            btnReturn.Image = Properties.Resources._return;
            btnReturn.Location = new Point(430, 261);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(190, 40);
            btnReturn.TabIndex = 9;
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.update;
            btnUpdate.Location = new Point(190, 261);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 40);
            btnUpdate.TabIndex = 10;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(190, 63);
            tbName.Name = "tbName";
            tbName.Size = new Size(190, 27);
            tbName.TabIndex = 11;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(190, 113);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(190, 27);
            tbAddress.TabIndex = 12;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(190, 163);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(190, 27);
            tbEmail.TabIndex = 13;
            // 
            // SupplierDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 323);
            ControlBox = false;
            Controls.Add(tbEmail);
            Controls.Add(tbAddress);
            Controls.Add(tbName);
            Controls.Add(btnUpdate);
            Controls.Add(btnReturn);
            Controls.Add(pbSupplier);
            Controls.Add(lblTextId);
            Controls.Add(lblEmail);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblId);
            MaximumSize = new Size(650, 370);
            MinimumSize = new Size(650, 370);
            Name = "SupplierDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier Details";
            ((System.ComponentModel.ISupportInitialize)pbSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblTextId;
        private PictureBox pbSupplier;
        private Button btnReturn;
        private Button btnUpdate;
        private TextBox tbName;
        private TextBox tbAddress;
        private TextBox tbEmail;
    }
}
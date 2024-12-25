namespace Gas_station
{
    partial class StoreForm
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
            pbLogo = new PictureBox();
            lvItems = new ListView();
            colBarcode = new ColumnHeader();
            colName = new ColumnHeader();
            colQuantity = new ColumnHeader();
            colPrice = new ColumnHeader();
            lblUser = new Label();
            btnWarehouse = new Button();
            tbBarcode = new TextBox();
            tbDescription = new TextBox();
            lblBarcode = new Label();
            lblArticleName = new Label();
            tbQuantity = new TextBox();
            lblQuantity = new Label();
            btnAdd = new Button();
            cbPaymentType = new ComboBox();
            btnPrintBill = new Button();
            btnLogout = new Button();
            btnSettings = new Button();
            tbComment = new TextBox();
            lblPaymentType = new Label();
            lblComment = new Label();
            lblNewInvoice = new Label();
            lblUsername = new Label();
            lblTotal = new Label();
            tbTotal = new TextBox();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.gas_station_logo;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(193, 154);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lvItems
            // 
            lvItems.BackColor = Color.Azure;
            lvItems.Columns.AddRange(new ColumnHeader[] { colBarcode, colName, colQuantity, colPrice });
            lvItems.FullRowSelect = true;
            lvItems.Location = new Point(271, 173);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(783, 267);
            lvItems.TabIndex = 9;
            lvItems.UseCompatibleStateImageBehavior = false;
            lvItems.View = View.Details;
            // 
            // colBarcode
            // 
            colBarcode.Text = "Barcode";
            colBarcode.Width = 180;
            // 
            // colName
            // 
            colName.Text = "Article Name";
            colName.Width = 270;
            // 
            // colQuantity
            // 
            colQuantity.Text = "Quantity";
            colQuantity.Width = 165;
            // 
            // colPrice
            // 
            colPrice.Text = "Price";
            colPrice.Width = 165;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.MidnightBlue;
            lblUser.Location = new Point(12, 590);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(88, 21);
            lblUser.TabIndex = 3;
            lblUser.Text = "Username:";
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = SystemColors.ActiveCaption;
            btnWarehouse.Image = Properties.Resources.warehouse;
            btnWarehouse.Location = new Point(37, 230);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(190, 50);
            btnWarehouse.TabIndex = 1;
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // tbBarcode
            // 
            tbBarcode.BackColor = Color.Azure;
            tbBarcode.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarcode.Location = new Point(271, 127);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(200, 28);
            tbBarcode.TabIndex = 4;
            tbBarcode.KeyUp += tbBarcode_KeyUp;
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.Azure;
            tbDescription.Enabled = false;
            tbDescription.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescription.Location = new Point(492, 127);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(200, 29);
            tbDescription.TabIndex = 5;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(271, 100);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(67, 20);
            lblBarcode.TabIndex = 7;
            lblBarcode.Text = "Barcode:";
            // 
            // lblArticleName
            // 
            lblArticleName.AutoSize = true;
            lblArticleName.Location = new Point(492, 100);
            lblArticleName.Name = "lblArticleName";
            lblArticleName.Size = new Size(88, 20);
            lblArticleName.TabIndex = 8;
            lblArticleName.Text = "Description:";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(714, 127);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(200, 27);
            tbQuantity.TabIndex = 6;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(717, 100);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity:";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.addtr;
            btnAdd.Location = new Point(932, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 29);
            btnAdd.TabIndex = 7;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbPaymentType
            // 
            cbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentType.FormattingEnabled = true;
            cbPaymentType.Items.AddRange(new object[] { "Cash", "Card" });
            cbPaymentType.Location = new Point(271, 489);
            cbPaymentType.Name = "cbPaymentType";
            cbPaymentType.Size = new Size(200, 28);
            cbPaymentType.TabIndex = 10;
            // 
            // btnPrintBill
            // 
            btnPrintBill.Image = Properties.Resources.printbilltr;
            btnPrintBill.Location = new Point(764, 561);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(190, 50);
            btnPrintBill.TabIndex = 13;
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.logouttr;
            btnLogout.Location = new Point(37, 430);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 50);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Location = new Point(37, 330);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(190, 50);
            btnSettings.TabIndex = 2;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // tbComment
            // 
            tbComment.Location = new Point(492, 489);
            tbComment.MinimumSize = new Size(200, 90);
            tbComment.Multiline = true;
            tbComment.Name = "tbComment";
            tbComment.Size = new Size(200, 122);
            tbComment.TabIndex = 11;
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Location = new Point(271, 459);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(103, 20);
            lblPaymentType.TabIndex = 18;
            lblPaymentType.Text = "Payment Type:";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Location = new Point(492, 459);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(77, 20);
            lblComment.TabIndex = 19;
            lblComment.Text = "Comment:";
            // 
            // lblNewInvoice
            // 
            lblNewInvoice.AutoSize = true;
            lblNewInvoice.Location = new Point(271, 48);
            lblNewInvoice.Name = "lblNewInvoice";
            lblNewInvoice.Size = new Size(129, 20);
            lblNewInvoice.TabIndex = 20;
            lblNewInvoice.Text = "New sales invoice:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(97, 570);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 20);
            lblUsername.TabIndex = 21;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(764, 459);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "Total:";
            // 
            // tbTotal
            // 
            tbTotal.Enabled = false;
            tbTotal.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTotal.Location = new Point(764, 489);
            tbTotal.Multiline = true;
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(190, 50);
            tbTotal.TabIndex = 12;
            // 
            // btnRemove
            // 
            btnRemove.Image = Properties.Resources.remove;
            btnRemove.Location = new Point(1000, 126);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(50, 29);
            btnRemove.TabIndex = 8;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // StoreForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLogout;
            ClientSize = new Size(1072, 653);
            ControlBox = false;
            Controls.Add(btnRemove);
            Controls.Add(tbTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblUsername);
            Controls.Add(lblNewInvoice);
            Controls.Add(lblComment);
            Controls.Add(lblPaymentType);
            Controls.Add(tbComment);
            Controls.Add(btnSettings);
            Controls.Add(btnLogout);
            Controls.Add(btnPrintBill);
            Controls.Add(cbPaymentType);
            Controls.Add(btnAdd);
            Controls.Add(lblQuantity);
            Controls.Add(tbQuantity);
            Controls.Add(lblArticleName);
            Controls.Add(lblBarcode);
            Controls.Add(tbDescription);
            Controls.Add(tbBarcode);
            Controls.Add(btnWarehouse);
            Controls.Add(lblUser);
            Controls.Add(lvItems);
            Controls.Add(pbLogo);
            MaximizeBox = false;
            MaximumSize = new Size(1090, 700);
            MinimumSize = new Size(1090, 700);
            Name = "StoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private ListView lvItems;
        private Label lblUser;
        private Button btnWarehouse;
        private TextBox tbBarcode;
        private TextBox tbDescription;
        private Label lblBarcode;
        private Label lblArticleName;
        private TextBox tbQuantity;
        private Label lblQuantity;
        private Button btnAdd;
        private ComboBox cbPaymentType;
        private Button btnPrintBill;
        private Button btnLogout;
        private Button btnSettings;
        private TextBox tbComment;
        private Label lblPaymentType;
        private Label lblComment;
        private Label lblNewInvoice;
        private Label lblUsername;
        public ColumnHeader colName;
        public ColumnHeader colBarcode;
        private ColumnHeader colQuantity;
        private ColumnHeader colPrice;
        private Label lblTotal;
        private TextBox tbTotal;
        private Button btnRemove;
    }
}
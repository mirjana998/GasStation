namespace Gas_station.Forms
{
    partial class AccountantForm
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
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            lblUsername = new Label();
            btnWarehouse = new Button();
            btnNewItem = new Button();
            btnNewSupplier = new Button();
            lblNewInvoice = new Label();
            lvSupplier = new ListView();
            colSupplierId = new ColumnHeader();
            colSupplierName = new ColumnHeader();
            lblSupplier = new Label();
            lvItems = new ListView();
            colBarcode = new ColumnHeader();
            colDescription = new ColumnHeader();
            colQuantity = new ColumnHeader();
            colPrice = new ColumnHeader();
            tbBarcode = new TextBox();
            tbDescription = new TextBox();
            tbQuantity = new TextBox();
            btnAdd = new Button();
            cbPaymentType = new ComboBox();
            lblBarcode = new Label();
            lblDescription = new Label();
            lblQuantity = new Label();
            lblPaymentType = new Label();
            tbTotal = new TextBox();
            btnConfirmInvoice = new Button();
            lblTotal = new Label();
            btnSettings = new Button();
            lblComment = new Label();
            tbComment = new TextBox();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gas_station_logo;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 154);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.logouttr;
            btnLogout.Location = new Point(20, 570);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 50);
            btnLogout.TabIndex = 5;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(20, 744);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // btnWarehouse
            // 
            btnWarehouse.Image = Properties.Resources.warehouse;
            btnWarehouse.Location = new Point(20, 210);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(190, 50);
            btnWarehouse.TabIndex = 1;
            btnWarehouse.UseVisualStyleBackColor = true;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnNewItem
            // 
            btnNewItem.Image = Properties.Resources.new_product;
            btnNewItem.Location = new Point(20, 390);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new Size(190, 50);
            btnNewItem.TabIndex = 3;
            btnNewItem.UseVisualStyleBackColor = true;
            btnNewItem.Click += btnNewItem_Click;
            // 
            // btnNewSupplier
            // 
            btnNewSupplier.Image = Properties.Resources.supplier;
            btnNewSupplier.Location = new Point(20, 300);
            btnNewSupplier.Name = "btnNewSupplier";
            btnNewSupplier.Size = new Size(190, 50);
            btnNewSupplier.TabIndex = 2;
            btnNewSupplier.UseVisualStyleBackColor = true;
            btnNewSupplier.Click += btnNewSupplier_Click;
            // 
            // lblNewInvoice
            // 
            lblNewInvoice.AutoSize = true;
            lblNewInvoice.Location = new Point(251, 61);
            lblNewInvoice.Name = "lblNewInvoice";
            lblNewInvoice.Size = new Size(152, 20);
            lblNewInvoice.TabIndex = 8;
            lblNewInvoice.Text = "New Supplier Invoice:";
            // 
            // lvSupplier
            // 
            lvSupplier.Columns.AddRange(new ColumnHeader[] { colSupplierId, colSupplierName });
            lvSupplier.FullRowSelect = true;
            lvSupplier.HoverSelection = true;
            lvSupplier.Location = new Point(251, 525);
            lvSupplier.MultiSelect = false;
            lvSupplier.Name = "lvSupplier";
            lvSupplier.Size = new Size(311, 185);
            lvSupplier.TabIndex = 12;
            lvSupplier.UseCompatibleStateImageBehavior = false;
            lvSupplier.View = View.Details;
            lvSupplier.ItemActivate += lvSupplier_ItemActivate;
            // 
            // colSupplierId
            // 
            colSupplierId.Text = "Id";
            colSupplierId.Width = 110;
            // 
            // colSupplierName
            // 
            colSupplierName.Text = "Name";
            colSupplierName.Width = 200;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(251, 479);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(177, 20);
            lblSupplier.TabIndex = 10;
            lblSupplier.Text = "Choose supplier from list:";
            // 
            // lvItems
            // 
            lvItems.Columns.AddRange(new ColumnHeader[] { colBarcode, colDescription, colQuantity, colPrice });
            lvItems.FullRowSelect = true;
            lvItems.Location = new Point(251, 210);
            lvItems.MultiSelect = false;
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(789, 230);
            lvItems.TabIndex = 11;
            lvItems.UseCompatibleStateImageBehavior = false;
            lvItems.View = View.Details;
            // 
            // colBarcode
            // 
            colBarcode.Text = "Barcode";
            colBarcode.Width = 160;
            // 
            // colDescription
            // 
            colDescription.Text = "Description";
            colDescription.Width = 250;
            // 
            // colQuantity
            // 
            colQuantity.Text = "Quantity";
            colQuantity.Width = 150;
            // 
            // colPrice
            // 
            colPrice.Text = "Price";
            colPrice.Width = 170;
            // 
            // tbBarcode
            // 
            tbBarcode.Location = new Point(251, 161);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(200, 27);
            tbBarcode.TabIndex = 6;
            tbBarcode.KeyUp += tbBarcode_KeyUp;
            // 
            // tbDescription
            // 
            tbDescription.Enabled = false;
            tbDescription.Location = new Point(477, 161);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(200, 27);
            tbDescription.TabIndex = 7;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(702, 161);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(200, 27);
            tbQuantity.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.addtr;
            btnAdd.Location = new Point(927, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(49, 29);
            btnAdd.TabIndex = 9;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbPaymentType
            // 
            cbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentType.FormattingEnabled = true;
            cbPaymentType.Items.AddRange(new object[] { "Cash", "Card" });
            cbPaymentType.Location = new Point(580, 525);
            cbPaymentType.Name = "cbPaymentType";
            cbPaymentType.Size = new Size(200, 28);
            cbPaymentType.TabIndex = 13;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(251, 128);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(67, 20);
            lblBarcode.TabIndex = 17;
            lblBarcode.Text = "Barcode:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(477, 128);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Description:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(702, 128);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 19;
            lblQuantity.Text = "Quantity:";
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Location = new Point(580, 480);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(156, 20);
            lblPaymentType.TabIndex = 20;
            lblPaymentType.Text = "Choose payment type:";
            // 
            // tbTotal
            // 
            tbTotal.Enabled = false;
            tbTotal.Location = new Point(797, 525);
            tbTotal.Multiline = true;
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(190, 50);
            tbTotal.TabIndex = 15;
            // 
            // btnConfirmInvoice
            // 
            btnConfirmInvoice.Image = Properties.Resources.confirmInvoice;
            btnConfirmInvoice.Location = new Point(797, 608);
            btnConfirmInvoice.Name = "btnConfirmInvoice";
            btnConfirmInvoice.Size = new Size(190, 50);
            btnConfirmInvoice.TabIndex = 16;
            btnConfirmInvoice.UseVisualStyleBackColor = true;
            btnConfirmInvoice.Click += btnConfirmInvoice_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(797, 479);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total:";
            // 
            // btnSettings
            // 
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Location = new Point(20, 480);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(190, 50);
            btnSettings.TabIndex = 4;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Location = new Point(580, 570);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(77, 20);
            lblComment.TabIndex = 25;
            lblComment.Text = "Comment:";
            // 
            // tbComment
            // 
            tbComment.Location = new Point(580, 608);
            tbComment.Multiline = true;
            tbComment.Name = "tbComment";
            tbComment.Size = new Size(200, 102);
            tbComment.TabIndex = 14;
            // 
            // btnRemove
            // 
            btnRemove.Image = Properties.Resources.remove;
            btnRemove.Location = new Point(991, 160);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(49, 29);
            btnRemove.TabIndex = 10;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // AccountantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 773);
            ControlBox = false;
            Controls.Add(btnRemove);
            Controls.Add(tbComment);
            Controls.Add(lblComment);
            Controls.Add(btnSettings);
            Controls.Add(lblTotal);
            Controls.Add(btnConfirmInvoice);
            Controls.Add(tbTotal);
            Controls.Add(lblPaymentType);
            Controls.Add(lblQuantity);
            Controls.Add(lblDescription);
            Controls.Add(lblBarcode);
            Controls.Add(cbPaymentType);
            Controls.Add(btnAdd);
            Controls.Add(tbQuantity);
            Controls.Add(tbDescription);
            Controls.Add(tbBarcode);
            Controls.Add(lvItems);
            Controls.Add(lblSupplier);
            Controls.Add(lvSupplier);
            Controls.Add(lblNewInvoice);
            Controls.Add(btnNewSupplier);
            Controls.Add(btnNewItem);
            Controls.Add(btnWarehouse);
            Controls.Add(lblUsername);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1080, 820);
            MinimumSize = new Size(1080, 820);
            Name = "AccountantForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounting";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLogout;
        private Label lblUsername;
        private Button btnWarehouse;
        private Button btnNewItem;
        private Button btnNewSupplier;
        private Label lblNewInvoice;
        private ListView lvSupplier;
        private Label lblSupplier;
        public ColumnHeader colSupplierId;
        public ColumnHeader colSupplierName;
        private ListView lvItems;
        private TextBox tbBarcode;
        private TextBox tbDescription;
        private TextBox tbQuantity;
        private Button btnAdd;
        private ComboBox cbPaymentType;
        private Label lblBarcode;
        private Label lblDescription;
        private Label lblQuantity;
        private Label lblPaymentType;
        private TextBox tbTotal;
        private Button btnConfirmInvoice;
        private Label lblTotal;
        private Button btnSettings;
        private Label lblComment;
        private TextBox tbComment;
        public ColumnHeader colBarcode;
        private ColumnHeader colDescription;
        private ColumnHeader colQuantity;
        private ColumnHeader colPrice;
        private Button btnRemove;
    }
}
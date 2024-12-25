
namespace Gas_station.Forms
{
    partial class WarehouseForm
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
            lblUsername = new Label();
            pbLogo = new PictureBox();
            lvProducts = new ListView();
            colBarcode = new ColumnHeader();
            colArticleName = new ColumnHeader();
            colStock = new ColumnHeader();
            colPrice = new ColumnHeader();
            lblSearchId = new Label();
            tbBarcode = new TextBox();
            lblSearchName = new Label();
            tbArticleName = new TextBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 544);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // pbLogo
            // 
            pbLogo.AccessibleRole = AccessibleRole.None;
            pbLogo.Image = Properties.Resources.gas_station_logo;
            pbLogo.Location = new Point(-16, -38);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(171, 155);
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { colBarcode, colArticleName, colStock, colPrice });
            lvProducts.FullRowSelect = true;
            lvProducts.Location = new Point(239, 0);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(504, 571);
            lvProducts.TabIndex = 3;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            lvProducts.ItemActivate += lvProducts_ItemActivate;
            // 
            // colBarcode
            // 
            colBarcode.Text = "Barcode";
            colBarcode.Width = 100;
            // 
            // colArticleName
            // 
            colArticleName.Text = "Article Name";
            colArticleName.Width = 200;
            // 
            // colStock
            // 
            colStock.Text = "Stock";
            colStock.Width = 100;
            // 
            // colPrice
            // 
            colPrice.Text = "Price";
            colPrice.Width = 100;
            // 
            // lblSearchId
            // 
            lblSearchId.AutoSize = true;
            lblSearchId.Location = new Point(12, 165);
            lblSearchId.Name = "lblSearchId";
            lblSearchId.Size = new Size(135, 20);
            lblSearchId.TabIndex = 5;
            lblSearchId.Text = "Search by barcode:";
            // 
            // tbBarcode
            // 
            tbBarcode.Location = new Point(16, 208);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(190, 27);
            tbBarcode.TabIndex = 1;
            tbBarcode.KeyUp += tbBarcode_KeyUp;
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Location = new Point(12, 268);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(162, 20);
            lblSearchName.TabIndex = 7;
            lblSearchName.Text = "Search by article name:";
            // 
            // tbArticleName
            // 
            tbArticleName.Location = new Point(16, 314);
            tbArticleName.Name = "tbArticleName";
            tbArticleName.Size = new Size(190, 27);
            tbArticleName.TabIndex = 2;
            tbArticleName.KeyUp += tbArticleName_KeyUp;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources._return;
            btnCancel.Location = new Point(16, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(190, 40);
            btnCancel.TabIndex = 7;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 573);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(tbArticleName);
            Controls.Add(lblSearchName);
            Controls.Add(tbBarcode);
            Controls.Add(lblSearchId);
            Controls.Add(lvProducts);
            Controls.Add(pbLogo);
            Controls.Add(lblUsername);
            MaximumSize = new Size(760, 620);
            MinimumSize = new Size(760, 620);
            Name = "WarehouseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warehouse";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private PictureBox pbLogo;
        private ListView lvProducts;
        public ColumnHeader colBarcode;
        public ColumnHeader colArticleName;
        private ColumnHeader colStock;
        private ColumnHeader colPrice;
        private Label lblSearchId;
        private TextBox tbBarcode;
        private Label lblSearchName;
        private TextBox tbArticleName;
        private Button btnCancel;
    }
}
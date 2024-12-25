namespace Gas_station.Forms
{
    partial class ProductDetailsForm
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
            pbArticle = new PictureBox();
            lblArticleName = new Label();
            lblBarcode = new Label();
            lblCategory = new Label();
            lblMeasurementUnit = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            btnReturn = new Button();
            lblTextId = new Label();
            lblTextCategory = new Label();
            lblTextUnit = new Label();
            lblTextStock = new Label();
            btnUpdate = new Button();
            tbPrice = new TextBox();
            tbName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbArticle).BeginInit();
            SuspendLayout();
            // 
            // pbArticle
            // 
            pbArticle.Location = new Point(390, 12);
            pbArticle.Name = "pbArticle";
            pbArticle.Size = new Size(210, 230);
            pbArticle.TabIndex = 0;
            pbArticle.TabStop = false;
            // 
            // lblArticleName
            // 
            lblArticleName.AutoSize = true;
            lblArticleName.Location = new Point(15, 70);
            lblArticleName.Name = "lblArticleName";
            lblArticleName.Size = new Size(99, 20);
            lblArticleName.TabIndex = 3;
            lblArticleName.Text = "Article Name:";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(15, 20);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(67, 20);
            lblBarcode.TabIndex = 2;
            lblBarcode.Text = "Barcode:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 120);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category:";
            // 
            // lblMeasurementUnit
            // 
            lblMeasurementUnit.AutoSize = true;
            lblMeasurementUnit.Location = new Point(15, 170);
            lblMeasurementUnit.Name = "lblMeasurementUnit";
            lblMeasurementUnit.Size = new Size(133, 20);
            lblMeasurementUnit.TabIndex = 5;
            lblMeasurementUnit.Text = "Measurement Unit:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(15, 270);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(15, 220);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock:";
            // 
            // btnReturn
            // 
            btnReturn.Image = Properties.Resources._return;
            btnReturn.Location = new Point(410, 341);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(190, 40);
            btnReturn.TabIndex = 1;
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblTextId
            // 
            lblTextId.AutoSize = true;
            lblTextId.Location = new Point(190, 20);
            lblTextId.Name = "lblTextId";
            lblTextId.Size = new Size(66, 20);
            lblTextId.TabIndex = 8;
            lblTextId.Text = "lblTextId";
            // 
            // lblTextCategory
            // 
            lblTextCategory.AutoSize = true;
            lblTextCategory.Location = new Point(190, 120);
            lblTextCategory.Name = "lblTextCategory";
            lblTextCategory.Size = new Size(113, 20);
            lblTextCategory.TabIndex = 10;
            lblTextCategory.Text = "lblTextCategory";
            // 
            // lblTextUnit
            // 
            lblTextUnit.AutoSize = true;
            lblTextUnit.Location = new Point(190, 170);
            lblTextUnit.Name = "lblTextUnit";
            lblTextUnit.Size = new Size(80, 20);
            lblTextUnit.TabIndex = 11;
            lblTextUnit.Text = "lblTextUnit";
            // 
            // lblTextStock
            // 
            lblTextStock.AutoSize = true;
            lblTextStock.Location = new Point(190, 220);
            lblTextStock.Name = "lblTextStock";
            lblTextStock.Size = new Size(89, 20);
            lblTextStock.TabIndex = 12;
            lblTextStock.Text = "lblTextStock";
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.update;
            btnUpdate.Location = new Point(190, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 40);
            btnUpdate.TabIndex = 14;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(190, 270);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(190, 27);
            tbPrice.TabIndex = 15;
            // 
            // tbName
            // 
            tbName.Location = new Point(190, 67);
            tbName.Name = "tbName";
            tbName.Size = new Size(190, 27);
            tbName.TabIndex = 16;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 403);
            ControlBox = false;
            Controls.Add(tbName);
            Controls.Add(tbPrice);
            Controls.Add(btnUpdate);
            Controls.Add(lblTextStock);
            Controls.Add(lblTextUnit);
            Controls.Add(lblTextCategory);
            Controls.Add(lblTextId);
            Controls.Add(btnReturn);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblMeasurementUnit);
            Controls.Add(lblCategory);
            Controls.Add(lblBarcode);
            Controls.Add(lblArticleName);
            Controls.Add(pbArticle);
            MaximumSize = new Size(630, 450);
            MinimumSize = new Size(630, 450);
            Name = "ProductDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Article Information";
            ((System.ComponentModel.ISupportInitialize)pbArticle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbArticle;
        private Label lblArticleName;
        private Label lblBarcode;
        private Label lblCategory;
        private Label lblMeasurementUnit;
        private Label lblPrice;
        private Label lblStock;
        private Button btnReturn;
        private Label lblTextId;
        private Label lblTextCategory;
        private Label lblTextUnit;
        private Label lblTextStock;
        private Button btnUpdate;
        private TextBox tbPrice;
        private TextBox tbName;
    }
}
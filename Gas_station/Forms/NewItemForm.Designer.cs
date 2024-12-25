namespace Gas_station.Forms
{
    partial class NewItemForm
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
            btnImage = new Button();
            tbDescription = new TextBox();
            lblCreateNew = new Label();
            lblDescription = new Label();
            lblMeasurementUnit = new Label();
            cbMeasurementUnit = new ComboBox();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblPrice = new Label();
            tbPrice = new TextBox();
            label4 = new Label();
            lblImage = new Label();
            tbChosenImage = new TextBox();
            btnSave = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnImage
            // 
            btnImage.Image = Properties.Resources.image;
            btnImage.Location = new Point(162, 290);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(60, 40);
            btnImage.TabIndex = 5;
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(32, 140);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(190, 27);
            tbDescription.TabIndex = 1;
            // 
            // lblCreateNew
            // 
            lblCreateNew.AutoSize = true;
            lblCreateNew.Location = new Point(32, 40);
            lblCreateNew.Name = "lblCreateNew";
            lblCreateNew.Size = new Size(117, 20);
            lblCreateNew.TabIndex = 2;
            lblCreateNew.Text = "Create new item";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(32, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // lblMeasurementUnit
            // 
            lblMeasurementUnit.AutoSize = true;
            lblMeasurementUnit.Location = new Point(32, 200);
            lblMeasurementUnit.Name = "lblMeasurementUnit";
            lblMeasurementUnit.Size = new Size(131, 20);
            lblMeasurementUnit.TabIndex = 4;
            lblMeasurementUnit.Text = "Measurement unit:";
            // 
            // cbMeasurementUnit
            // 
            cbMeasurementUnit.FormattingEnabled = true;
            cbMeasurementUnit.Items.AddRange(new object[] { "litar", "komad" });
            cbMeasurementUnit.Location = new Point(32, 240);
            cbMeasurementUnit.Name = "cbMeasurementUnit";
            cbMeasurementUnit.Size = new Size(190, 28);
            cbMeasurementUnit.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(280, 200);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "goriva i maziva", "hrana", "piće" });
            cbCategory.Location = new Point(280, 240);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(190, 28);
            cbCategory.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(280, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price:";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(280, 140);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(190, 27);
            tbPrice.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 318);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(32, 300);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(107, 20);
            lblImage.TabIndex = 11;
            lblImage.Text = "Choose image:";
            // 
            // tbChosenImage
            // 
            tbChosenImage.Location = new Point(280, 290);
            tbChosenImage.Multiline = true;
            tbChosenImage.Name = "tbChosenImage";
            tbChosenImage.ReadOnly = true;
            tbChosenImage.Size = new Size(190, 40);
            tbChosenImage.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(276, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 40);
            btnSave.TabIndex = 8;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.Image = Properties.Resources._return;
            btnReturn.Location = new Point(32, 370);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(190, 40);
            btnReturn.TabIndex = 7;
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // NewItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 443);
            ControlBox = false;
            Controls.Add(btnReturn);
            Controls.Add(btnSave);
            Controls.Add(tbChosenImage);
            Controls.Add(lblImage);
            Controls.Add(label4);
            Controls.Add(tbPrice);
            Controls.Add(lblPrice);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Controls.Add(cbMeasurementUnit);
            Controls.Add(lblMeasurementUnit);
            Controls.Add(lblDescription);
            Controls.Add(lblCreateNew);
            Controls.Add(tbDescription);
            Controls.Add(btnImage);
            Name = "NewItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImage;
        private TextBox tbDescription;
        private Label lblCreateNew;
        private Label lblDescription;
        private Label lblMeasurementUnit;
        private ComboBox cbMeasurementUnit;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Label lblPrice;
        private TextBox tbPrice;
        private Label label4;
        private Label lblImage;
        private TextBox tbChosenImage;
        private Button btnSave;
        private Button btnReturn;
    }
}
using Gas_station.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using Gas_station.DataAccess.MySql;

namespace Gas_station.Forms
{
    public partial class NewItemForm : Form
    {
        public Employee employee { get; set; }
        public ToolTip toolTip { get; set; }

        public List<Product> products { get; set; }
        public NewItemForm()
        {
            InitializeComponent();
            employee = new Employee();
        }

        public NewItemForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            toolTip = new ToolTip();
            switch (employee.ThemeId)
            {
                case 2: InitializeDarkTheme(); break;
                case 3: InitializeBlueTheme(); break;
                default: InitializeLightTheme(); break;
            }
            InitializeLanguage();
            InitializeProducts();

        }

        public void InitializeDarkTheme()
        {
            BackColor = SystemColors.ControlDarkDark;

            btnReturn.BackColor = SystemColors.ScrollBar;
            btnImage.BackColor = SystemColors.ScrollBar;
            btnSave.BackColor = SystemColors.ScrollBar;

            tbDescription.BackColor = SystemColors.MenuBar;
            tbPrice.BackColor = SystemColors.MenuBar;
            cbMeasurementUnit.BackColor = SystemColors.MenuBar;
            tbChosenImage.BackColor = SystemColors.MenuBar;
            cbCategory.BackColor = SystemColors.MenuBar;

            //Font and ForeColor
            lblDescription.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.Control;
            lblPrice.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.Control;
            lblMeasurementUnit.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeasurementUnit.ForeColor = SystemColors.Control;
            lblCategory.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.Control;
            lblImage.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImage.ForeColor = SystemColors.Control;
            lblCreateNew.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNew.ForeColor = SystemColors.Control;


            tbDescription.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMeasurementUnit.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbChosenImage.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);

        }

        public void InitializeLightTheme()
        {
            BackColor = Color.White;

            btnReturn.BackColor = SystemColors.ButtonShadow;
            btnImage.BackColor = SystemColors.ButtonShadow;
            btnSave.BackColor = SystemColors.ButtonShadow;

            tbDescription.BackColor = Color.Gainsboro;
            tbPrice.BackColor = Color.Gainsboro;
            cbMeasurementUnit.BackColor = Color.Gainsboro;
            tbChosenImage.BackColor = Color.Gainsboro;
            cbCategory.BackColor = Color.Gainsboro;

            //Font and ForeColor
            lblDescription.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.ControlText;
            lblPrice.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ControlText;
            lblMeasurementUnit.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeasurementUnit.ForeColor = SystemColors.ControlText;
            lblCategory.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ControlText;
            lblImage.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImage.ForeColor = SystemColors.ControlText;
            lblCreateNew.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNew.ForeColor = SystemColors.ControlText;


            tbDescription.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMeasurementUnit.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbChosenImage.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);

        }

        public void InitializeBlueTheme()
        {
            BackColor = Color.LightBlue;

            btnReturn.BackColor = SystemColors.ActiveCaption;
            btnImage.BackColor = SystemColors.ActiveCaption;
            btnSave.BackColor = SystemColors.ActiveCaption;

            tbDescription.BackColor = Color.Azure;
            tbPrice.BackColor = Color.Azure;
            cbMeasurementUnit.BackColor = Color.Azure;
            tbChosenImage.BackColor = Color.Azure;
            cbCategory.BackColor = Color.Azure;

            //Font and ForeColor
            lblDescription.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.MidnightBlue;
            lblPrice.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.MidnightBlue;
            lblMeasurementUnit.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeasurementUnit.ForeColor = Color.MidnightBlue;
            lblCategory.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.MidnightBlue;
            lblImage.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImage.ForeColor = Color.MidnightBlue;
            lblCreateNew.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNew.ForeColor = Color.MidnightBlue;


            tbDescription.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMeasurementUnit.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbChosenImage.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);

        }

        public void InitializeLanguage()
        {

            switch (employee.Language)
            {
                case "Serbian(LAT)":
                    toolTip.SetToolTip(btnReturn, "Vrati se nazad");
                    toolTip.SetToolTip(btnImage, "Odaberi sliku");
                    toolTip.SetToolTip(btnSave, "Sačuvaj artikal");
                    lblDescription.Text = "Naziv artikla: ";
                    lblPrice.Text = "Cijena: ";
                    lblMeasurementUnit.Text = "Mjerna jedinica: ";
                    lblCategory.Text = "Kategorija: ";
                    lblImage.Text = "Odaberite sliku: ";
                    lblCreateNew.Text = "Novi artikal";
                    cbCategory.Items[0] = "Goriva i maziva";
                    cbCategory.Items[1] = "Hrana";
                    cbCategory.Items[2] = "Piće";
                    cbMeasurementUnit.Items[0] = "litar";
                    cbMeasurementUnit.Items[1] = "komad";
                    this.Text = "Novi artikal";
                    break;
                default:
                    toolTip.SetToolTip(btnReturn, "Return");
                    toolTip.SetToolTip(btnImage, "Choose image");
                    toolTip.SetToolTip(btnSave, "Save item");
                    lblDescription.Text = "Description: ";
                    lblPrice.Text = "Price: ";
                    lblMeasurementUnit.Text = "Measurement unit: ";
                    lblCategory.Text = "Category: ";
                    lblImage.Text = "Choose image: ";
                    lblCreateNew.Text = "New item";
                    cbCategory.Items[0] = "Fuel and oil";
                    cbCategory.Items[1] = "Food";
                    cbCategory.Items[2] = "Drink";
                    cbMeasurementUnit.Items[0] = "liter";
                    cbMeasurementUnit.Items[1] = "piece";
                    this.Text = "New item";
                    break;
            }
        }

        public void InitializeProducts()
        {
            MySqlProduct mySqlProduct = new MySqlProduct();
            products = mySqlProduct.GetProducts();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InitializeProducts();
            Product product = new Product();
            if (products.Count > 0)
            {
                product.ProductId = products.Count() + 1;
            }
            else
            {
                product.ProductId = 1;
            }
            if (String.IsNullOrEmpty(tbDescription.Text) || String.IsNullOrEmpty(tbPrice.Text) || String.IsNullOrEmpty(cbMeasurementUnit.Text) || String.IsNullOrEmpty(cbCategory.Text) || String.IsNullOrEmpty(tbChosenImage.Text))
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Nepopunjena polja!" : "Missing fields!", "Serbian(LAT)".Equals(employee.Language) ? "Greska" : "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                product.Name = tbDescription.Text;
                product.Price = Decimal.Parse(tbPrice.Text);
                product.MeasurementUnit = cbMeasurementUnit.Text;
                product.CategoryId = cbCategory.SelectedIndex + 1;
                product.Image = tbChosenImage.Text;
                product.Stock = 0;
                MySqlProduct mySqlProduct = new MySqlProduct();
                mySqlProduct.Insert(product);
                products.Add(product);
            }


        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            tbChosenImage.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Serbian(LAT)".Equals(employee.Language) ? "Odaberi datoteku" : "Choose file";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                char separator = '\\';
                string[] parts = selectedFilePath.Split(separator);
                if (parts.Length > 1)
                {
                    tbChosenImage.Text = parts[parts.Length - 1];
                }

            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gas_station.DataAccess.MySql;
using Gas_station.Model;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Datatypes;
using Org.BouncyCastle.Asn1.Mozilla;


namespace Gas_station.Forms
{
    public partial class ProductDetailsForm : Form
    {
        public Product product { get; set; }
        public Employee employee { get; set; }
        public ToolTip toolTip { get; set; }
        public WarehouseForm warehouse { get; set; }
        public ProductDetailsForm()
        {
            InitializeComponent();
            product = new Product();
            employee = new Employee();
            toolTip = new ToolTip();
            InitializeLightTheme();
            InitializeLanguage();
            
        }

        public ProductDetailsForm(Product product, Employee employee, WarehouseForm warehouse)
        {
            InitializeComponent();
            this.product = product;
            this.employee = employee;
            this.warehouse = warehouse;
            toolTip = new ToolTip();
            switch (employee.ThemeId)
            {
                case 2: InitializeDarkTheme(); break;
                case 3: InitializeBlueTheme(); break;
                default: InitializeLightTheme(); break;
            }
            InitializeLanguage();
            lblTextId.Text = product.ProductId.ToString();
            tbName.Text = product.Name;
            lblTextCategory.Text = product.CategoryId.ToString();
            lblTextStock.Text = product.Stock.ToString();
            lblTextUnit.Text = product.MeasurementUnit;
            tbPrice.Text = product.Price.ToString();
            InitializeImage();
            if(employee.RoleId != 2)
            {
                btnUpdate.Enabled = false;
                tbName.Enabled = false;
                tbPrice.Enabled = false;
            }
        }

        public void InitializeLightTheme()
        {
            BackColor = Color.White;

            btnReturn.BackColor = SystemColors.ButtonShadow;
            btnUpdate.BackColor = SystemColors.ButtonShadow;

            tbName.BackColor = Color.Gainsboro;
            tbPrice.BackColor = Color.Gainsboro;

            lblTextId.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextId.ForeColor = Color.Red;

            tbName.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.Red;

            lblTextCategory.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextCategory.ForeColor = Color.Red;

            lblTextUnit.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextUnit.ForeColor = Color.Red;

            lblTextStock.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextStock.ForeColor = Color.Red;

            tbPrice.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPrice.ForeColor = Color.Red;


            lblArticleName.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArticleName.ForeColor = SystemColors.ControlText;

            lblBarcode.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = SystemColors.ControlText;

            lblCategory.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ControlText;

            lblMeasurementUnit.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeasurementUnit.ForeColor = SystemColors.ControlText;

            lblStock.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = SystemColors.ControlText;

            lblPrice.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ControlText;

        }

        public void InitializeDarkTheme()
        {
            BackColor = SystemColors.ControlDarkDark;

            btnReturn.BackColor = SystemColors.ScrollBar;
            btnUpdate.BackColor = SystemColors.ScrollBar;

            tbName.BackColor = SystemColors.MenuBar;
            tbPrice.BackColor = SystemColors.MenuBar;

            lblTextId.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextId.ForeColor = Color.LightPink;

            tbName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.LightPink;

            lblTextCategory.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextCategory.ForeColor = Color.LightPink;

            lblTextUnit.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextUnit.ForeColor = Color.LightPink;

            lblTextStock.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextStock.ForeColor = Color.LightPink;

            tbPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPrice.ForeColor = Color.LightPink;

            lblArticleName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArticleName.ForeColor = SystemColors.Control;

            lblBarcode.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = SystemColors.Control;

            lblCategory.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.Control;

            lblMeasurementUnit.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeasurementUnit.ForeColor = SystemColors.Control;

            lblStock.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = SystemColors.Control;

            lblPrice.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.Control;

        }

        public void InitializeBlueTheme()
        {
            BackColor = Color.LightBlue;

            btnReturn.BackColor = SystemColors.ActiveCaption;
            btnUpdate.BackColor = SystemColors.ActiveCaption;

            tbName.BackColor = Color.Azure;
            tbPrice.BackColor = Color.Azure;


            lblTextId.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextId.ForeColor = Color.Red;

            tbName.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.Red;

            lblTextCategory.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextCategory.ForeColor = Color.Red;

            lblTextUnit.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextUnit.ForeColor = Color.Red;

            lblTextStock.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextStock.ForeColor = Color.Red;

            tbPrice.Font = new Font("Candara", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPrice.ForeColor = Color.Red;

            lblArticleName.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArticleName.ForeColor = Color.MidnightBlue;

            lblBarcode.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = Color.MidnightBlue;

            lblCategory.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.MidnightBlue;

            lblMeasurementUnit.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeasurementUnit.ForeColor = Color.MidnightBlue;

            lblStock.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.MidnightBlue;

            lblPrice.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.MidnightBlue;

        }

        private void InitializeLanguage()
        {
            switch (employee.Language)
            {
                case "Serbian(LAT)":
                    toolTip.SetToolTip(btnReturn, "Povratak nazad");
                    toolTip.SetToolTip(btnUpdate, "Sacuvaj izmjene");
                    lblArticleName.Text = "Naziv artikla: ";
                    lblBarcode.Text = "Barkod: ";
                    lblCategory.Text = "Kategorija(id): ";
                    lblMeasurementUnit.Text = "Mjerna jedinica: ";
                    lblStock.Text = "Zalihe: ";
                    lblPrice.Text = "Cijena: ";
                    this.Text = "Informacije o artiklu";
                    break;
                default:
                    toolTip.SetToolTip(btnReturn, "Return");
                    toolTip.SetToolTip(btnUpdate, "Save");
                    lblArticleName.Text = "Description: ";
                    lblBarcode.Text = "Barcode: ";
                    lblCategory.Text = "Category(id): ";
                    lblMeasurementUnit.Text = "Measurement unit: ";
                    lblStock.Text = "Stock: ";
                    lblPrice.Text = "Price: ";
                    this.Text = "Item info";
                    break;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitializeImage()
        {
            string imagePath = Directory.GetCurrentDirectory() + "\\images\\item\\" + product.Image;
            MemoryStream ms = new MemoryStream();
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                fs.CopyTo(ms);
            }
            pbArticle.Image = new Bitmap(ms);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlProduct mySqlProduct = new MySqlProduct();
            bool update = false;
            if (!tbName.Text.Equals(product.Name))
            {
                //update name
                mySqlProduct.UpdateName(product, tbName.Text);
                this.product.Name = tbName.Text;
                update = true;
            }
            else
            {
                tbName.Text = product.Name;
            }
            if (Decimal.Parse(tbPrice.Text) != product.Price)
            {
                //update name
                mySqlProduct.UpdatePrice(product, Decimal.Parse(tbPrice.Text));
                this.product.Price = Decimal.Parse(tbPrice.Text);
                update = true;
            }
            else
            {
                tbPrice.Text = product.Price.ToString();
            }
            if (update)
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Uspješno izvršene izmjene!" : "Update successful!", "Serbian(LAT)".Equals(employee.Language) ? "Informacija" : "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.warehouse.ShowAllArticles();
            }

        
        }
    }
}


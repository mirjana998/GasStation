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
    public partial class WarehouseForm : Form
    {
        public Employee employee { get; set; }

        public ToolTip toolTip { get; set; }

        List<Product> products { get; set; }
        public WarehouseForm()
        {
            InitializeComponent();
            employee = new Employee();
            toolTip = new ToolTip();
            InitializeLightTheme();
            InitializeLanguage();
           

        }

        public WarehouseForm(Employee employee)
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
            ShowAllArticles();
        }

        public void InitializeLightTheme()
        {
            //Color 
            BackColor = Color.White;

            btnCancel.BackColor = SystemColors.ButtonShadow;

            tbBarcode.BackColor = Color.Gainsboro;
            tbArticleName.BackColor = Color.Gainsboro;

            //Font and ForeColor
            lblSearchId.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchId.ForeColor = SystemColors.ControlText;
            lblSearchName.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchName.ForeColor = SystemColors.ControlText;
            lblUsername.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ControlText;


            tbBarcode.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbArticleName.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvProducts.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        public void InitializeDarkTheme()
        {
            //Color 
            BackColor = SystemColors.ControlDarkDark;

            btnCancel.BackColor = SystemColors.ScrollBar;

            tbBarcode.BackColor = SystemColors.MenuBar;
            tbArticleName.BackColor = SystemColors.MenuBar;

            //Font and ForeColor
            lblSearchId.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchId.ForeColor = SystemColors.Control;
            lblSearchName.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchName.ForeColor = SystemColors.Control;
            lblUsername.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.Control;

            tbBarcode.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbArticleName.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvProducts.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        public void InitializeBlueTheme()
        {
            //Color 
            BackColor = Color.LightBlue;

            btnCancel.BackColor = SystemColors.ActiveCaption;

            tbBarcode.BackColor = Color.Azure;
            tbArticleName.BackColor = Color.Azure;

            //Font and ForeColor
            lblSearchId.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchId.ForeColor = Color.MidnightBlue;
            lblSearchName.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchName.ForeColor = Color.MidnightBlue;
            lblUsername.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.MidnightBlue;

            tbBarcode.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbArticleName.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvProducts.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        public void InitializeLanguage()
        {

            switch (employee.Language)
            {
                case "Serbian(LAT)":
                    toolTip.SetToolTip(btnCancel, "Vrati se nazad");
                    lblSearchId.Text = "Barkod: ";
                    lblSearchName.Text = "Naziv artikla: ";
                    lvProducts.Columns[0].Text = "Barkod";
                    lvProducts.Columns[1].Text = "Naziv artikla";
                    lvProducts.Columns[2].Text = "Zaliha";
                    lvProducts.Columns[3].Text = "Cijena";
                    lblUsername.Text = "Korisničko ime: " + employee.Username;
                    this.Text = "Magacin";
                    break;
                default:
                    toolTip.SetToolTip(btnCancel, "Return");
                    lblSearchId.Text = "Barcode: ";
                    lblSearchName.Text = "Description: ";
                    lvProducts.Columns[0].Text = "Barcode";
                    lvProducts.Columns[1].Text = "Description";
                    lvProducts.Columns[2].Text = "Stock";
                    lvProducts.Columns[3].Text = "Price";
                    lblUsername.Text = "Username: " + employee.Username;
                    this.Text = "Warehouse";
                    break;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowAllArticles();
        }

        public void ShowAllArticles()
        {
            lvProducts.Items.Clear();
            MySqlProduct mySqlProduct = new MySqlProduct();
            products = mySqlProduct.GetProducts();
            foreach (Product product in products)
            {
                ListViewItem listViewItem = new ListViewItem(product.ProductId.ToString());
                listViewItem.SubItems.Add(product.Name);
                listViewItem.SubItems.Add(product.Stock.ToString());
                listViewItem.SubItems.Add(product.Price.ToString());
                lvProducts.Items.Add(listViewItem);
            }
        }

        private void lvProducts_ItemActivate(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvProducts.SelectedItems[0];
                int barcode = int.Parse(selectedItem.SubItems[0].Text);
                MySqlProduct mySqlProduct = new MySqlProduct();
                Product product = mySqlProduct.GetProductById(barcode);
                if (product != null && product.ProductId == barcode)
                {
                    ProductDetailsForm productDetailsForm = new ProductDetailsForm(product, this.employee,this);
                    productDetailsForm.Show();
                }
            }
        }

        private void tbBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            lvProducts.Items.Clear();
            string barcode = String.Empty;
            string input = tbBarcode.Text;
            if(input.All(char.IsDigit))
            {
                barcode = tbBarcode.Text;
            }
            bool exist = false;
            if (String.IsNullOrEmpty(barcode))
            {
                ShowAllArticles();
            }
            else
            {
                foreach (Product product in products)
                {
                    if (product.ProductId == int.Parse(barcode))
                    {
                        exist = true;
                        ListViewItem listViewItem = new ListViewItem(barcode);
                        listViewItem.SubItems.Add(product.Name);
                        listViewItem.SubItems.Add(product.Stock.ToString());
                        listViewItem.SubItems.Add(product.Price.ToString());
                        lvProducts.Items.Add(listViewItem);
                    }
                }
                if (!exist)
                {
                    ShowAllArticles();
                }
            }
        }

        private void tbArticleName_KeyUp(object sender, KeyEventArgs e)
        {
            lvProducts.Items.Clear();
            string articleName = tbArticleName.Text;
            bool exist = false;
            if (String.IsNullOrEmpty(articleName))
            {
                ShowAllArticles();
            }
            else
            {
                foreach (Product product in products)
                {
                    if (product.Name.Contains(articleName))
                    {
                        exist = true;
                        ListViewItem listViewItem = new ListViewItem(product.ProductId.ToString());
                        listViewItem.SubItems.Add(product.Name);
                        listViewItem.SubItems.Add(product.Stock.ToString());
                        listViewItem.SubItems.Add(product.Price.ToString());
                        lvProducts.Items.Add(listViewItem);
                    }
                }
                if (!exist)
                {
                    ShowAllArticles();
                }
            }
        }

    }
}

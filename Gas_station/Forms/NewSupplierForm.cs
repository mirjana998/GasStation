using Gas_station.DataAccess.MySql;
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

namespace Gas_station.Forms
{
    public partial class NewSupplierForm : Form
    {
        public Employee employee { get; set; }
        public ToolTip toolTip { get; set; }
        public List<Supplier> suppliers { get; set; }

        public AccountantForm accountant { get; set; }

        public NewSupplierForm()
        {
            InitializeComponent();
            employee = new Employee();
            toolTip = new ToolTip();
            InitializeLightTheme();
            InitializeLanguage();
        }


        public NewSupplierForm(Employee employee, AccountantForm accountant)
        {
            InitializeComponent();
            this.employee = employee;
            this.accountant = accountant;
            toolTip = new ToolTip();
            switch (employee.ThemeId)
            {
                case 2: InitializeDarkTheme(); break;
                case 3: InitializeBlueTheme(); break;
                default: InitializeLightTheme(); break;
            }
            InitializeLanguage();

        }

        public void InitializeDarkTheme()
        {
            BackColor = SystemColors.ControlDarkDark;

            btnReturn.BackColor = SystemColors.ScrollBar;
            btnImage.BackColor = SystemColors.ScrollBar;
            btnSave.BackColor = SystemColors.ScrollBar;

            tbName.BackColor = SystemColors.MenuBar;
            tbEmail.BackColor = SystemColors.MenuBar;
            tbAddress.BackColor = SystemColors.MenuBar;
            tbChosenImage.BackColor = SystemColors.MenuBar;

            //Font and ForeColor
            lblName.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.Control;
            lblEmail.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.Control;
            lblAddress.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.Control;
            lblImage.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImage.ForeColor = SystemColors.Control;
            lblCreateNew.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNew.ForeColor = SystemColors.Control;


            tbName.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbChosenImage.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);

        }

        public void InitializeLightTheme()
        {
            BackColor = Color.White;

            btnReturn.BackColor = SystemColors.ButtonShadow;
            btnImage.BackColor = SystemColors.ButtonShadow;
            btnSave.BackColor = SystemColors.ButtonShadow;

            tbName.BackColor = Color.Gainsboro;
            tbEmail.BackColor = Color.Gainsboro;
            tbChosenImage.BackColor = Color.Gainsboro;
            tbAddress.BackColor = Color.Gainsboro;

            //Font and ForeColor
            lblName.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ControlText;
            lblEmail.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblAddress.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlText;
            lblImage.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImage.ForeColor = SystemColors.ControlText;
            lblCreateNew.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNew.ForeColor = SystemColors.ControlText;


            tbName.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbChosenImage.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);

        }

        public void InitializeBlueTheme()
        {
            BackColor = Color.LightBlue;

            btnReturn.BackColor = SystemColors.ActiveCaption;
            btnImage.BackColor = SystemColors.ActiveCaption;
            btnSave.BackColor = SystemColors.ActiveCaption;

            tbName.BackColor = Color.Azure;
            tbEmail.BackColor = Color.Azure;
            tbChosenImage.BackColor = Color.Azure;
            tbAddress.BackColor = Color.Azure;

            //Font and ForeColor
            lblName.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.MidnightBlue;
            lblEmail.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.MidnightBlue;
            lblAddress.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.MidnightBlue;
            lblImage.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImage.ForeColor = Color.MidnightBlue;
            lblCreateNew.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNew.ForeColor = Color.MidnightBlue;


            tbName.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbChosenImage.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        public void InitializeLanguage()
        {
            switch (employee.Language)
            {
                case "Serbian(LAT)":
                    toolTip.SetToolTip(btnReturn, "Vrati se nazad");
                    toolTip.SetToolTip(btnImage, "Odaberi sliku");
                    toolTip.SetToolTip(btnSave, "Sačuvaj dobavljača");
                    lblName.Text = "Ime: ";
                    lblEmail.Text = "Email: ";
                    lblAddress.Text = "Adresa: ";
                    lblImage.Text = "Odaberite sliku: ";
                    lblCreateNew.Text = "Novi dobavljač";
                    this.Text = "Novi dobavljač";
                    break;
                default:
                    toolTip.SetToolTip(btnReturn, "Return");
                    toolTip.SetToolTip(btnImage, "Choose image");
                    toolTip.SetToolTip(btnSave, "Save item");
                    lblName.Text = "Name: ";
                    lblEmail.Text = "Email: ";
                    lblAddress.Text = "Address: ";
                    lblImage.Text = "Choose image: ";
                    lblCreateNew.Text = "New supplier";
                    this.Text = "New supplier";
                    break;
            }
        }

        public void InitializeSuppliers()
        {
            MySqlSupplier mySqlSupplier = new MySqlSupplier();
            suppliers = mySqlSupplier.GetSuppliers();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            InitializeSuppliers();
            Supplier supplier = new Supplier();
            if (suppliers.Count > 0)
            {
                supplier.SupplierId = suppliers.Count() + 1;
            }
            else
            {
                supplier.SupplierId = 1;
            }
            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbAddress.Text) ||  String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(tbChosenImage.Text))
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Nepopunjena polja!" : "Missing fields!", "Serbian(LAT)".Equals(employee.Language) ? "Greska" : "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                supplier.Name = tbName.Text;
                supplier.Address = tbAddress.Text;
                supplier.Email = tbEmail.Text;
                supplier.Image = tbChosenImage.Text;
                MySqlSupplier mySqlSupplier = new MySqlSupplier();
                mySqlSupplier.Insert(supplier);
                suppliers.Add(supplier);
                this.accountant.InitializeSupplierList();
            }
           
        }
    }
}

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
    public partial class SupplierDetailsForm : Form
    {

        public Employee employee { get; set; }

        public ToolTip toolTip { get; set; }

        public Supplier supplier { get; set; }

        public AccountantForm accountant { get; set; }
        public SupplierDetailsForm()
        {
            InitializeComponent();
        }

        public SupplierDetailsForm(Supplier supplier, Employee employee, AccountantForm accountant)
        {
            InitializeComponent();
            this.supplier = supplier;
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
            lblTextId.Text = supplier.SupplierId.ToString();
            tbName.Text = supplier.Name;
            tbEmail.Text = supplier.Email;
            tbAddress.Text = supplier.Address;
            InitializeImage();
            this.accountant = accountant;
        }

        public void InitializeLightTheme()
        {
            BackColor = Color.White;

            btnReturn.BackColor = SystemColors.ButtonShadow;
            btnUpdate.BackColor = SystemColors.ButtonShadow;


            tbName.BackColor = Color.Gainsboro;
            tbAddress.BackColor = Color.Gainsboro;
            tbEmail.BackColor = Color.Gainsboro;

            lblTextId.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextId.ForeColor = Color.Red;

            tbName.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.Red;

            tbAddress.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAddress.ForeColor = Color.Red;

            tbEmail.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.Red;


            lblId.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.ControlText;

            lblName.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ControlText;

            lblAddress.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlText;

            lblEmail.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlText;

        }

        public void InitializeDarkTheme()
        {
            BackColor = SystemColors.ControlDarkDark;

            btnReturn.BackColor = SystemColors.ScrollBar;
            btnUpdate.BackColor = SystemColors.ScrollBar;

            tbName.BackColor = SystemColors.MenuBar;
            tbAddress.BackColor = SystemColors.MenuBar;
            tbEmail.BackColor = SystemColors.MenuBar;

            lblTextId.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextId.ForeColor = Color.LightPink;

            tbName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.LightPink;

            tbEmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.LightPink;

            tbAddress.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAddress.ForeColor = Color.LightPink;

            lblId.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.Control;

            lblName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.Control;

            lblEmail.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.Control;

            lblAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.Control;

        }

        public void InitializeBlueTheme()
        {
            BackColor = Color.LightBlue;

            btnReturn.BackColor = SystemColors.ActiveCaption;
            btnUpdate.BackColor = SystemColors.ActiveCaption;

            tbName.BackColor = Color.Azure;
            tbAddress.BackColor = Color.Azure;
            tbEmail.BackColor = Color.Azure;

            lblTextId.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextId.ForeColor = Color.Red;

            tbName.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.Red;


            tbEmail.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.Red;

            tbAddress.Font = new Font("Candara", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAddress.ForeColor = Color.Red;

            lblId.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.MidnightBlue;

            lblName.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.MidnightBlue;

            lblEmail.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.MidnightBlue;

            lblAddress.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.MidnightBlue;

        }

        private void InitializeLanguage()
        {
            switch (employee.Language)
            {
                case "Serbian(LAT)":
                    toolTip.SetToolTip(btnReturn, "Povratak nazad");
                    lblId.Text = "Id: ";
                    lblName.Text = "Naziv: ";
                    lblEmail.Text = "Email: ";
                    lblAddress.Text = "Adresa: ";
                    this.Text = "Informacije o dobavljaču ";
                    break;
                default:
                    toolTip.SetToolTip(btnReturn, "Return");
                    lblId.Text = "Id: ";
                    lblName.Text = "Name: ";
                    lblEmail.Text = "Email: ";
                    lblAddress.Text = "Address: ";
                    this.Text = "Supplier info ";
                    break;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitializeImage()
        {
            string imagePath = Directory.GetCurrentDirectory() + "\\images\\supplier\\" + supplier.Image;
            MemoryStream ms = new MemoryStream();
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                fs.CopyTo(ms);
            }
            pbSupplier.Image = new Bitmap(ms);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlSupplier mySqlSupplier = new MySqlSupplier();
            bool update = false;
            if(!tbName.Text.Equals(supplier.Name))
            {
                //update name
                mySqlSupplier.UpdateName(supplier, tbName.Text);
                this.supplier.Name = tbName.Text;
                update = true;
            }
            else
            {
                tbName.Text = supplier.Name;    
            }
            if (!tbEmail.Text.Equals(supplier.Email))
            {
                //update email
                mySqlSupplier.UpdateEmail(supplier, tbEmail.Text);
                this.supplier.Email = tbEmail.Text;
                update = true;
            }
            else
            {
                tbEmail.Text = supplier.Email;
            }
            if (!tbAddress.Text.Equals(supplier.Address))
            {
                //update name
                mySqlSupplier.UpdateAddress(supplier, tbAddress.Text);
                this.supplier.Address = tbAddress.Text;
                update = true;
            }
            else
            {
                tbAddress.Text = supplier.Address;
            }
            if (update)
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Uspješno izvršene izmjene!" : "Update successful!", "Serbian(LAT)".Equals(employee.Language) ? "Informacija" : "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.accountant.InitializeSupplierList();
            }
           
        }
    }
}

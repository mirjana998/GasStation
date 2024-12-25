using Gas_station.DataAccess.MySql;
using Gas_station.Model;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gas_station.Forms
{
    public partial class AuthenticationForm : Form
    {
        public Employee employee { get; set; }
        public StoreForm? store { get; set; }
        public AccountantForm? accountant { get; set; }
        public ToolTip toolTip { get; set; }
        public AuthenticationForm()
        {
            InitializeComponent();
            employee = new Employee();
            toolTip = new ToolTip();
            store = new StoreForm();
            accountant = new AccountantForm();
            InitializeLightTheme();
            InitializeLanguage();
        }

        public AuthenticationForm(Employee employee, StoreForm store, AccountantForm accountant)
        {
            InitializeComponent();
            this.employee = new Employee(employee);
            toolTip = new ToolTip();
            switch (this.employee.ThemeId)
            {
                case 2: InitializeDarkTheme(); break;
                case 3: InitializeBlueTheme(); break;
                default: InitializeLightTheme(); break;
            }
            InitializeLanguage();
            this.store = store;
            this.accountant = accountant;
        }

        private void InitializeLightTheme()
        {
            BackColor = Color.White;
            Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);

            lblEnterPassword.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterPassword.ForeColor = SystemColors.ControlText;

            tbPassword.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.BackColor = Color.Gainsboro;
            tbPassword.ForeColor = SystemColors.ControlText;


            btnReturn.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.BackColor = SystemColors.ButtonShadow;
            btnReturn.ForeColor = SystemColors.ControlText;

            btnConfirm.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.BackColor = SystemColors.ButtonShadow;
            btnConfirm.ForeColor = SystemColors.ControlText;

            btnSee.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSee.BackColor = SystemColors.ButtonShadow;
            btnSee.ForeColor = SystemColors.ControlText;

        }

        private void InitializeDarkTheme()
        {
            BackColor = SystemColors.ControlDarkDark;

            lblEnterPassword.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterPassword.ForeColor = SystemColors.Control;

            tbPassword.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.BackColor = SystemColors.MenuBar;
            tbPassword.ForeColor = SystemColors.ControlText;

            btnReturn.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.BackColor = SystemColors.ScrollBar;
            btnReturn.ForeColor = SystemColors.ControlText;

            btnConfirm.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.BackColor = SystemColors.ScrollBar;
            btnConfirm.ForeColor = SystemColors.ControlText;

            btnSee.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSee.BackColor = SystemColors.ScrollBar;
            btnSee.ForeColor = SystemColors.ControlText;

        }

        private void InitializeBlueTheme()
        {
            BackColor = Color.LightBlue;

            lblEnterPassword.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterPassword.ForeColor = Color.MidnightBlue;

            tbPassword.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.BackColor = Color.Azure;
            tbPassword.ForeColor = SystemColors.ControlText;

            btnReturn.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.BackColor = SystemColors.ActiveCaption;
            btnReturn.ForeColor = SystemColors.ControlText;

            btnConfirm.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.BackColor = SystemColors.ActiveCaption;
            btnConfirm.ForeColor = SystemColors.ControlText;


            btnSee.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSee.BackColor = SystemColors.ActiveCaption;
            btnSee.ForeColor = SystemColors.ControlText;
        }

        private void InitializeLanguage()
        {
            switch(this.employee.Language)
            {
                case "Serbian(LAT)":
                    toolTip.SetToolTip(btnSee, "Prikaži lozinku");
                    toolTip.SetToolTip(btnReturn, "Povratak nazad");
                    toolTip.SetToolTip(btnConfirm, "Potvrdi lozinku");
                    lblEnterPassword.Text = "Molimo Vas unesite lozinku: ";
                    this.Text = "Autentikacija";
                    break;
                default:
                    toolTip.SetToolTip(btnSee, "Show password");
                    toolTip.SetToolTip(btnReturn, "Return");
                    toolTip.SetToolTip(btnConfirm, "Confirm password");
                    lblEnterPassword.Text = "Please enter password: ";
                    this.Text = "Authentication";
                    break;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Nedostaje lozinka!" : "Password missing!", "Serbian(LAT)".Equals(employee.Language) ? "Upozorenje" : "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlEmployee mySqlEmployee = new MySqlEmployee();
                Employee employee = mySqlEmployee.GetEmployeeByUsernameAndPassword(this.employee.Username, password);
                if (employee != null && employee.IsEmployed)
                {
                    UserSettingsForm userSettingsForm = new UserSettingsForm(employee,this.store, this.accountant);
                    userSettingsForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Neispravna lozinka!" : "Incorrect password!", "Serbian(LAT)".Equals(employee.Language) ? "Greška" : "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }
    }
}

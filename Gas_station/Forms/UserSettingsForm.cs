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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gas_station.Forms
{
    public partial class UserSettingsForm : Form
    {
        public Employee employee { get; set; }
        public StoreForm store { get; set; }
        public AccountantForm accountant { get; set; }
        
        public ToolTip toolTip { get; set; }
        public UserSettingsForm()
        {
            InitializeComponent();
            employee = new Employee();
            InitializeLightTheme();
            InitializeLanguage();
            toolTip = new ToolTip();
        }

        public UserSettingsForm(Employee employee, StoreForm store, AccountantForm accountant)
        {
            InitializeComponent();
            this.employee = new Employee(employee);
            switch (this.employee.ThemeId)
            {
                case 2: InitializeDarkTheme(); break;
                case 3: InitializeBlueTheme(); break;
                default: InitializeLightTheme(); break;
            }
            toolTip = new ToolTip();
            InitializeLanguage();
            this.store = store;
            this.accountant = accountant;
            cbLanguage.SelectedItem = this.employee.Language;
            cbTheme.SelectedIndex = this.employee.ThemeId - 1;
        }

        private void btnSeeNewPassword_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.PasswordChar == '*')
            {
                tbNewPassword.PasswordChar = '\0';
            }
            else
            {
                tbNewPassword.PasswordChar = '*';
            }
        }

        private void btnSeeConfirmPassword_Click(object sender, EventArgs e)
        {
            if (tbConfirmPassword.PasswordChar == '*')
            {
                tbConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                tbConfirmPassword.PasswordChar = '*';
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = tbNewPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();
            if(String.IsNullOrEmpty(newPassword) || (String.IsNullOrEmpty(confirmPassword))) {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Prazna polja!" : "Missing fields!", "Serbian(LAT)".Equals(employee.Language) ? "Greška!" : "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (newPassword.Equals(confirmPassword))
                {
                    MySqlEmployee mySqlEmployee = new MySqlEmployee();
                    mySqlEmployee.UpdateEmployeePassword(employee, newPassword);
                    employee.Password = confirmPassword;
                    if (this.store != null)
                    {
                        this.store.employee.Password = confirmPassword;
                    }
                    if (this.accountant != null)
                    {
                        this.accountant.employee.Password = confirmPassword;
                    }
                    MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Lozinka uspješno izmjenjena!" : "Passwords succesfuly changed!", "Serbian(LAT)".Equals(employee.Language) ? "Informacija" : "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Lozinke se ne poklapaju!" : "Passwords don't match!", "Serbian(LAT)".Equals(employee.Language) ? "Greška!" : "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btnUpdateTheme_Click(object sender, EventArgs e)
        {
            string theme = cbTheme.Text.Trim();
            int theme_id = 0;

            if (!string.IsNullOrEmpty(theme))
            {
                MySqlEmployee mySqlEmployee = new MySqlEmployee();
                switch (theme)
                {
                    case "dark": theme_id = 2;
                        if (this.store != null)
                        {
                            this.store.InitializeDarkTheme();
                        }
                        if (this.accountant != null)
                        {
                            this.accountant.InitializeDarkTheme();
                        }
                        this.InitializeDarkTheme();
                        break;
                    case "blue": theme_id = 3;
                        if (this.store != null)
                        {
                            this.store.InitializeBlueTheme();
                        }
                        if (this.accountant != null)
                        {
                            this.accountant.InitializeBlueTheme();
                        }
                        this.InitializeBlueTheme();
                        break;
                    default: theme_id = 1;
                        if (this.store != null)
                        {
                            this.store.InitializeLightTheme();
                        }
                        if (this.accountant != null)
                        {
                            this.accountant.InitializeLightTheme();
                        }
                        this.InitializeLightTheme();
                        break;
                }
                mySqlEmployee.UpdateEmployeeTheme(employee, theme_id);
                employee.ThemeId = theme_id;
                if(this.store != null)
                {
                    this.store.employee.ThemeId = theme_id;
                }
                if (this.accountant != null)
                {
                    this.accountant.employee.ThemeId = theme_id;
                }

                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Tema uspješno izmijenjena!" : "Theme succesfuly changed!", "Serbian(LAT)".Equals(employee.Language) ? "Informacija" : "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Tema nije odabrana!" : "Theme not selected!", "Serbian(LAT)".Equals(employee.Language) ? "Greška" : "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateLanguage_Click(object sender, EventArgs e)
        {
            string language = cbLanguage.Text.Trim();

            if (!string.IsNullOrEmpty(language))
            {
                
                MySqlEmployee mySqlEmployee = new MySqlEmployee();
                mySqlEmployee.UpdateEmployeeLanguage(employee, language);
                employee.Language = language;
                this.InitializeLanguage();
                if (this.store != null)
                {
                    this.store.employee.Language = language;
                    this.store.InitializeLanguage();
                }
                if (this.accountant != null)
                {
                    this.accountant.employee.Language = language;
                    this.accountant.InitializeLanguage();
                }

                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Jezik uspješno promijenjen!" : "Language succesfuly changed!", "Serbian(LAT)".Equals(employee.Language) ? "Informacija" : "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Jezik nije odabran!" : "Language not selected!", "Serbian(LAT)".Equals(employee.Language) ? "Greška": "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeLightTheme()
        {
            //Form collor
            BackColor = Color.White;

            //Font and ForeColor
            lblAccountSettings.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountSettings.ForeColor = SystemColors.ControlText;

            lblUser.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.ControlText;

            lblPassword.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ControlText;

            lblConfirmPassword.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = SystemColors.ControlText;

            lblTheme.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTheme.ForeColor = SystemColors.ControlText;

            lblLanguage.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLanguage.ForeColor = SystemColors.ControlText;

            tbNewPassword.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNewPassword.ForeColor = SystemColors.ControlText;
            tbNewPassword.BackColor = Color.Gainsboro;

            tbConfirmPassword.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConfirmPassword.ForeColor = SystemColors.ControlText;
            tbConfirmPassword.BackColor = Color.Gainsboro;

            cbTheme.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTheme.ForeColor = SystemColors.ControlText;
            cbTheme.BackColor = Color.Gainsboro;

            cbLanguage.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLanguage.ForeColor = SystemColors.ControlText;
            cbLanguage.BackColor = Color.Gainsboro;

            btnSeeNewPassword.BackColor = SystemColors.ButtonShadow; 
            btnSeeConfirmPassword.BackColor = SystemColors.ButtonShadow; 
            btnUpdatePassword.BackColor = SystemColors.ButtonShadow; 
            btnUpdateTheme.BackColor = SystemColors.ButtonShadow; 
            btnUpdateLanguage.BackColor = SystemColors.ButtonShadow; 
            btnCancel.BackColor = SystemColors.ButtonShadow; 

        }

        private void InitializeDarkTheme()
        {
            //Form collor
            BackColor = SystemColors.ControlDarkDark;

            //Font and ForeColor
            lblAccountSettings.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountSettings.ForeColor = SystemColors.Control;

            lblUser.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.Control;

            lblPassword.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.Control;

            lblConfirmPassword.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = SystemColors.Control;

            lblTheme.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTheme.ForeColor = SystemColors.Control;

            lblLanguage.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLanguage.ForeColor = SystemColors.Control;

            tbNewPassword.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNewPassword.ForeColor = SystemColors.ControlText;
            tbNewPassword.BackColor = SystemColors.MenuBar;

            tbConfirmPassword.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConfirmPassword.ForeColor = SystemColors.ControlText;
            tbConfirmPassword.BackColor = SystemColors.MenuBar;

            cbTheme.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTheme.ForeColor = SystemColors.ControlText;
            cbTheme.BackColor = SystemColors.MenuBar;

            cbLanguage.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLanguage.ForeColor = SystemColors.ControlText;
            cbLanguage.BackColor = SystemColors.MenuBar;

            btnSeeNewPassword.BackColor = SystemColors.ScrollBar;
            btnSeeConfirmPassword.BackColor = SystemColors.ScrollBar;
            btnUpdatePassword.BackColor = SystemColors.ScrollBar;
            btnUpdateTheme.BackColor = SystemColors.ScrollBar;
            btnUpdateLanguage.BackColor = SystemColors.ScrollBar;
            btnCancel.BackColor = SystemColors.ScrollBar;

        }

        private void InitializeBlueTheme()
        {
            //Form collor
            BackColor = Color.LightBlue;

            //Font and ForeColor
            lblAccountSettings.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountSettings.ForeColor = Color.MidnightBlue;

            lblUser.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.MidnightBlue;

            lblPassword.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.MidnightBlue;

            lblConfirmPassword.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.MidnightBlue;

            lblTheme.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTheme.ForeColor = Color.MidnightBlue;

            lblLanguage.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLanguage.ForeColor = Color.MidnightBlue;

            tbNewPassword.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNewPassword.ForeColor = SystemColors.ControlText;
            tbNewPassword.BackColor = Color.Azure;

            tbConfirmPassword.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConfirmPassword.ForeColor = SystemColors.ControlText;
            tbConfirmPassword.BackColor = Color.Azure;

            cbTheme.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTheme.ForeColor = SystemColors.ControlText;
            cbTheme.BackColor = Color.Azure;

            cbLanguage.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLanguage.ForeColor = SystemColors.ControlText;
            cbLanguage.BackColor = Color.Azure;

            btnSeeNewPassword.BackColor = SystemColors.ActiveCaption;
            btnSeeConfirmPassword.BackColor = SystemColors.ActiveCaption;
            btnUpdatePassword.BackColor = SystemColors.ActiveCaption;
            btnUpdateTheme.BackColor = SystemColors.ActiveCaption;
            btnUpdateLanguage.BackColor = SystemColors.ActiveCaption;
            btnCancel.BackColor = SystemColors.ActiveCaption;

        }

        private void InitializeLanguage()
        {
            this.Invalidate();
            switch (employee.Language)
            {
                case "Serbian(LAT)":
                    toolTip.SetToolTip(btnSeeNewPassword, "Prikaz lozinke");
                    toolTip.SetToolTip(btnSeeConfirmPassword, "Prikaz lozinke");
                    toolTip.SetToolTip(btnUpdatePassword, "Potvrda promjene lozinke");
                    toolTip.SetToolTip(btnUpdateTheme, "Potvrda promjene teme");
                    toolTip.SetToolTip(btnUpdateLanguage, "Potvrda promjene jezika");
                    toolTip.SetToolTip(btnCancel, "Povratak nazad");
                    lblAccountSettings.Text = "Podešavanje korisničkog naloga:";
                    lblUser.Text = "Korisničko ime: " + employee.Username;
                    lblPassword.Text = "Nova lozinka:";
                    lblConfirmPassword.Text = "Potvrda lozinke:";
                    lblTheme.Text = "Promijeni temu:";
                    lblLanguage.Text = "Promijeni jezik:";
                    this.Text = "Podešavanja";
                    break;
                default:
                    toolTip.SetToolTip(btnSeeNewPassword, "Show password");
                    toolTip.SetToolTip(btnSeeConfirmPassword, "Show password");
                    toolTip.SetToolTip(btnUpdatePassword, "Update password");
                    toolTip.SetToolTip(btnUpdateTheme, "Update theme");
                    toolTip.SetToolTip(btnUpdateLanguage, "Update language");
                    toolTip.SetToolTip(btnCancel, "Return");
                    lblAccountSettings.Text = "Account settings:";
                    lblUser.Text = "Username: " + employee.Username;
                    lblPassword.Text = "New Password:";
                    lblConfirmPassword.Text = "Confirm password:";
                    lblTheme.Text = "Change theme:";
                    lblLanguage.Text = "Change language:";
                    this.Text = "Settings";
                    break;
            }
            this.Update();

        }

    }
}

using Gas_station.Forms;
using Gas_station.Model;
using System.Windows.Forms;
using Gas_station.DataAccess.MySql;

namespace Gas_station
{
    public partial class LoginForm : Form
    {
        public ToolTip toolTip {  get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            toolTip = new ToolTip();
            toolTip.SetToolTip(btnCancel, "Cancel");
            toolTip.SetToolTip(btnLogin, "Login");
            toolTip.SetToolTip(btnSee,"Show password");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password missing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlEmployee mySqlEmployee = new MySqlEmployee();
                Employee employee = mySqlEmployee.GetEmployeeByUsernameAndPassword(username, password);
                if (employee != null && employee.IsEmployed)
                {
                   switch(employee.RoleId)
                    {
                        case 2:
                            AccountantForm accountantForm = new AccountantForm(employee);
                            accountantForm.Show();
                            break;
                        default:
                            StoreForm storeForm = new StoreForm(employee);
                            storeForm.Show();
                            break;
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

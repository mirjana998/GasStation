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
    public partial class AccountantForm : Form
    {
        public Employee employee { get; set; }

        public ToolTip toolTip { get; set; }

        public List<Supplier> suppliers { get; set; }
        public AccountantForm()
        {
            InitializeComponent();
            employee = new Employee();
            toolTip = new ToolTip();
            InitializeLightTheme();
            InitializeLanguage();
            InitializeSupplierList();
        }

        public AccountantForm(Employee employee)
        {
            InitializeComponent();
            this.employee = new Employee(employee);
            this.toolTip = new ToolTip();
            switch (this.employee.ThemeId)
            {
                case 2: InitializeDarkTheme(); break;
                case 3: InitializeBlueTheme(); break;
                default: InitializeLightTheme(); break;
            }
            InitializeLanguage();
            InitializeSupplierList();
        }

        public void InitializeLightTheme()
        {
            BackColor = Color.White;

            btnNewSupplier.BackColor = SystemColors.ButtonShadow;
            btnNewItem.BackColor = SystemColors.ButtonShadow;
            btnWarehouse.BackColor = SystemColors.ButtonShadow;
            btnSettings.BackColor = SystemColors.ButtonShadow;
            btnLogout.BackColor = SystemColors.ButtonShadow;
            btnAdd.BackColor = SystemColors.ButtonShadow;
            btnConfirmInvoice.BackColor = SystemColors.ButtonShadow;
            btnRemove.BackColor = SystemColors.ButtonShadow;

            tbBarcode.BackColor = Color.Gainsboro;
            tbDescription.BackColor = Color.Gainsboro;
            tbQuantity.BackColor = Color.Gainsboro;
            cbPaymentType.BackColor = Color.Gainsboro;
            tbComment.BackColor = Color.Gainsboro;
            tbTotal.BackColor = Color.Gainsboro;
            lvSupplier.BackColor = Color.Gainsboro;
            lvItems.BackColor = Color.Gainsboro;

            //Font and ForeColor
            lblNewInvoice.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewInvoice.ForeColor = SystemColors.ControlText;
            lblUsername.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ControlText;
            lblBarcode.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = SystemColors.ControlText;
            lblDescription.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.ControlText;
            lblComment.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComment.ForeColor = SystemColors.ControlText;
            lblQuantity.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ControlText;
            lblPaymentType.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentType.ForeColor = SystemColors.ControlText;
            lblTotal.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ControlText;
            lblSupplier.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplier.ForeColor = SystemColors.ControlText;

            tbBarcode.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescription.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbComment.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPaymentType.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvItems.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvSupplier.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotal.Font = new Font("Sitka Banner", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        public void InitializeDarkTheme()
        {
            BackColor = SystemColors.ControlDarkDark;

            btnNewSupplier.BackColor = SystemColors.ScrollBar;
            btnNewItem.BackColor = SystemColors.ScrollBar;
            btnWarehouse.BackColor = SystemColors.ScrollBar;
            btnSettings.BackColor = SystemColors.ScrollBar;
            btnLogout.BackColor = SystemColors.ScrollBar;
            btnAdd.BackColor = SystemColors.ScrollBar;
            btnConfirmInvoice.BackColor = SystemColors.ScrollBar;
            btnRemove.BackColor = SystemColors.ScrollBar;

            tbBarcode.BackColor = SystemColors.MenuBar;
            tbDescription.BackColor = SystemColors.MenuBar;
            tbQuantity.BackColor = SystemColors.MenuBar;
            cbPaymentType.BackColor = SystemColors.MenuBar;
            tbComment.BackColor = SystemColors.MenuBar;
            tbTotal.BackColor = SystemColors.MenuBar;
            lvSupplier.BackColor = SystemColors.MenuBar;
            lvItems.BackColor = SystemColors.MenuBar;

            //Font and ForeColor
            lblNewInvoice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewInvoice.ForeColor = SystemColors.Control;
            lblUsername.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.Control;
            lblBarcode.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = SystemColors.Control;
            lblDescription.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.Control;
            lblComment.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComment.ForeColor = SystemColors.Control;
            lblQuantity.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.Control;
            lblPaymentType.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentType.ForeColor = SystemColors.Control;
            lblTotal.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.Control;
            lblSupplier.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplier.ForeColor = SystemColors.Control;

            tbBarcode.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescription.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbComment.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPaymentType.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvItems.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvSupplier.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotal.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        public void InitializeBlueTheme()
        {
            BackColor = Color.LightBlue;

            btnNewSupplier.BackColor = SystemColors.ActiveCaption;
            btnNewItem.BackColor = SystemColors.ActiveCaption;
            btnWarehouse.BackColor = SystemColors.ActiveCaption;
            btnSettings.BackColor = SystemColors.ActiveCaption;
            btnLogout.BackColor = SystemColors.ActiveCaption;
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnConfirmInvoice.BackColor = SystemColors.ActiveCaption;
            btnRemove.BackColor = SystemColors.ActiveCaption;

            tbBarcode.BackColor = Color.Azure;
            tbDescription.BackColor = Color.Azure;
            tbQuantity.BackColor = Color.Azure;
            cbPaymentType.BackColor = Color.Azure;
            tbComment.BackColor = Color.Azure;
            tbTotal.BackColor = Color.Azure;
            lvSupplier.BackColor = Color.Azure;
            lvItems.BackColor = Color.Azure;

            //Font and ForeColor
            lblNewInvoice.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewInvoice.ForeColor = Color.MidnightBlue;
            lblUsername.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.MidnightBlue;
            lblBarcode.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = Color.MidnightBlue;
            lblDescription.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.MidnightBlue;
            lblComment.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComment.ForeColor = Color.MidnightBlue;
            lblQuantity.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.MidnightBlue;
            lblPaymentType.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentType.ForeColor = Color.MidnightBlue;
            lblTotal.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.MidnightBlue;
            lblSupplier.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplier.ForeColor = Color.MidnightBlue;

            tbBarcode.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescription.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbComment.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPaymentType.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvItems.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvSupplier.Font = new Font("Candara", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotal.Font = new Font("Candara", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        public void InitializeLanguage()
        {

            switch (employee.Language)
            {
                case "Serbian(LAT)":
                    toolTip.SetToolTip(btnWarehouse, "Provjeri zalihe");
                    toolTip.SetToolTip(btnSettings, "Korisnička podešavanja");
                    toolTip.SetToolTip(btnLogout, "Odjavi se");
                    toolTip.SetToolTip(btnNewItem, "Novi artikal");
                    toolTip.SetToolTip(btnNewSupplier, "Novi dobavljač");
                    toolTip.SetToolTip(btnAdd, "Dodaj stavku");
                    toolTip.SetToolTip(btnConfirmInvoice, "Knjiženje");
                    toolTip.SetToolTip(btnRemove, "Ukloni stavku");
                    lblNewInvoice.Text = "Nova ulazna faktura:";
                    lblUsername.Text = "Korisničko ime: " + employee.Username;
                    lblBarcode.Text = "Barkod:";
                    lblDescription.Text = "Naziv artikla:";
                    lblQuantity.Text = "Količina: ";
                    lblPaymentType.Text = "Tip plaćanja: ";
                    lblComment.Text = "Komentar: ";
                    lblTotal.Text = "Ukupno: ";
                    lblSupplier.Text = "Odaberite dobavljača: ";
                    lvItems.Columns[0].Text = "Barkod";
                    lvItems.Columns[1].Text = "Naziv artikla";
                    lvItems.Columns[2].Text = "Količina";
                    lvItems.Columns[3].Text = "Cijena";
                    lvSupplier.Columns[0].Text = "Dobavljač(id)";
                    lvSupplier.Columns[1].Text = "Naziv dobavljača";
                    cbPaymentType.Items[0] = "Gotovina";
                    cbPaymentType.Items[1] = "Kartično";
                    this.Text = "Knjigovodstvo";
                    break;
                default:
                    toolTip.SetToolTip(btnWarehouse, "Check the stock");
                    toolTip.SetToolTip(btnSettings, "User settings");
                    toolTip.SetToolTip(btnLogout, "Logout");
                    toolTip.SetToolTip(btnNewItem, "New item");
                    toolTip.SetToolTip(btnNewSupplier, "New supplier");
                    toolTip.SetToolTip(btnAdd, "Add item");
                    toolTip.SetToolTip(btnConfirmInvoice, "Accounting entry");
                    toolTip.SetToolTip(btnRemove, "Remove item");
                    lblNewInvoice.Text = "New purchase invoice:";
                    lblUsername.Text = "Username: " + employee.Username;
                    lblBarcode.Text = "Barcode:";
                    lblDescription.Text = "Description: ";
                    lblQuantity.Text = "Quantity: ";
                    lblPaymentType.Text = "Payment type:";
                    lblComment.Text = "Comment: ";
                    lblTotal.Text = "Total: ";
                    lblSupplier.Text = "Choose supplier: ";
                    lvItems.Columns[0].Text = "Barcode";
                    lvItems.Columns[1].Text = "Description";
                    lvItems.Columns[2].Text = "Quantity";
                    lvItems.Columns[3].Text = "Price";
                    lvSupplier.Columns[0].Text = "Supplier(id)";
                    lvSupplier.Columns[1].Text = "Supplier name";
                    cbPaymentType.Items[0] = "Cash";
                    cbPaymentType.Items[1] = "Card";
                    this.Text = "Accounting";
                    break;
            }
        }

        public void InitializeSupplierList()
        {
            lvSupplier.Items.Clear();
            MySqlSupplier mySqlSupplier = new MySqlSupplier();
            suppliers = mySqlSupplier.GetSuppliers();
            if (suppliers.Count > 0)
            {
                foreach (Supplier supplier in suppliers)
                {
                    ListViewItem listViewItem = new ListViewItem(supplier.SupplierId.ToString());
                    listViewItem.SubItems.Add(supplier.Name);
                    lvSupplier.Items.Add(listViewItem);

                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            AuthenticationForm authenticationForm = new AuthenticationForm(employee, null, this);
            authenticationForm.Show();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm(employee);
            warehouseForm.Show();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            NewItemForm newItemForm = new NewItemForm(employee);
            newItemForm.Show();
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            NewSupplierForm newSupplierForm = new NewSupplierForm(employee, this);
            newSupplierForm.Show();
        }

        private void countTotal()
        {
            Decimal total = 0;
            if (lvItems.Items.Count > 0)
            {
                foreach (ListViewItem item in lvItems.Items)
                {
                    total += Decimal.Parse(item.SubItems[3].Text);
                }
            }
            tbTotal.Text = total.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvItems.SelectedItems[0];
                lvItems.Items.Remove(selectedItem);
                countTotal();
            }
            else
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Nije odabran nijedan artikal iz tabele!" : "No item selected in listview!", "Serbian(LAT)".Equals(employee.Language) ? "Greška" : "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string barcode = tbBarcode.Text.Trim();
            string name = tbDescription.Text.Trim();
            string quantity = tbQuantity.Text.Trim();
            if (!String.IsNullOrEmpty(barcode) && !String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(quantity))
            {
                MySqlProduct mySqlProduct = new MySqlProduct();
                Product product = mySqlProduct.GetProductById(int.Parse(barcode));

                if (product != null && product.Name.Equals(name))
                {
                    ListViewItem listViewItem = new ListViewItem(barcode);
                    listViewItem.SubItems.Add(name);
                    listViewItem.SubItems.Add(quantity);
                    listViewItem.SubItems.Add((Decimal.Parse(quantity) * product.Price).ToString());
                    bool added = false;

                    foreach (ListViewItem item in lvItems.Items)
                    {
                        if (item.SubItems[0].Text.Equals(barcode))
                        {
                            added = true;
                            Decimal quantity2 = Decimal.Parse(item.SubItems[2].Text) + Decimal.Parse(quantity);
                            item.SubItems[2].Text = quantity2.ToString();
                            item.SubItems[3].Text = (quantity2 * product.Price).ToString();
                        }

                    }
                    if (!added) { lvItems.Items.Add(listViewItem); }

                    countTotal();

                }
                else
                {
                    MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Artikal nije pronađen!" : "Article not found!", "Serbian(LAT)".Equals(employee.Language) ? "Greška!" : "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Nepopunjena polja!" : "Empty fields!", "Serbian(LAT)".Equals(employee.Language) ? "Greška!" : "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            tbDescription.Text = String.Empty;
            MySqlProduct mySqlProduct = new MySqlProduct();
            string barcode = String.Empty;
            string input = tbBarcode.Text;
            if (input.All(char.IsDigit))
            {
                barcode = tbBarcode.Text;
            }
            if (!String.IsNullOrEmpty(barcode))
            {
                Product product = mySqlProduct.GetProductById(int.Parse(tbBarcode.Text));
                if (product != null && (int.Parse(tbBarcode.Text) == product.ProductId))
                {
                    tbDescription.Text = product.Name;
                }

            }
        }


        private void btnConfirmInvoice_Click(object sender, EventArgs e)
        {
            PurchaseInvoice purchaseInvoice = new PurchaseInvoice();
            MySqlInvoice mySqlInvoice = new MySqlInvoice();
            MySqlProduct mySqlProduct = new MySqlProduct();
            Product product = new Product();
            purchaseInvoice.InvoiceId = mySqlInvoice.GetNumberOfInvoices() + 1;
            purchaseInvoice.IssueDate = purchaseInvoice.DeliveryDate = DateTime.Now;
            purchaseInvoice.EmployeeId = employee.EmployeeId;

            if (cbPaymentType.SelectedIndex != -1 && !String.IsNullOrEmpty(tbTotal.Text) && lvItems.Items.Count > 0 && lvSupplier.SelectedItems.Count > 0)
            {
                purchaseInvoice.PaymentType = cbPaymentType.SelectedIndex;
                purchaseInvoice.Total = Decimal.Parse(tbTotal.Text);
                purchaseInvoice.Comment = tbComment.Text;
                purchaseInvoice.SupplierId = lvSupplier.SelectedItems[0].Index + 1;

                mySqlInvoice.InsertPurchaseInvoice(purchaseInvoice);

                foreach (ListViewItem item in lvItems.Items)
                {
                    InvoiceItem invoiceItem = new InvoiceItem();
                    invoiceItem.ProductId = int.Parse(item.SubItems[0].Text);
                    invoiceItem.InvoiceId = purchaseInvoice.InvoiceId;
                    invoiceItem.Quantity = Decimal.Parse(item.SubItems[2].Text);
                    invoiceItem.Price = Decimal.Parse(item.SubItems[3].Text);
                    mySqlInvoice.InsertInvoiceItem(invoiceItem);
                    product = mySqlProduct.GetProductById(invoiceItem.ProductId);
                    mySqlProduct.UpdateProductStock(product, invoiceItem.Quantity, true);
                }
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Kreirana ulazna faktura!" : "Purchase invoice created!", "Serbian(LAT)".Equals(employee.Language) ? "Informacija" : "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Serbian(LAT)".Equals(employee.Language) ? "Nepopunjena polja!" : "Empty fields!", "Serbian(LAT)".Equals(employee.Language) ? "Greška!" : "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lvItems.Items.Clear();
            tbTotal.Text = String.Empty;
            tbBarcode.Text = String.Empty;
            tbComment.Text = String.Empty;
            tbDescription.Text = String.Empty;
            tbQuantity.Text = String.Empty;
            cbPaymentType.SelectedIndex = -1;
        }

        private void lvSupplier_ItemActivate(object sender, EventArgs e)
        {
            if (lvSupplier.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSupplier.SelectedItems[0];
                int barcode = int.Parse(selectedItem.SubItems[0].Text);
                MySqlSupplier mySqlSupplier = new MySqlSupplier();
                Supplier supplier = mySqlSupplier.GetById(barcode);
                if (supplier != null && supplier.SupplierId == barcode)
                {
                    SupplierDetailsForm supplierDetailsForm = new SupplierDetailsForm(supplier, this.employee, this);
                    supplierDetailsForm.Show();
                }
            }
        }
    }
}

using Gas_station.DataAccess.Exceptions;
using Gas_station.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.DataAccess.MySql
{
    internal class MySqlInvoice
    {
        private readonly string COUNTALL = "SELECT COUNT(*) FROM invoice";
        private readonly string INSERTINVOICE = "INSERT into invoice values(@id,@date,@total,@comment,@paymentType,@employeeId)";
        private readonly string INSERTSALESINVOICE = "INSERT into sales_invoice values(@date,@id)";
        private readonly string INSERTINVOICEITEM = "INSERT into invoice_item values(@quantity,@price,@invoiceId,@productId)";
        private readonly string INSERTPURCHASEINVOICE = "INSERT into purchase_invoice values(@date,@idS,@idI)";
        public int GetNumberOfInvoices()
        {
            Employee employee = new Employee();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            int invoicesCounter = 0;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = COUNTALL;
                reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    invoicesCounter = reader.GetInt32(0);
                }
                return invoicesCounter;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while counting!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            
        }

        public void InsertSalesInvoice(SalesInvoice sales)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERTINVOICE;
                cmd.Parameters.AddWithValue("@id", sales.InvoiceId);
                cmd.Parameters.AddWithValue("@date", sales.IssueDate);
                cmd.Parameters.AddWithValue("@total", sales.Total);
                cmd.Parameters.AddWithValue("@comment", sales.Comment);
                cmd.Parameters.AddWithValue("@paymentType", sales.PaymentType);
                cmd.Parameters.AddWithValue("@employeeId", sales.EmployeeId);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = INSERTSALESINVOICE;
                cmd.Parameters.AddWithValue("@date",sales.PaymentDate);
                cmd.Parameters.AddWithValue("@id", sales.InvoiceId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while inserting invoice and sales_invoice!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
        
        public void InsertPurchaseInvoice(PurchaseInvoice purchase)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERTINVOICE;
                cmd.Parameters.AddWithValue("@id", purchase.InvoiceId);
                cmd.Parameters.AddWithValue("@date", purchase.IssueDate);
                cmd.Parameters.AddWithValue("@total", purchase.Total);
                cmd.Parameters.AddWithValue("@comment", purchase.Comment);
                cmd.Parameters.AddWithValue("@paymentType", purchase.PaymentType);
                cmd.Parameters.AddWithValue("@employeeId", purchase.EmployeeId);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = INSERTPURCHASEINVOICE;
                cmd.Parameters.AddWithValue("@date", purchase.DeliveryDate);
                cmd.Parameters.AddWithValue("@idS", purchase.SupplierId);
                cmd.Parameters.AddWithValue("@idI", purchase.InvoiceId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while inserting invoice and purchase_invoice!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void InsertInvoiceItem(InvoiceItem invoiceItem)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERTINVOICEITEM;
                cmd.Parameters.AddWithValue("@quantity", invoiceItem.Quantity);
                cmd.Parameters.AddWithValue("@price", invoiceItem.Price);
                cmd.Parameters.AddWithValue("@invoiceId", invoiceItem.InvoiceId);
                cmd.Parameters.AddWithValue("@productId", invoiceItem.ProductId);
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while inserting invoice_item!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }


    }
}

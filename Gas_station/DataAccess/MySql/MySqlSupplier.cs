using Gas_station.DataAccess.Exceptions;
using Gas_station.Model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.DataAccess.MySql
{
    public class MySqlSupplier
    {
        private readonly string SELECTALL = "SELECT * FROM supplier";
        private readonly string INSERT = "INSERT INTO supplier VALUES(@id,@name,@address,@email,@image);";
        private readonly string SELECTBYID = "SELECT * FROM supplier WHERE supplier.id=@id";
        private readonly string UPDATENAME = "UPDATE supplier SET name=@name WHERE id=@id";
        private readonly string UPDATEEMAIL = "UPDATE supplier SET email=@email WHERE id=@id";
        private readonly string UPDATEADDRESS = "UPDATE supplier SET address=@address WHERE id=@id";
        public List<Supplier> GetSuppliers()
        {
            Supplier supplier;
            List<Supplier> suppliers = new List<Supplier>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECTALL;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplier = new Supplier();
                    supplier.SupplierId = reader.GetInt32(0);
                    supplier.Name = reader.GetString(1);
                    supplier.Address = reader.GetString(2);
                    supplier.Email = reader.GetString(3);
                    supplier.Image = reader.GetString(4);
                    suppliers.Add(supplier);

                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while getting product by name!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return suppliers;
        }

        public void Insert(Supplier supplier)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@id", supplier.SupplierId);
                cmd.Parameters.AddWithValue("@name", supplier.Name);
                cmd.Parameters.AddWithValue("@address", supplier.Address);
                cmd.Parameters.AddWithValue("@email", supplier.Email);
                cmd.Parameters.AddWithValue("@image", supplier.Image);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while inserting supplier!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public Supplier GetById(int id)
        {
            Supplier supplier = null;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECTBYID;
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplier = new Supplier();
                    supplier.SupplierId = reader.GetInt32(0);
                    supplier.Name = reader.GetString(1);
                    supplier.Address = reader.GetString(2);
                    supplier.Email = reader.GetString(3);
                    supplier.Image = reader.GetString(4);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while inserting supplier!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return supplier;
        }

        public void UpdateEmail(Supplier supplier, string email)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATEEMAIL;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", supplier.SupplierId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating supplier email!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdateName(Supplier supplier, string name)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATENAME;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", supplier.SupplierId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating supplier name!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdateAddress(Supplier supplier, string address)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATEADDRESS;
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@id", supplier.SupplierId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating supplier address!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}

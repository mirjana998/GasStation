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
    internal class MySqlProduct
    {
        private readonly string SELECTBYID = "SELECT * FROM product WHERE product.id=@id";
        private readonly string UPDATESTOCK = "UPDATE product SET stock=@stock WHERE id=@id";
        private readonly string UPDATENAME = "UPDATE product SET name=@name WHERE id=@id";
        private readonly string UPDATEPRICE = "UPDATE product SET price=@price WHERE id=@id";
        private readonly string SELECTALL = "SELECT * FROM product";
        private readonly string INSERT = "INSERT INTO product VALUES(@id,@name,@price,@measurementUnit,@stock,@image,@categoryId)";
        public Product GetProductById(int id)
        {
            Product product = new Product();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
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
                    product.ProductId = reader.GetInt32(0);
                    product.Name = reader.GetString(1);
                    product.Price = reader.GetDecimal(2);
                    product.MeasurementUnit = reader.GetString(3);
                    product.Stock = reader.GetInt32(4);
                    product.Image = reader.GetString(5);
                    product.CategoryId = reader.GetInt32(6);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while getting product by id!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return product;
        }

        public void UpdateProductStock(Product product, Decimal quantity, bool increase)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATESTOCK;
                cmd.Parameters.AddWithValue("@stock",increase ? product.Stock + quantity : product.Stock - quantity);
                cmd.Parameters.AddWithValue("@id", product.ProductId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating product stock!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public List<Product> GetProducts()
        {
            Product product;
            List<Product> products = new List<Product>();
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
                    product = new Product();
                    product.ProductId = reader.GetInt32(0);
                    product.Name = reader.GetString(1);
                    product.Price = reader.GetDecimal(2);
                    product.MeasurementUnit = reader.GetString(3);
                    product.Stock = reader.GetInt32(4);
                    product.Image = reader.GetString(5);
                    product.CategoryId = reader.GetInt32(6);
                    products.Add(product);
                    
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while getting all products!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return products;
        }

        public void Insert(Product product)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@id", product.ProductId);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@measurementUnit", product.MeasurementUnit);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.Parameters.AddWithValue("@image", product.Image);
                cmd.Parameters.AddWithValue("@categoryId", product.CategoryId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while inserting product!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdateName(Product product, string name)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATENAME;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", product.ProductId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating product name!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdatePrice(Product product, Decimal price)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATEPRICE;
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@id", product.ProductId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating product price!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}

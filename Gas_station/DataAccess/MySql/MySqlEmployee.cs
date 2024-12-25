using Gas_station.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Gas_station.DataAccess.Exceptions;
using Mysqlx.Crud;

namespace Gas_station.DataAccess.MySql
{
    public class MySqlEmployee
    {
        private readonly string SELECTBYUSERNAME = "SELECT * FROM employee WHERE employee.username=@username AND employee.password=@password";
        private readonly string UPDATEPASSWORD = "UPDATE employee SET password=@password WHERE id=@id";
        private readonly string UPDATETHEME= "UPDATE employee SET theme_id=@theme WHERE id=@id";
        private readonly string UPDATELANGUAGE = "UPDATE employee SET language=@language WHERE id=@id";
        public Employee GetEmployeeByUsernameAndPassword(string username, string password)
        {
            Employee employee = new Employee();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECTBYUSERNAME;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employee.EmployeeId = reader.GetInt32(0);
                    employee.Uin = reader.GetString(1);
                    employee.LastName = reader.GetString(2);
                    employee.FirstName = reader.GetString(3);
                    employee.EmploymentDate = reader.GetDateTime(4);
                    employee.Username = reader.GetString(5);
                    employee.Password = reader.GetString(6);
                    employee.Address = reader.GetString(7);
                    employee.IsEmployed = (bool)reader.GetValue(8);
                    employee.Image = reader.GetString(9);
                    employee.RoleId = reader.GetInt32(10);
                    employee.ThemeId = reader.GetInt32(11);
                    employee.Language = reader.GetString(12);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while getting employee by username and password!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return employee;
        }

        
        public void UpdateEmployeePassword(Employee employee, string password)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATEPASSWORD;
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@id", employee.EmployeeId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating employee password!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
       
        public void UpdateEmployeeTheme(Employee employee, int theme)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATETHEME;
                cmd.Parameters.AddWithValue("@theme", theme);
                cmd.Parameters.AddWithValue("@id", employee.EmployeeId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating employee theme!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdateEmployeeLanguage(Employee employee, string language)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATELANGUAGE;
                cmd.Parameters.AddWithValue("@language", language);
                cmd.Parameters.AddWithValue("@id", employee.EmployeeId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception while updating employee language!", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}

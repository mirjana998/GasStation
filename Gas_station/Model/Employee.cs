using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gas_station.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public int ThemeId { get; set; }
        public string Uin { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public bool IsEmployed { get; set; }
        public string Language {  get; set; }

        public Employee() { }

        public Employee(Employee employee) 
        {
            this.EmployeeId = employee.EmployeeId;
            this.RoleId = employee.RoleId;
            this.ThemeId = employee.ThemeId;
            this.Uin = employee.Uin;
            this.LastName = employee.LastName;
            this.FirstName = employee.FirstName;
            this.EmploymentDate = employee.EmploymentDate;
            this.Username = employee.Username;
            this.Password = employee.Password;
            this.Address = employee.Address;
            this.Image = employee.Image;
            this.IsEmployed = employee.IsEmployed;
            this.Language = employee.Language;
        }

        public override string ToString()
        {
            return "Employee Id: " + EmployeeId + " First name: " + FirstName + " Last name: " + LastName + "\nRoleId: " + RoleId + " ThemeId: " + ThemeId + " Uin: " + Uin + "\nEmployment date: " + EmploymentDate + " Username: " + Username + " Password: " + Password + "\nAddress: " + Address + " Image: " + Image + " IsEmployed: " + IsEmployed + " Language: " + Language;
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee && EmployeeId == EmployeeId;
                
        }

        public override int GetHashCode()
        {
            return 1415354057 + EmployeeId.GetHashCode();
        }

    }
}

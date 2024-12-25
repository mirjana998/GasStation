using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return "Role id: " + RoleId + " Name: " + Name + " Description: " + Description;
        }

        public override bool Equals(object? obj)
        {
            return obj is Role role && RoleId == role.RoleId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + RoleId.GetHashCode();
        }
    }
}

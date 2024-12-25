using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Model
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Image {  get; set; }

        public override string ToString()
        {
            return "Supplier id: " + SupplierId + " Name: " + Name ;
        }

        public override bool Equals(object? obj)
        {
            return obj is Supplier supplier && SupplierId == supplier.SupplierId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + SupplierId.GetHashCode();
        }
    }
}

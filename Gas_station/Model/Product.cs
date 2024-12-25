using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public string MeasurementUnit { get; set; }
        public int Stock {  get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return "Product id: " + ProductId + " Name: " + Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product && ProductId == product.ProductId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + ProductId.GetHashCode();
        }

    }
}

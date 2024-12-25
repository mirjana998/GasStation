using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Model
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Image {  get; set; }

        public override string ToString()
        {
            return "Category id: " + CategoryId + " Name: " + Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Category category && CategoryId == category.CategoryId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + CategoryId.GetHashCode();
        }


    }
}

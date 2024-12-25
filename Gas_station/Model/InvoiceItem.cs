using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gas_station.Model
{
    internal class InvoiceItem
    {
        public Decimal Quantity {  get; set; }
        public Decimal Price { get; set; }

        public int InvoiceId { get; set; }
        public int ProductId { get; set; }

        public override string ToString()
        {
            return "Invoide id: " + InvoiceId + " Product id: " + ProductId;
        }

        public override bool Equals(object? obj)
        {
            return obj is InvoiceItem invoiceItem && InvoiceId == invoiceItem.InvoiceId && ProductId == invoiceItem.ProductId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + InvoiceId.GetHashCode() + ProductId.GetHashCode();
        }

    }
}

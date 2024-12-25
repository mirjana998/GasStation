using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gas_station.Model
{
    internal class PurchaseInvoice : Invoice
    {
        public DateTime DeliveryDate { get; set; }
        public int SupplierId { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Supplier id: " + SupplierId + "Delivery date: " + DeliveryDate;
        }

        public override bool Equals(object? obj)
        {
            return obj is PurchaseInvoice purchaseInvoice && InvoiceId == purchaseInvoice.InvoiceId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + InvoiceId.GetHashCode();
        }
    }
}

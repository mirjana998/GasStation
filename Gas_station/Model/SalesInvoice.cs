using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gas_station.Model
{
    public class SalesInvoice : Invoice
    {
        public DateTime PaymentDate { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Payment date: " + PaymentDate;
        }

        public override bool Equals(object? obj)
        {
            return obj is SalesInvoice salesInvoice && InvoiceId == salesInvoice.InvoiceId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + InvoiceId.GetHashCode();
        }
    }
}

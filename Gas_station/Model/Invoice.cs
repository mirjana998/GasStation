using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gas_station.Model
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime IssueDate { get; set; }
        public Decimal Total { get; set; }
        public int PaymentType { get; set; }
        public int EmployeeId { get; set; }
        public string? Comment { get; set; }

        public override string ToString()
        {
            return "Invoice id: " + InvoiceId + " Employee id: " + EmployeeId + " Total: " + Total;
        }

        public override bool Equals(object? obj)
        {
            return obj is Invoice invoice && InvoiceId == invoice.InvoiceId;
        }

        public override int GetHashCode()
        {
            return 1415354057 + InvoiceId.GetHashCode();
        }
    }
}

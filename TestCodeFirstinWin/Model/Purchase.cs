using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeFirstinWin.Model
{
    class Purchase
    {
        // Define the individual purchase entries.
        public Int32 PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Decimal Amount { get; set; }
        // Store the customer's identifier for this record.
        public Int32 CustomerId { get; set; }
    }
}

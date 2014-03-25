using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeFirstinWin.Model
{
    class Customer
    {
        // Identify the individual customer.
        public Int32 CustomerId { get; set; }
        public String CustomerName { get; set; }
        // Provide linkage to the Purchase class.
        public virtual List<Purchase> Purchases { get; set; }
    }
}

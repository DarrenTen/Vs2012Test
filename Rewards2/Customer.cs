//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rewards2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Purchases = new HashSet<Purchase>();
        }
    
        public int Id { get; set; }
        public string CustomerName { get; set; }
    
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}

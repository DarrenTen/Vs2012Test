using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TestCodeFirstinWin.Model;
namespace TestCodeFirstinWin.DB
{
    class RewardsContext : DbContext
    {
        // Specify the name of the database as Rewards.
        public RewardsContext()
            : base("Rewards")
        {
        }
        // Create a database set for each of the data items.
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admins> AdminsTB { get; set; }

    }
}

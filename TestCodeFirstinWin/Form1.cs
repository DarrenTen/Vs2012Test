using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCodeFirstinWin.DB;
using TestCodeFirstinWin.Model;

namespace TestCodeFirstinWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new purchase.
            Purchase NewPurchase = new Purchase();
            NewPurchase.Amount = new Decimal(5.99);
            NewPurchase.PurchaseDate = DateTime.Now;
            // Create a new customer and add the purchase.
            Customer NewCustomer= new Customer {CustomerName = "Josh Bailey"};
            // Create the context.

            var ad = new Admins {Name = "IAmAdmin", dept = 3, Birthday = new DateTime(1990, 9, 12)};
            ad.AdminID = new Guid();
            var context = new RewardsContext();
            // Add the record and save it.
            context.Customers.Add(NewCustomer);
            context.Purchases.Add(NewPurchase);
            if (context.AdminsTB != null) context.AdminsTB.Add(ad);
            context.SaveChanges();
            // Display a success message.
            MessageBox.Show("Record Added");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            RewardsContext rc = new RewardsContext();
             var pcs = rc.Purchases.Select(p=>p);
             MessageBox.Show(pcs.Count()+"");
        }

        private void btnAddTestDB_Click(object sender, EventArgs e)
        {
           
        }
    }
}

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
            Customer NewCustomer = new Customer();
            NewCustomer.CustomerName = "Josh Bailey";
            // Create the context.
            RewardsContext context = new RewardsContext();
            // Add the record and save it.
            context.Customers.Add(NewCustomer);
            context.Purchases.Add(NewPurchase);
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
            Person p = new Person()
            {
                Name = "Haha",
                Age = 322
            };
            Man m = new Man()
            {
                ManName = "Jeff",
                ManAge = 16
            };
          string connStr=  ConfigurationManager.ConnectionStrings["EFtest"].ToString();
          TestDBContext tbC = new TestDBContext(connStr);
          // tbC.Persons.Add(p);
           tbC.Mans.Add(m);
           tbC.SaveChanges();
           MessageBox.Show(tbC.Persons.Count() + " 条数据"+tbC.Mans.Count());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstTest1
{
    public partial class Form1 : Form
    {
        public string name = "haha";

        public void TestAggre()
        {
            string sentence = "the quick brown fox jumps over the lazy dog";

            // Split the string into individual words. 
            string[] words = sentence.Split(' ');

            string res = words.Aggregate((a,b)=>b+","+a);
            int count = 0;
            string res1 = words.Aggregate((a, b) => {
                count++;
                Console.WriteLine(a+"-"+b+"("+count+")");
                return b + "," + a; 
            });
            MessageBox.Show(res);
        }
        public Form1()
        {
            InitializeComponent();
            TestAggre();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new purchase.
            Purchase NewPurchase = new Purchase();
            NewPurchase.Amount = new Decimal(5.99);
            NewPurchase.PurchaseDate = DateTime.Now;
            // Create a new customer and add the purchase.
            Customer NewCustomer = new Customer();
            NewCustomer.CustomerName = "Carole Poland";
            // Create the context.
            Rewards2Entities context = new Rewards2Entities();
            // Add the record and save it.
            context.Customers.Add(NewCustomer);
            context.Purchases.Add(NewPurchase);
            context.SaveChanges();
            // Display a success message.
            MessageBox.Show("Record Added");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            // Create the context.
            EntityConnection conn =
            new EntityConnection("name=Rewards2Entities");
            ObjectContext context = new ObjectContext(conn);
            // Define a command string for making the query.
            String EntitySQLCmd =
            "SELECT VALUE CustomerList " +
            "FROM Rewards2Entities.Customers " +
            "AS CustomerList";
            // Create a query object.
            ObjectQuery<Customer> Query =
            new ObjectQuery<Customer>(EntitySQLCmd, context);
            // Execute the query.
            List<Customer> Result = Query.Execute(MergeOption.NoTracking).ToList();

            dgView1.DataSource = Result;
            // Display the customer name on screen.
            MessageBox.Show(Result[0].CustomerName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityConnection ec = new EntityConnection("name=Rewards2Entities");
            ObjectContext oc = new ObjectContext(ec);
            string ecommand = "Update Rewards2Entities.Customers set CustomerName=CustomerName+'AA' where  CustomerId=2";
            ObjectQuery<Customer> query = new ObjectQuery<Customer>(ecommand, oc);
            var res = query.Execute(MergeOption.NoTracking);

            dgView1.DataSource = res;
        }

        private void btnLinqQuery_Click(object sender, EventArgs e)
        {
            Rewards2Entities r2e = new Rewards2Entities();
            dgView1.DataSource = r2e.Customers.ToList();

        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rewards2DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rewards2DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.rewards2DataSet.Customers);

        }
    }
}

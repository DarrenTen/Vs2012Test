using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProEF
{
    public partial class Form1 : Form
    {
        Model1Container ThisContainer;
        public Form1()
        {
            InitializeComponent();
            ThisContainer = new Model1Container();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are " + ThisContainer.CustomerSet.Count() + " records");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Customer c = new Customer()
            //{
            //    FullName = "Darren Teng1",
            //    FirstAddr = "Shanghai JinQiao1",
            //    City = "Shanghai1",
            //    SecondAddr = "Jinke Road1",
            //    State_Province = "SH1",
            //    Region_Country = "China1"
            //};
            //ThisContainer.CustomerSet.Add(c);
            //ThisContainer.SaveChanges();


            Customer thisCustomer = ThisContainer.CustomerSet.Create();
            try
            {

                thisCustomer.FullName = "Darren Teng2";
                thisCustomer.FirstAddr = "Shanghai JinQiao2";
                thisCustomer.City = "Shanghai2";
                thisCustomer.SecondAddr = "Jinke Road2";
                thisCustomer.State_Province = "SH2";
                thisCustomer.Region_Country = "China2";
                ThisContainer.CustomerSet.Add(thisCustomer);
                ThisContainer.SaveChanges();
                MessageBox.Show("Save new customer successfully,new id is "+thisCustomer.CustomerId);
            }
            catch (Exception ex)
            {
                var errors = ThisContainer.GetValidationErrors();
                MessageBox.Show("新增用户失败：" + ex.Message + ThisContainer.GetValidationErrors().ToString());
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThisContainer.SaveChanges();
        }
    }
}

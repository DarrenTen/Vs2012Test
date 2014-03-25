
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeFirstinWin.DB
{
    public class TestDBContext : DbContext
    {
        public TestDBContext()
            : base("CreateDBWithTheConnStr")
        {
           
        }

        public TestDBContext(string EFtest)
            : base(EFtest)
        {
            // //set default connStr
            //var connStr = ConfigurationManager.ConnectionStrings["EFtest"];

            //EFtest = connStr.ToString();
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Man> Mans { get; set; }

    }

    public  class Person
    {
        public Int32 PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class Man
    {
        public Int32 ManID { get; set; }
        public string ManName { get; set; }
        public int ManAge { get; set; }
        public string Descr { get; set; }
    }
}

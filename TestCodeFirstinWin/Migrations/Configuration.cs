namespace TestCodeFirstinWin.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestCodeFirstinWin.DB.TestDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestCodeFirstinWin.DB.TestDBContext context)
        {

        }
    }
}

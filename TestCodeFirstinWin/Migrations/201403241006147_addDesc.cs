namespace TestCodeFirstinWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDesc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Men",
                c => new
                    {
                        ManID = c.Int(nullable: false, identity: true),
                        ManName = c.String(),
                        ManAge = c.Int(nullable: false),
                        Descr = c.String(),
                    })
                .PrimaryKey(t => t.ManID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");

            DropTable("dbo.Men");
        }
    }
}

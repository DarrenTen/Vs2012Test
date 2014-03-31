namespace TestCodeFirstinWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminTB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Guid(nullable: false),
                        Name = c.String(),
                        dept = c.Int(nullable: false),
                        Birthday = c.DateTime(),
                    })
                .PrimaryKey(t => t.AdminID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}

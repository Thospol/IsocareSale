namespace Salecoop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        IdEmployee = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Username = c.String(),
                        Idcard = c.String(),
                        Email = c.String(),
                        Tel = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.IdEmployee);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}

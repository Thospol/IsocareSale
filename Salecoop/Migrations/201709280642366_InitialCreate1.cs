namespace Salecoop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.salecoops", "quotationNo", c => c.String(nullable: false));
            AlterColumn("dbo.salecoops", "useroffer", c => c.String(nullable: false));
            AlterColumn("dbo.salecoops", "coopName", c => c.String(nullable: false));
            AlterColumn("dbo.salecoops", "sequence", c => c.String(nullable: false));
            AlterColumn("dbo.salecoops", "listorder", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.salecoops", "listorder", c => c.String());
            AlterColumn("dbo.salecoops", "sequence", c => c.String());
            AlterColumn("dbo.salecoops", "coopName", c => c.String());
            AlterColumn("dbo.salecoops", "useroffer", c => c.String());
            AlterColumn("dbo.salecoops", "quotationNo", c => c.String());
        }
    }
}

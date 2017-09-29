namespace Salecoop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.salecoops",
                c => new
                    {
                        idsale = c.Int(nullable: false, identity: true),
                        quotationNo = c.String(),
                        dayindate = c.DateTime(nullable: false),
                        useroffer = c.String(),
                        coopName = c.String(),
                        sequence = c.String(),
                        listorder = c.String(),
                        amount = c.Int(nullable: false),
                        salepricesumvat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        costsumvat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        profitaftersale = c.Decimal(nullable: false, precision: 18, scale: 2),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.idsale);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.salecoops");
        }
    }
}

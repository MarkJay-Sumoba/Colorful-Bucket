namespace PaintShopManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrdersAndUpdateUsers1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        orderId = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        customerId = c.Int(nullable: false),
                        itemId = c.Int(nullable: false),
                        itemQuantity = c.Int(nullable: false),
                        orderDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.orderId)
                .ForeignKey("dbo.Customers", t => t.customerId, cascadeDelete: true)
                .ForeignKey("dbo.Inventories", t => t.itemId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId)
                .Index(t => t.customerId)
                .Index(t => t.itemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "userId", "dbo.Users");
            DropForeignKey("dbo.Orders", "itemId", "dbo.Inventories");
            DropForeignKey("dbo.Orders", "customerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "itemId" });
            DropIndex("dbo.Orders", new[] { "customerId" });
            DropIndex("dbo.Orders", new[] { "userId" });
            DropTable("dbo.Orders");
        }
    }
}

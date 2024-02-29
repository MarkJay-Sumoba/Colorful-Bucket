namespace PaintShopManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUsersCustomersAndInventory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false),
                        lastName = c.String(nullable: false),
                        company = c.String(),
                        email = c.String(nullable: false),
                        phone = c.String(nullable: false),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.customerId);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        inventoryId = c.Int(nullable: false, identity: true),
                        itemName = c.String(nullable: false),
                        color = c.Int(nullable: false),
                        price = c.Decimal(nullable: false, precision: 10, scale: 2),
                        qty = c.Int(nullable: false),
                        wt = c.Int(nullable: false),
                        manufacture = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.inventoryId);
            
            AddColumn("dbo.Users", "firstName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "lastName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "email", c => c.String());
            AddColumn("dbo.Users", "phone", c => c.String());
            AddColumn("dbo.Users", "ProfilePic", c => c.Binary());
            AlterColumn("dbo.Users", "userName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "password", c => c.String());
            AlterColumn("dbo.Users", "userName", c => c.String());
            DropColumn("dbo.Users", "ProfilePic");
            DropColumn("dbo.Users", "phone");
            DropColumn("dbo.Users", "email");
            DropColumn("dbo.Users", "lastName");
            DropColumn("dbo.Users", "firstName");
            DropTable("dbo.Inventories");
            DropTable("dbo.Customers");
        }
    }
}

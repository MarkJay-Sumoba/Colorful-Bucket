namespace PaintShopManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InventoryUsersPropertyUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "position", c => c.Int(nullable: false));
            AlterColumn("dbo.Inventories", "color", c => c.String(nullable: false));
            AlterColumn("dbo.Inventories", "wt", c => c.String(nullable: false));
            AlterColumn("dbo.Inventories", "manufacture", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inventories", "manufacture", c => c.Int(nullable: false));
            AlterColumn("dbo.Inventories", "wt", c => c.Int(nullable: false));
            AlterColumn("dbo.Inventories", "color", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "position");
        }
    }
}

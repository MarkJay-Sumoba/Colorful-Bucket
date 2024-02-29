namespace PaintShopManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyInventoryID : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "itemId", newName: "inventoryId");
            RenameIndex(table: "dbo.Orders", name: "IX_itemId", newName: "IX_inventoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_inventoryId", newName: "IX_itemId");
            RenameColumn(table: "dbo.Orders", name: "inventoryId", newName: "itemId");
        }
    }
}

namespace PaintShopManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UsersPositionDefaultSettingUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Users SET position = 2 WHERE position IS NULL");
            Sql("UPDATE dbo.Users SET firstName = 'Unknown' WHERE firstName IS NULL");
            Sql("UPDATE dbo.Users SET lastName = 'Unknown' WHERE lastName IS NULL");
        }

        public override void Down()
        {
        }
    }
}

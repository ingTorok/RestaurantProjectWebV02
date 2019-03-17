namespace RestaurantProjectWebV02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMenuItemsNameDescriptionPricenotnull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MenuItems", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.MenuItems", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MenuItems", "Description", c => c.String());
            AlterColumn("dbo.MenuItems", "Name", c => c.String());
        }
    }
}

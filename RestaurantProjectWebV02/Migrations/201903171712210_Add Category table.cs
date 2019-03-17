namespace RestaurantProjectWebV02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategorytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MenuItems", "Category_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MenuItems", "Category_Id");
            AddForeignKey("dbo.MenuItems", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItems", "Category_Id", "dbo.Categories");
            DropIndex("dbo.MenuItems", new[] { "Category_Id" });
            DropColumn("dbo.MenuItems", "Category_Id");
            DropTable("dbo.Categories");
        }
    }
}

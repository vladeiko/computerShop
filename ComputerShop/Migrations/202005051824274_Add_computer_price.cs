namespace ComputerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_computer_price : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Computers", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Computers", "Price");
        }
    }
}

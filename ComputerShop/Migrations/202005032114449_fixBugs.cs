namespace ComputerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixBugs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ImagePath");
        }
    }
}

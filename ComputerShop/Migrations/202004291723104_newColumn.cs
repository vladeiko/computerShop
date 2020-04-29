namespace ComputerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Status");
        }
    }
}

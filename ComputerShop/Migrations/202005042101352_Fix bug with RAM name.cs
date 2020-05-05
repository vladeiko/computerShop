namespace ComputerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixbugwithRAMname : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RAMs", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RAMs", "Name", c => c.Int(nullable: false));
        }
    }
}

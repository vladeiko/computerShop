namespace ComputerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcomputersandcomponentparts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(),
                        Model = c.String(),
                        ProcessorId = c.Int(nullable: false),
                        VideocardId = c.Int(nullable: false),
                        RAMId = c.Int(nullable: false),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Processors", t => t.ProcessorId, cascadeDelete: true)
                .ForeignKey("dbo.RAMs", t => t.RAMId, cascadeDelete: true)
                .ForeignKey("dbo.Videocards", t => t.VideocardId, cascadeDelete: true)
                .Index(t => t.ProcessorId)
                .Index(t => t.VideocardId)
                .Index(t => t.RAMId);
            
            CreateTable(
                "dbo.Processors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumOfCores = c.Int(nullable: false),
                        ClockFrequency = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RAMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Videocards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        VideoMemory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Computers", "VideocardId", "dbo.Videocards");
            DropForeignKey("dbo.Computers", "RAMId", "dbo.RAMs");
            DropForeignKey("dbo.Computers", "ProcessorId", "dbo.Processors");
            DropIndex("dbo.Computers", new[] { "RAMId" });
            DropIndex("dbo.Computers", new[] { "VideocardId" });
            DropIndex("dbo.Computers", new[] { "ProcessorId" });
            DropTable("dbo.Videocards");
            DropTable("dbo.RAMs");
            DropTable("dbo.Processors");
            DropTable("dbo.Computers");
        }
    }
}

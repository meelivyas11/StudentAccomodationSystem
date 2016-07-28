namespace SAS_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Load3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Address = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Image = c.String(),
                        Status = c.String(),
                        SasPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoomEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserEntityId = c.Int(nullable: false),
                        RoomEntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomEntities", t => t.RoomEntityId, cascadeDelete: true)
                .ForeignKey("dbo.UserEntities", t => t.UserEntityId, cascadeDelete: true)
                .Index(t => t.UserEntityId)
                .Index(t => t.RoomEntityId);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Role = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoomEntities", "UserEntityId", "dbo.UserEntities");
            DropForeignKey("dbo.UserRoomEntities", "RoomEntityId", "dbo.RoomEntities");
            DropIndex("dbo.UserRoomEntities", new[] { "RoomEntityId" });
            DropIndex("dbo.UserRoomEntities", new[] { "UserEntityId" });
            DropTable("dbo.UserEntities");
            DropTable("dbo.UserRoomEntities");
            DropTable("dbo.RoomEntities");
        }
    }
}

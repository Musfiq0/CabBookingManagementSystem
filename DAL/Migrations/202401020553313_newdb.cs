namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PickupTime = c.DateTime(nullable: false),
                        PickupLocation = c.String(),
                        Destination = c.String(),
                        DriverId = c.Int(),
                        PassengerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.DriverId)
                .ForeignKey("dbo.Passengers", t => t.PassengerId, cascadeDelete: true)
                .Index(t => t.DriverId)
                .Index(t => t.PassengerId);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DUName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                        OwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owners", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OUName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PUName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        UserType = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "PassengerId", "dbo.Passengers");
            DropForeignKey("dbo.Bookings", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Drivers", "OwnerId", "dbo.Owners");
            DropIndex("dbo.Drivers", new[] { "OwnerId" });
            DropIndex("dbo.Bookings", new[] { "PassengerId" });
            DropIndex("dbo.Bookings", new[] { "DriverId" });
            DropTable("dbo.Users");
            DropTable("dbo.Passengers");
            DropTable("dbo.Owners");
            DropTable("dbo.Drivers");
            DropTable("dbo.Bookings");
        }
    }
}

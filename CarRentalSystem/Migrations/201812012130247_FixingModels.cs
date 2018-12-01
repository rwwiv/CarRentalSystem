namespace CarRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        vin = c.String(nullable: false, maxLength: 128),
                        color = c.String(),
                        model = c.String(),
                        make = c.String(),
                        isAvailable = c.Boolean(nullable: false),
                        costPerDay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.vin);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        rentalId = c.Int(nullable: false, identity: true),
                        car_vin = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.rentalId)
                .ForeignKey("dbo.Cars", t => t.car_vin)
                .Index(t => t.car_vin);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        sessionId = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        login = c.DateTime(nullable: false),
                        logout = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.sessionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        username = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                        userLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "car_vin", "dbo.Cars");
            DropIndex("dbo.Rentals", new[] { "car_vin" });
            DropTable("dbo.Users");
            DropTable("dbo.Sessions");
            DropTable("dbo.Rentals");
            DropTable("dbo.Cars");
        }
    }
}

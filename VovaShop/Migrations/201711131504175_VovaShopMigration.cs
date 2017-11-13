namespace VovaShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VovaShopMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 128),
                        Phone = c.String(nullable: false, maxLength: 128),
                        PathAvatar = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RecycleBins",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.String(nullable: false, maxLength: 256),
                        CreateDate = c.DateTime(nullable: false),
                        RecycleBinId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RecycleBins", t => t.RecycleBinId, cascadeDelete: true)
                .Index(t => t.RecycleBinId);
            
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 256),
                        Price = c.String(nullable: false, maxLength: 256),
                        Quarantee = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderAddresses",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Street = c.String(nullable: false, maxLength: 256),
                        HouseNumber = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Rating = c.String(nullable: false, maxLength: 256),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        ShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shops", t => t.ShopId, cascadeDelete: true)
                .Index(t => t.ShopId);
            
            CreateTable(
                "dbo.StorageAddresses",
                c => new
                    {
                        StorageId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Street = c.String(nullable: false, maxLength: 256),
                        HouseNumber = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.StorageId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Storages", t => t.StorageId)
                .Index(t => t.StorageId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Status = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.CategoryGoods",
                c => new
                    {
                        Category_Id = c.Int(nullable: false),
                        Goods_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.Goods_Id })
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Goods", t => t.Goods_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Goods_Id);
            
            CreateTable(
                "dbo.RoleUsers",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.User_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderStatus", "Id", "dbo.Orders");
            DropForeignKey("dbo.RoleUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.RecycleBins", "Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "RecycleBinId", "dbo.RecycleBins");
            DropForeignKey("dbo.OrderAddresses", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderAddresses", "CityId", "dbo.Cities");
            DropForeignKey("dbo.StorageAddresses", "StorageId", "dbo.Storages");
            DropForeignKey("dbo.StorageAddresses", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Storages", "ShopId", "dbo.Shops");
            DropForeignKey("dbo.Shops", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Goods", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.CategoryGoods", "Goods_Id", "dbo.Goods");
            DropForeignKey("dbo.CategoryGoods", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.BankCards", "UserId", "dbo.Users");
            DropIndex("dbo.RoleUsers", new[] { "User_Id" });
            DropIndex("dbo.RoleUsers", new[] { "Role_Id" });
            DropIndex("dbo.CategoryGoods", new[] { "Goods_Id" });
            DropIndex("dbo.CategoryGoods", new[] { "Category_Id" });
            DropIndex("dbo.OrderStatus", new[] { "Id" });
            DropIndex("dbo.StorageAddresses", new[] { "CityId" });
            DropIndex("dbo.StorageAddresses", new[] { "StorageId" });
            DropIndex("dbo.Storages", new[] { "ShopId" });
            DropIndex("dbo.Shops", new[] { "CityId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.OrderAddresses", new[] { "CityId" });
            DropIndex("dbo.OrderAddresses", new[] { "OrderId" });
            DropIndex("dbo.Goods", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "RecycleBinId" });
            DropIndex("dbo.RecycleBins", new[] { "Id" });
            DropIndex("dbo.BankCards", new[] { "UserId" });
            DropTable("dbo.RoleUsers");
            DropTable("dbo.CategoryGoods");
            DropTable("dbo.OrderStatus");
            DropTable("dbo.Roles");
            DropTable("dbo.StorageAddresses");
            DropTable("dbo.Storages");
            DropTable("dbo.Shops");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.OrderAddresses");
            DropTable("dbo.Categories");
            DropTable("dbo.Goods");
            DropTable("dbo.Orders");
            DropTable("dbo.RecycleBins");
            DropTable("dbo.Users");
            DropTable("dbo.BankCards");
        }
    }
}

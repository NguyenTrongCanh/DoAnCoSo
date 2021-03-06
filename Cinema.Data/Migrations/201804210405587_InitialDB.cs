namespace Cinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Images = c.String(maxLength: 100),
                        Price = c.Int(nullable: false),
                        Decription = c.String(maxLength: 100),
                        InventoryItem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        FooterID = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FooterID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        URL = c.String(nullable: false, maxLength: 256),
                        DisplayOrder = c.Int(),
                        GroupID = c.Int(nullable: false),
                        Target = c.String(maxLength: 10),
                        CreatedDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeywork = c.String(maxLength: 256),
                        MetaDesciption = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MenuID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.MovieCategories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        NameMovie = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Desciption = c.String(maxLength: 500),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        NameMovie = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(nullable: false, maxLength: 256),
                        MoreImage = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Desciption = c.String(nullable: false, maxLength: 500),
                        Warranty = c.Int(),
                        Content = c.String(nullable: false),
                        Actor = c.String(nullable: false),
                        Directors = c.String(nullable: false),
                        Producer = c.String(nullable: false),
                        Age = c.String(nullable: false),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeywork = c.String(maxLength: 256),
                        MetaDesciption = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MovieID)
                .ForeignKey("dbo.MovieCategories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.MovieTags",
                c => new
                    {
                        MovieID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.MovieID, t.TagID })
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TagID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        MovieID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.MovieID })
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.MovieID)
                .Index(t => t.FoodID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 256),
                        CustomerAddress = c.String(nullable: false, maxLength: 256),
                        CustomerEmail = c.String(nullable: false, maxLength: 256),
                        CustomerPhone = c.String(nullable: false, maxLength: 50),
                        CustomerMessage = c.String(maxLength: 256),
                        PaymenMethod = c.String(maxLength: 256),
                        PaymentStatus = c.String(),
                        CreatedDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeywork = c.String(maxLength: 256),
                        MetaDesciption = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Content = c.String(),
                        CreatedDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeywork = c.String(maxLength: 256),
                        MetaDesciption = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Desciption = c.String(maxLength: 500),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(nullable: false, maxLength: 256),
                        MoreImage = c.String(storeType: "xml"),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Desciption = c.String(nullable: false, maxLength: 500),
                        Content = c.String(nullable: false),
                        Actor = c.String(nullable: false),
                        Directors = c.String(nullable: false),
                        Producer = c.String(nullable: false),
                        Age = c.String(nullable: false),
                        HomeFlag = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 256),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 256),
                        MetaKeywork = c.String(maxLength: 256),
                        MetaDesciption = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.PostCategories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        PostID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.PostID, t.TagID })
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.PostID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.ShowTimes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartDay = c.DateTime(nullable: false),
                        EndDay = c.DateTime(nullable: false),
                        MovieID = c.Int(nullable: false),
                        TheaterID = c.Int(nullable: false),
                        TimeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Theater", t => t.TheaterID, cascadeDelete: true)
                .ForeignKey("dbo.Times", t => t.TimeID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.TheaterID)
                .Index(t => t.TimeID);
            
            CreateTable(
                "dbo.Theater",
                c => new
                    {
                        TheaterID = c.Int(nullable: false, identity: true),
                        NameTheater = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TheaterID);
            
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        TimeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartTime = c.String(),
                        AmountOfTime = c.String(),
                    })
                .PrimaryKey(t => t.TimeID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Decription = c.String(maxLength: 256),
                        Image = c.String(nullable: false, maxLength: 256),
                        URL = c.String(nullable: false, maxLength: 256),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Department = c.String(maxLength: 50),
                        Skype = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Facebook = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                        DisplayOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        ValueString = c.String(maxLength: 50),
                        ValueInt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Account = c.String(nullable: false),
                        PassWord = c.String(nullable: false),
                        Role = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        Job = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IPAddress = c.String(maxLength: 50),
                        VisitedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShowTimes", "TimeID", "dbo.Times");
            DropForeignKey("dbo.ShowTimes", "TheaterID", "dbo.Theater");
            DropForeignKey("dbo.ShowTimes", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "CategoryID", "dbo.PostCategories");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.OrderDetails", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.MovieTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.MovieTags", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.Movies", "CategoryID", "dbo.MovieCategories");
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups");
            DropIndex("dbo.ShowTimes", new[] { "TimeID" });
            DropIndex("dbo.ShowTimes", new[] { "TheaterID" });
            DropIndex("dbo.ShowTimes", new[] { "MovieID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropIndex("dbo.Posts", new[] { "CategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "FoodID" });
            DropIndex("dbo.OrderDetails", new[] { "MovieID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.MovieTags", new[] { "TagID" });
            DropIndex("dbo.MovieTags", new[] { "MovieID" });
            DropIndex("dbo.Movies", new[] { "CategoryID" });
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.Users");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Slides");
            DropTable("dbo.Times");
            DropTable("dbo.Theater");
            DropTable("dbo.ShowTimes");
            DropTable("dbo.PostTags");
            DropTable("dbo.Posts");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Pages");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Tags");
            DropTable("dbo.MovieTags");
            DropTable("dbo.Movies");
            DropTable("dbo.MovieCategories");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
            DropTable("dbo.Foods");
        }
    }
}

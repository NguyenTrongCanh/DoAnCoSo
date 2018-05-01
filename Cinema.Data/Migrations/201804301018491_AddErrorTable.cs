namespace Cinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.PostCategories", "ParentID", c => c.Int(nullable: false));
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaKeywork", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaDesciption", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PostCategories", "Status");
            DropColumn("dbo.PostCategories", "MetaDesciption");
            DropColumn("dbo.PostCategories", "MetaKeywork");
            DropColumn("dbo.PostCategories", "UpdateBy");
            DropColumn("dbo.PostCategories", "UpdateDate");
            DropColumn("dbo.PostCategories", "CreateBy");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.PostCategories", "ParentID");
            DropTable("dbo.Errors");
        }
    }
}

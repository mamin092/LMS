namespace Lms.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Modify = c.DateTime(nullable: false),
                        ModiifyBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name)
                .Index(t => t.Phone)
                .Index(t => t.Created)
                .Index(t => t.CreatedBy)
                .Index(t => t.Modify)
                .Index(t => t.ModiifyBy);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "ModiifyBy" });
            DropIndex("dbo.Students", new[] { "Modify" });
            DropIndex("dbo.Students", new[] { "CreatedBy" });
            DropIndex("dbo.Students", new[] { "Created" });
            DropIndex("dbo.Students", new[] { "Phone" });
            DropIndex("dbo.Students", new[] { "Name" });
            DropTable("dbo.Students");
        }
    }
}

namespace Lms.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTeacherModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Phope = c.String(),
                        Address = c.String(),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Modify = c.DateTime(nullable: false),
                        ModiifyBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Created)
                .Index(t => t.CreatedBy)
                .Index(t => t.Modify)
                .Index(t => t.ModiifyBy);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Teachers", new[] { "ModiifyBy" });
            DropIndex("dbo.Teachers", new[] { "Modify" });
            DropIndex("dbo.Teachers", new[] { "CreatedBy" });
            DropIndex("dbo.Teachers", new[] { "Created" });
            DropTable("dbo.Teachers");
        }
    }
}

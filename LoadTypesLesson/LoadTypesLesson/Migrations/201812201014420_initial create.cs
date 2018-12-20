namespace LoadTypesLesson.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mothers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        EyesColor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sons",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SonMothers",
                c => new
                    {
                        Son_Id = c.Guid(nullable: false),
                        Mother_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Son_Id, t.Mother_Id })
                .ForeignKey("dbo.Sons", t => t.Son_Id, cascadeDelete: true)
                .ForeignKey("dbo.Mothers", t => t.Mother_Id, cascadeDelete: true)
                .Index(t => t.Son_Id)
                .Index(t => t.Mother_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SonMothers", "Mother_Id", "dbo.Mothers");
            DropForeignKey("dbo.SonMothers", "Son_Id", "dbo.Sons");
            DropIndex("dbo.SonMothers", new[] { "Mother_Id" });
            DropIndex("dbo.SonMothers", new[] { "Son_Id" });
            DropTable("dbo.SonMothers");
            DropTable("dbo.Sons");
            DropTable("dbo.Mothers");
        }
    }
}

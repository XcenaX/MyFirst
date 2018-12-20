namespace LoadTypesLesson.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addsomeproperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mothers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Mothers", "Weight", c => c.Double(nullable: false));
            AddColumn("dbo.Mothers", "IsFat", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sons", "IsFoster", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sons", "SchoolName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sons", "SchoolName");
            DropColumn("dbo.Sons", "IsFoster");
            DropColumn("dbo.Mothers", "IsFat");
            DropColumn("dbo.Mothers", "Weight");
            DropColumn("dbo.Mothers", "Age");
        }
    }
}

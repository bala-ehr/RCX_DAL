namespace RC_X.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Project : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "project", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "project");
        }
    }
}

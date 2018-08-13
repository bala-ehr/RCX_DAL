namespace RC_X.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Guid : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "enterprise", c => c.Guid(nullable: false));
            AlterColumn("dbo.AspNetUsers", "project", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "project", c => c.String());
            AlterColumn("dbo.AspNetUsers", "enterprise", c => c.String());
        }
    }
}

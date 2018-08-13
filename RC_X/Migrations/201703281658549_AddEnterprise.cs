namespace RC_X.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEnterprise : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "enterprise", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "enterprise");
        }
    }
}

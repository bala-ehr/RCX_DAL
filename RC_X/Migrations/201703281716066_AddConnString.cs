namespace RC_X.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConnString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "connstring", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "connstring");
        }
    }
}

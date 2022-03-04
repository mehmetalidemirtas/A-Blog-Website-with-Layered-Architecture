namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorJob", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "AuthorAboutShort", c => c.String(maxLength: 100));
            AddColumn("dbo.Authors", "Mail", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "Password", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "Phone", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Phone");
            DropColumn("dbo.Authors", "Password");
            DropColumn("dbo.Authors", "Mail");
            DropColumn("dbo.Authors", "AuthorAboutShort");
            DropColumn("dbo.Authors", "AuthorJob");
        }
    }
}

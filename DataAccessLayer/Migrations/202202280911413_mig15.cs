namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "LinkedinLink", c => c.String());
            AddColumn("dbo.Abouts", "TwitterLink", c => c.String());
            AddColumn("dbo.Abouts", "GithubLink", c => c.String());
            AddColumn("dbo.Abouts", "WebsiteLink", c => c.String());
            DropColumn("dbo.Authors", "AuthorAboutShort");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "AuthorAboutShort", c => c.String(maxLength: 100));
            DropColumn("dbo.Abouts", "WebsiteLink");
            DropColumn("dbo.Abouts", "GithubLink");
            DropColumn("dbo.Abouts", "TwitterLink");
            DropColumn("dbo.Abouts", "LinkedinLink");
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "GithubLink", c => c.String());
            AddColumn("dbo.Authors", "LinkedinLink", c => c.String());
            AddColumn("dbo.Authors", "TwitterLink", c => c.String());
            DropColumn("dbo.Admins", "AdminRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "AdminRole", c => c.String(maxLength: 1));
            DropColumn("dbo.Authors", "TwitterLink");
            DropColumn("dbo.Authors", "LinkedinLink");
            DropColumn("dbo.Authors", "GithubLink");
        }
    }
}

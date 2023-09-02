namespace WcfTestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "SenderId", "dbo.Users");
            DropIndex("dbo.Messages", new[] { "SenderId" });
            AddColumn("dbo.Messages", "IsRead", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Token", c => c.String());
            AddColumn("dbo.Users", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Messages", "SenderId");
            DropColumn("dbo.Users", "Login");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Login", c => c.String());
            AddColumn("dbo.Messages", "SenderId", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "IsActive");
            DropColumn("dbo.Users", "Token");
            DropColumn("dbo.Messages", "IsRead");
            CreateIndex("dbo.Messages", "SenderId");
            AddForeignKey("dbo.Messages", "SenderId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}

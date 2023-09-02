namespace WcfTestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        To = c.String(),
                        From = c.String(),
                        Content = c.String(),
                        SentOn = c.DateTime(nullable: false),
                        SenderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.SenderId, cascadeDelete: true)
                .Index(t => t.SenderId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "SenderId", "dbo.Users");
            DropIndex("dbo.Messages", new[] { "SenderId" });
            DropTable("dbo.Users");
            DropTable("dbo.Messages");
        }
    }
}

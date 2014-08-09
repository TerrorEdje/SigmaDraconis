namespace SigmaDraconisData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewVoteSystem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PollVotes", "By_Username", "dbo.Users");
            DropForeignKey("dbo.PollVotes", "PollOption_Id", "dbo.PollOptions");
            DropIndex("dbo.PollVotes", new[] { "By_Username" });
            DropIndex("dbo.PollVotes", new[] { "PollOption_Id" });
            CreateTable(
                "dbo.PollOptionUsers",
                c => new
                    {
                        PollOption_Id = c.Int(nullable: false),
                        User_Username = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PollOption_Id, t.User_Username })
                .ForeignKey("dbo.PollOptions", t => t.PollOption_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Username, cascadeDelete: true)
                .Index(t => t.PollOption_Id)
                .Index(t => t.User_Username);
            
            DropTable("dbo.PollVotes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PollVotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        By_Username = c.String(maxLength: 128),
                        PollOption_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.PollOptionUsers", "User_Username", "dbo.Users");
            DropForeignKey("dbo.PollOptionUsers", "PollOption_Id", "dbo.PollOptions");
            DropIndex("dbo.PollOptionUsers", new[] { "User_Username" });
            DropIndex("dbo.PollOptionUsers", new[] { "PollOption_Id" });
            DropTable("dbo.PollOptionUsers");
            CreateIndex("dbo.PollVotes", "PollOption_Id");
            CreateIndex("dbo.PollVotes", "By_Username");
            AddForeignKey("dbo.PollVotes", "PollOption_Id", "dbo.PollOptions", "Id");
            AddForeignKey("dbo.PollVotes", "By_Username", "dbo.Users", "Username");
        }
    }
}

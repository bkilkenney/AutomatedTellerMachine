namespace AutomatedTellerMachine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Another : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckingAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApplicatinUserID = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            DropColumn("dbo.AspNetUsers", "Bio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Bio", c => c.String());
            DropForeignKey("dbo.CheckingAccounts", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.CheckingAccounts", new[] { "User_Id" });
            DropTable("dbo.CheckingAccounts");
        }
    }
}

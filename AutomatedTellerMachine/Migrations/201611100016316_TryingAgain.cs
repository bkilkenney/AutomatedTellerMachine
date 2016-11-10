namespace AutomatedTellerMachine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryingAgain : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CheckingAccounts", name: "User_Id", newName: "ApplicationUserId");
            RenameIndex(table: "dbo.CheckingAccounts", name: "IX_User_Id", newName: "IX_ApplicationUserId");
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false));
            AlterColumn("dbo.CheckingAccounts", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.CheckingAccounts", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.CheckingAccounts", "ApplicatinUserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CheckingAccounts", "ApplicatinUserID", c => c.String());
            AlterColumn("dbo.CheckingAccounts", "LastName", c => c.String());
            AlterColumn("dbo.CheckingAccounts", "FirstName", c => c.String());
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String());
            RenameIndex(table: "dbo.CheckingAccounts", name: "IX_ApplicationUserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.CheckingAccounts", name: "ApplicationUserId", newName: "User_Id");
        }
    }
}

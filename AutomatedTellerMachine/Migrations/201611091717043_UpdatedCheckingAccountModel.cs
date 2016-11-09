namespace AutomatedTellerMachine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCheckingAccountModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Bio", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Bio");
        }
    }
}

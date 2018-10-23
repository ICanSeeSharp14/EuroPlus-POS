namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserRoles", "User_Id", c => c.Int());
            CreateIndex("dbo.UserRoles", "User_Id");
            AddForeignKey("dbo.UserRoles", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "User_Id", "dbo.Users");
            DropIndex("dbo.UserRoles", new[] { "User_Id" });
            DropColumn("dbo.UserRoles", "User_Id");
        }
    }
}

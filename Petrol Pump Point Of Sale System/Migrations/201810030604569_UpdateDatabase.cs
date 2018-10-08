namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Role_UserRoleId", c => c.Int());
            AlterColumn("dbo.Sales", "PaymentType", c => c.Byte(nullable: false));
            AlterColumn("dbo.Users", "UserType", c => c.Byte(nullable: false));
            CreateIndex("dbo.Users", "Role_UserRoleId");
            AddForeignKey("dbo.Users", "Role_UserRoleId", "dbo.UserRoles", "UserRoleId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_UserRoleId", "dbo.UserRoles");
            DropIndex("dbo.Users", new[] { "Role_UserRoleId" });
            AlterColumn("dbo.Users", "UserType", c => c.Int(nullable: false));
            AlterColumn("dbo.Sales", "PaymentType", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Role_UserRoleId");
        }
    }
}

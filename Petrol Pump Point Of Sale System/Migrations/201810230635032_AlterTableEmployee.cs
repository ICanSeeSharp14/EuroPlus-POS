namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsActive");
        }
    }
}

namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableEmployeeDropSetterOfFullNameField : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "FullName", c => c.String());
        }
    }
}

namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableEmployeesAddFullNameColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "FullName");
        }
    }
}

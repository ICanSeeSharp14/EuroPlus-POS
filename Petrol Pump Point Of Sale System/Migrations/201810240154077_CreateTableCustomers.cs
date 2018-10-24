namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateTimeCreated", c => c.DateTime());
            AddColumn("dbo.Customers", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "DateTimeModified", c => c.DateTime());
            AddColumn("dbo.Customers", "ModifiedBy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ModifiedBy");
            DropColumn("dbo.Customers", "DateTimeModified");
            DropColumn("dbo.Customers", "CreatedBy");
            DropColumn("dbo.Customers", "DateTimeCreated");
        }
    }
}

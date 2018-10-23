namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSomething : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        ContactNo = c.String(),
                        IsActive = c.Boolean(nullable: true),
                        DateTimeCreated = c.DateTime(),
                        CreatedBy = c.Int(nullable: true),
                        DateTimeModified = c.DateTime(),
                        ModifiedBy = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "DateTimeCreated", c => c.DateTime());
            AddColumn("dbo.Employees", "CreatedBy", c => c.Int(nullable: true));
            AddColumn("dbo.Employees", "DateTimeModified", c => c.DateTime());
            AddColumn("dbo.Employees", "ModifiedBy", c => c.Int(nullable: true));
            AddColumn("dbo.Users", "CreatedBy", c => c.Int(nullable: true));
            AddColumn("dbo.Users", "DateTimeModified", c => c.DateTime());
            AddColumn("dbo.Users", "ModifiedBy", c => c.Int(nullable: true));
            AddColumn("dbo.UserRoles", "CreatedBy", c => c.Int(nullable: true));
            AddColumn("dbo.UserRoles", "DateTimeModified", c => c.DateTime());
            AddColumn("dbo.UserRoles", "ModifiedBy", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserRoles", "ModifiedBy");
            DropColumn("dbo.UserRoles", "DateTimeModified");
            DropColumn("dbo.UserRoles", "CreatedBy");
            DropColumn("dbo.Users", "ModifiedBy");
            DropColumn("dbo.Users", "DateTimeModified");
            DropColumn("dbo.Users", "CreatedBy");
            DropColumn("dbo.Employees", "ModifiedBy");
            DropColumn("dbo.Employees", "DateTimeModified");
            DropColumn("dbo.Employees", "CreatedBy");
            DropColumn("dbo.Employees", "DateTimeCreated");
            DropTable("dbo.Suppliers");
        }
    }
}

namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 60),
                        Description = c.String(),
                        Unit = c.String(maxLength: 30),
                        Quantity = c.Int(nullable: false),
                        SalesRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTimeCreated = c.DateTime(),
                        CreatedBy = c.Int(nullable: false),
                        DateTimeModified = c.DateTime(),
                        ModifiedBy = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RateHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        PreviousRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTimeModified = c.DateTime(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        SalesInvoiceId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        SalesRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTimeSold = c.DateTime(),
                        PaymentType = c.Byte(nullable: false),
                        SalesType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.SalesInvoices", t => t.SalesInvoiceId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.SalesInvoiceId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeCode = c.String(maxLength: 15),
                        FirstName = c.String(maxLength: 40),
                        LastName = c.String(maxLength: 50),
                        Address = c.String(),
                        ContactNo = c.String(maxLength: 15),
                        DateApplied = c.DateTime(),
                        DateHired = c.DateTime(),
                        DateResigned = c.DateTime(),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PositionCode = c.String(maxLength: 15),
                        PositionName = c.String(maxLength: 80),
                        Description = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesInvoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceNo = c.String(maxLength: 20),
                        TotalQuantity = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountTendered = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Changed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(),
                        CustomerName = c.String(),
                        ContactNo = c.String(),
                        Address = c.String(),
                        VehicleType = c.String(),
                        VehicleNo = c.String(),
                        BankName = c.String(),
                        BankAccountNo = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        AccessType = c.Int(nullable: false),
                        UserType = c.Byte(nullable: false),
                        RoleId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        DateTimeCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserRoleName = c.String(maxLength: 50),
                        RoleDescription = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        DateTimeCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.UserRoles");
            DropForeignKey("dbo.Sales", "SalesInvoiceId", "dbo.SalesInvoices");
            DropForeignKey("dbo.SalesInvoices", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Sales", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.RateHistory", "ProductId", "dbo.Products");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.SalesInvoices", new[] { "CustomerId" });
            DropIndex("dbo.Employees", new[] { "PositionId" });
            DropIndex("dbo.Sales", new[] { "SalesInvoiceId" });
            DropIndex("dbo.Sales", new[] { "EmployeeId" });
            DropIndex("dbo.RateHistory", new[] { "ProductId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.Customers");
            DropTable("dbo.SalesInvoices");
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
            DropTable("dbo.Sales");
            DropTable("dbo.RateHistory");
            DropTable("dbo.Products");
        }
    }
}

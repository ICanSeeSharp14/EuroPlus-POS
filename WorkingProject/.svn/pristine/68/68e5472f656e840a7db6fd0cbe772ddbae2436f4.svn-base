namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        PositionCode = c.String(maxLength: 15),
                        PositionName = c.String(maxLength: 80),
                        Description = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ExpenseId = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.ExpenseId);
            
            CreateTable(
                "dbo.Liquidations",
                c => new
                    {
                        LiquidationId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        PumpId = c.Int(nullable: false),
                        InitialReading = c.Int(nullable: false),
                        FinalReading = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalLiterSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmountSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LiquidationDate = c.DateTime(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.LiquidationId);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ModuleId = c.Int(nullable: false, identity: true),
                        ModuleName = c.String(),
                        ObjectName = c.String(),
                        Description = c.String(),
                        ModuleType = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ModuleId);
            
            CreateTable(
                "dbo.PurchaseOrderDetails",
                c => new
                    {
                        PurchaseDetailsId = c.Int(nullable: false, identity: true),
                        VendorId = c.Int(nullable: false),
                        PurchaseNo = c.String(),
                        DateTimeReceived = c.DateTime(),
                        DatePurchased = c.DateTime(),
                    })
                .PrimaryKey(t => t.PurchaseDetailsId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(nullable: false, maxLength: 15),
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
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Pumps",
                c => new
                    {
                        PumpId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        PumpCode = c.String(),
                        InitialReading = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PumpId);
            
            CreateTable(
                "dbo.PurchaseInvoices",
                c => new
                    {
                        PurchaseInvoiceId = c.Int(nullable: false, identity: true),
                        DateTimePurchased = c.Int(nullable: false),
                        PurchaseAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReceivedBy = c.Int(nullable: false),
                        PurchaseDetails = c.String(),
                        BankAccountNumber = c.String(),
                    })
                .PrimaryKey(t => t.PurchaseInvoiceId);
            
            CreateTable(
                "dbo.PurchaseOrders",
                c => new
                    {
                        PurchaseOrderId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DatePurchased = c.DateTime(nullable: false),
                        DateTimeReceived = c.DateTime(nullable: false),
                        TransactBy = c.Int(nullable: false),
                        PurchaseType = c.Int(nullable: false),
                        BankName = c.String(),
                        DriverDetails = c.String(),
                    })
                .PrimaryKey(t => t.PurchaseOrderId);
            
            CreateTable(
                "dbo.RateHistory",
                c => new
                    {
                        RateHistoryId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        PreviousRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTimeModified = c.DateTime(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RateHistoryId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        SalaryId = c.Int(nullable: false, identity: true),
                        SalaryAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SalaryId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SalesId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        SalesInvoiceId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        SalesRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTimeSold = c.DateTime(),
                        PaymentType = c.Int(nullable: false),
                        SalesType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalesId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.SalesInvoices", t => t.SalesInvoiceId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.SalesInvoiceId);
            
            CreateTable(
                "dbo.SalesInvoices",
                c => new
                    {
                        SalesInvoiceId = c.Int(nullable: false, identity: true),
                        InvoiceNo = c.String(maxLength: 20),
                        TotalQuantity = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountTendered = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Changed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalesInvoiceId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        AccessType = c.Int(nullable: false),
                        UserType = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        DateTimeCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UsersAccess",
                c => new
                    {
                        UserAccessId = c.Int(nullable: false, identity: true),
                        ModuleId = c.Int(nullable: false),
                        UserRoleId = c.Int(nullable: false),
                        IsView = c.Boolean(nullable: false),
                        IsSave = c.Boolean(nullable: false),
                        IsUpdate = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        IsAll = c.Boolean(nullable: false),
                        DateTimeCreated = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserAccessId)
                .ForeignKey("dbo.Modules", t => t.ModuleId, cascadeDelete: true)
                .ForeignKey("dbo.UserRoles", t => t.UserRoleId, cascadeDelete: true)
                .Index(t => t.ModuleId)
                .Index(t => t.UserRoleId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleId = c.Int(nullable: false, identity: true),
                        UserRoleName = c.String(maxLength: 50),
                        RoleDescription = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        DateTimeCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserRoleId);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        VendorCode = c.Int(nullable: false),
                        VendorName = c.String(),
                        VendorAddress = c.String(),
                        ContactNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VendorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersAccess", "UserRoleId", "dbo.UserRoles");
            DropForeignKey("dbo.UsersAccess", "ModuleId", "dbo.Modules");
            DropForeignKey("dbo.Sales", "SalesInvoiceId", "dbo.SalesInvoices");
            DropForeignKey("dbo.SalesInvoices", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Sales", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.RateHistory", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Employees", "PositionId", "dbo.Positions");
            DropIndex("dbo.UsersAccess", new[] { "UserRoleId" });
            DropIndex("dbo.UsersAccess", new[] { "ModuleId" });
            DropIndex("dbo.SalesInvoices", new[] { "CustomerId" });
            DropIndex("dbo.Sales", new[] { "SalesInvoiceId" });
            DropIndex("dbo.Sales", new[] { "EmployeeId" });
            DropIndex("dbo.RateHistory", new[] { "ProductId" });
            DropIndex("dbo.Employees", new[] { "PositionId" });
            DropTable("dbo.Vendors");
            DropTable("dbo.UserRoles");
            DropTable("dbo.UsersAccess");
            DropTable("dbo.Users");
            DropTable("dbo.SalesInvoices");
            DropTable("dbo.Sales");
            DropTable("dbo.Salaries");
            DropTable("dbo.RateHistory");
            DropTable("dbo.PurchaseOrders");
            DropTable("dbo.PurchaseInvoices");
            DropTable("dbo.Pumps");
            DropTable("dbo.Products");
            DropTable("dbo.PurchaseOrderDetails");
            DropTable("dbo.Modules");
            DropTable("dbo.Liquidations");
            DropTable("dbo.Expenses");
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}

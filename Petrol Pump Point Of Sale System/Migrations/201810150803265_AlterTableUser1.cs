namespace Petrol_Pump_Point_Of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableUser1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductCode", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductCode");
        }
    }
}

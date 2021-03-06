﻿using System.Data.Entity;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DbConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modeBuilder)
        {
            //modeBuilder.Entity<Employee>().MapToStoredProcedures();
           
        }

        public virtual DbSet<User> Users { get; set; }

        //public virtual DbSet<Salary> Salary { get; set; }
        //public virtual DbSet<UserAccess> UsersAccess { get; set; }
        public virtual DbSet<UserRole> UsersRole { get; set; }
        //public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        //public virtual DbSet<Module> Modules { get; set;}
        public virtual DbSet<Employee> Employees { get; set; }
        //public virtual DbSet<Liquidation> Liquidations { get; set; }
        //public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        //public virtual DbSet<PurchaseOrderDetails> OrderDetails { get; set; }
        public virtual DbSet<ProductRateHistory> RateHistory { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        //public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }
        //public virtual DbSet<Pump> Pumps { get; set; }
        //public virtual DbSet<Position> Positions { get; set; }
        //public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }

        //public virtual DbSet<Expense> Expenses { get; set; }
    }
}

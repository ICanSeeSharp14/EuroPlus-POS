using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product> , IProductRepository
    {

        public DatabaseContext DatabaseContext => Context as DatabaseContext;
       

        public ProductRepository(DatabaseContext context) : base(context)
        {
            
        }

        public bool IsProductExist(string productName)
        {
            var product = GetProduct(productName);
            return product == null;
        }

        public Product GetProduct(string productName)
        {
            var product = DatabaseContext
                         .Products
                         .SingleOrDefault(p => p.ProductName == productName);
            return product;
        }

        public virtual void Save(string productCode, string productName, string description, string unit,
            decimal saleRate,
            decimal purchaseRate, int performedBy = 1)
        {
            var newProduct = new Product()
            {
                ProductCode = productCode,
                ProductName = productName,
                Description = description,
                SalesRate = saleRate,
                PurchaseRate = purchaseRate,
                Unit = unit,
                CreatedBy = performedBy,
                IsActive = true,
                DateTimeCreated = DateTime.Now
            };

            DatabaseContext.Products.Add(newProduct);
            
        }


        public virtual void Update(string productCode, string productName, string description, string unit, decimal saleRate,
            decimal purchaseRate, int performedBy = 1, int productId = 0)
        {
            var product = DatabaseContext.Products.Find(productName);
            if (product == null) return;
            product.ProductName = productName;
            product.ProductCode = productCode;
            product.SalesRate = saleRate;
            product.PurchaseRate = purchaseRate;
            product.Unit = unit;
            product.ModifiedBy = 1;
            product.DateTimeModified = DateTime.Now;

        }

        
        public  IEnumerable<dynamic> GetAll(string filterValue = "", int pageIndex = 1, int pageSize = 50)
        {
            return  DatabaseContext
                    .Products
                    .Where(p => p.ProductName.Contains(filterValue) ||
                                p.ProductCode.Contains(filterValue) &&
                                p.IsActive)
                    .OrderByDescending(p => p.ProductId)
                    .Select(p => new
                    {
                        Id = p.ProductId,
                        Code = p.ProductCode,
                        Name = p.ProductName,
                        p.Description,
                        SellingPrice = p.SalesRate,
                        PurchasePrice = p.PurchaseRate,
                        p.Unit
                    }).Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

        }

        public int CountProduct(bool isActive = true)
        {
            return DatabaseContext.Products.Count(p => p.IsActive);
        }


        public List<Product> GetAllActiveProducts(int pageIndex = 1, int pageSize = 50)
        {
            return   DatabaseContext.Products
                    .Where(p => p.IsActive)
                    .OrderBy(p => p.ProductId)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
        }

        public void Delete(int productId)
        {
            var product = DatabaseContext.Products.SingleOrDefault(p => p.ProductId == productId);
            if (product != null) DatabaseContext.Products.Remove(product);
        }


        public async Task<IEnumerable<dynamic>> GetProductRateHistory(DateTime dateFrom, DateTime dateTo)
        {
            return await DatabaseContext.Products.Where(p => p.IsActive)
                        .Join(DatabaseContext.RateHistory,
                            p => p.ProductId, r => r.RateHistoryId
                            , (p, r) => new
                            {
                                Id = p.ProductId,
                                Code = p.ProductCode,
                                p.ProductName,
                                CurrentRate = p.SalesRate,
                                r.PreviousRate,
                                r.ModifiedBy,
                                r.DateTimeModified
                            }).ToListAsync();
        }

        
    }
 }

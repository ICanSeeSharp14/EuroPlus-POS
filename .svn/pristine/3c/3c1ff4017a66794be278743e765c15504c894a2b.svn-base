using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        bool IsProductExist(string productName);

        Product GetProduct(string productName);

        void Save(string productCode, string productName, string description, string unit,
            decimal saleRate, decimal purchaseRate, int performedBy = 1);

        void Update(string productCode, string productName, string description, string unit,
            decimal saleRate, decimal purchaseRate, int performedBy = 1, int productId = 0);

        IEnumerable<dynamic> GetAll(string filterValue = "",int pageIndex = 1, int pageSize = 50);

        int CountProduct(bool isActive = true);
        List<Product> GetAllActiveProducts(int pageIndex = 1, int pageSize = 50);
        void Delete(int productId);

        Task<IEnumerable<dynamic>> GetProductRateHistory(DateTime dateFrom,DateTime dateTo);


    }
}

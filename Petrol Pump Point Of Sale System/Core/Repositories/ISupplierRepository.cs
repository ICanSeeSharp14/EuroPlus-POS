using System.Collections.Generic;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        bool IsExist(string supplierName);
        bool IsExist(string supplierName,int supplierId);
        IEnumerable<Supplier> GetAll(string getSearchedValue, int getCurrentPage, int getRecordsPerPage);
    }
}
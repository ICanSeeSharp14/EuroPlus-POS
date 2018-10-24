using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
        public SupplierRepository(DatabaseContext context) : base(context)
        {
        }

        public bool IsExist(string supplierName)
        {
            return DatabaseContext.Suppliers.Count(s => s.SupplierName == supplierName) == 1;
        }

        public bool IsExist(string supplierName, int supplierId)
        {
            return DatabaseContext.Suppliers.Count(s => s.SupplierName == supplierName && 
                                                        s.Id != supplierId) == 1;

        }

        public IEnumerable<Supplier> GetAll(string getSearchedValue, int getCurrentPage, int getRecordsPerPage)
        {
            throw new NotImplementedException();
        }
    }
}

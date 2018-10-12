using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Entities;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
        public CustomerRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<dynamic> GetAll(string filterValue = "", int pageIndex = 1, int pageSize = 50)
        {
            return DatabaseContext.Customers
                .OrderBy(c => c.CustomerId)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}

using System.Linq;
using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public CustomerRepository(DatabaseContext context) : base(context)
        {
        }

     
        public bool IsExist(string customerName)
        {
            return DatabaseContext.Customers
                       .Count(c => c.CustomerName == customerName) == 1;
        }

        public bool IsExist(string customerName, int customerId)
        {
            return DatabaseContext.Customers
                       .Count(c => c.CustomerName == customerName && c.Id != customerId) == 1;
        }
    }
}
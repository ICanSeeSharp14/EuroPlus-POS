using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        bool IsExist(string customerName);
        bool IsExist(string customerName, int customerId);
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Entities;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        IEnumerable<dynamic> GetAll(string filterValue = "", int pageIndex = 1, int pageSize = 50);

    }
}

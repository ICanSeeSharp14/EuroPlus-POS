using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Entities;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class RoleRepository : GenericRepository<UserRole> , IRoleRepository
    {
        public RoleRepository(DatabaseContext context) : base(context)
        {

        }
    }
}

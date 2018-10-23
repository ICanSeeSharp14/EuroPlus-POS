
using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class PumpAttendantRepository : Repository<Employee>, IPumpAttendantRepository
    {
        public PumpAttendantRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
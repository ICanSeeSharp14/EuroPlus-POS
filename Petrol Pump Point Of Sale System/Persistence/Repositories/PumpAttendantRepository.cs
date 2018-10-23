
using System.Linq;
using Petrol_Pump_Point_Of_Sale_System.Core.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories
{
    public class PumpAttendantRepository : Repository<Employee>, IPumpAttendantRepository
    {
        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public PumpAttendantRepository(DatabaseContext context) : base(context)
        {
        }

        public bool AttendantNameAlreadyExist(string attendantName)
        {
            return DatabaseContext.Employees
                       .Count(e => e.FullName == attendantName) == 1;
        }

        public bool AttendantNameAlreadyExist(string attendantName, int attendantId)
        {
            return DatabaseContext.Employees
                       .Count(e => e.FullName == attendantName && e.Id != attendantId) == 1;
        }
    }
}
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface IPumpAttendantRepository : IRepository<Employee>
    {
       
        bool AttendantNameAlreadyExist(string attendantName);
        bool AttendantNameAlreadyExist(string attendantName, int attendantId);
    }
}
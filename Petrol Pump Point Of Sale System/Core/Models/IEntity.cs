namespace Petrol_Pump_Point_Of_Sale_System.Core.Models
{
    public interface IEntity
    {
        int Id { get; }
        bool IsActive { get; set; }
    }
}
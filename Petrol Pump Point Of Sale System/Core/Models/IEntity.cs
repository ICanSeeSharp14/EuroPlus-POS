using System;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Models
{
    public interface IEntity
    {
        int Id { get; set; }
        bool IsActive { get; set; }

        DateTime? DateTimeCreated { get; set; }
        int CreatedBy { get; set; }

        DateTime? DateTimeModified { get; set; }

        int ModifiedBy { get; set; }
    }
}
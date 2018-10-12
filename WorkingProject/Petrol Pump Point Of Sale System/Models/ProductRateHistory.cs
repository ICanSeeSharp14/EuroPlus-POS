using Petrol_Pump_Point_Of_Sale_System.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Petrol_Pump_Management_System.Entities
{
    [Table("RateHistory")]
    public class ProductRateHistory
    {
        [Key]
        public int RateHistoryId { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public decimal PreviousRate { get; set; }
        
        public DateTime DateTimeModified { get; set; }

        public int ModifiedBy { get; set; }
    }
}

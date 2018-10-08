using System;
using System.ComponentModel.DataAnnotations;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{

    public class Product 
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(15)]
        [Required]
        public string ProductCode { get; set; }

        [Required]
        [StringLength(60)]
        public string ProductName { get; set; }

        public string Description { get; set; }

        [StringLength(30)]
        public string Unit { get; set; }

        public int Quantity { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal SalesRate { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal PurchaseRate { get; set; }

        public decimal Discount { get; set; }

        public DateTime? DateTimeCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }

        public int ModifiedBy { get; set; }

        public bool IsActive { get; set; }

    }
}

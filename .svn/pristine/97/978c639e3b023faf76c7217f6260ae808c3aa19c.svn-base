using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;
using Petrol_Pump_Point_Of_Sale_System.Core.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class Products : IEntity
    {
        [Key]
        public int Id { get; set; }
        //public int Id {
        //    get { return ProductId; }
        //}


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

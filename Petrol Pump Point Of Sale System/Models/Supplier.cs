using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Core.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class Supplier : IEntity
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }
         public int CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public int ModifiedBy { get; set; }
    }
}

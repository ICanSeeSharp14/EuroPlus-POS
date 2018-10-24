using System;
using System.ComponentModel.DataAnnotations;
using Petrol_Pump_Point_Of_Sale_System.Core.Models;
using Petrol_Pump_Point_Of_Sale_System.View;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class Customer : IEntity
    {
        private bool _isActive;

        [Key]
        public int Id { get; set; }

        public string   CustomerCode { get;set; }

        public string CustomerName { get; set; }

        public string ContactNo { get; set; }
        public string Address { get; set; }

        public string VehicleType { get; set; }

        public string VehicleNo { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }


        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                _isActive = true;
            }
        }

        public DateTime? DateTimeCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? DateTimeModified { get; set; }
        public int ModifiedBy { get; set; }
    }
}

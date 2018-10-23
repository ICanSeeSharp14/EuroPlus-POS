﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Petrol_Pump_Point_Of_Sale_System.Core.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class Employee : IEntity
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(15)]
        public string EmployeeCode { get; set; }
      
        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }
        public string Address { get;set; }

        [StringLength(15)]
        public string ContactNo { get; set; }

        public DateTime? DateApplied { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? DateResigned { get; set; }
        public int PositionId { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }
        
 
    }
}

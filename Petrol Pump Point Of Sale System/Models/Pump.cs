﻿using System.ComponentModel.DataAnnotations;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class Pump
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }

        public string PumpCode { get; set; }

        public decimal InitialReading { get; set; }



    }
}

﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class Liquidation
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public int PumpId { get; set; }
        public int InitialReading { get; set; }
        public decimal FinalReading { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalLiterSales { get; set; }
        public decimal TotalAmountSales { get; set; }
        public DateTime? LiquidationDate { get; set; }
        public string Notes { get; set; }


    }
}

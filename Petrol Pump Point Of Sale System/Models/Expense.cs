﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        public string ExpenseName { get; set; }

        public decimal Amount { get; set; }

        public string Notes { get; set; }
        public DateTime? Date { get; set; }
    }
}

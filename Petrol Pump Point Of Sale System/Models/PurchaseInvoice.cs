﻿using System.ComponentModel.DataAnnotations;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class PurchaseInvoice
    {
        [Key]
        public int Id { get; set; }

        public int DateTimePurchased { get; set; }

        public decimal PurchaseAmount { get; set; }

        public int ReceivedBy { get; set; }
        public string PurchaseDetails { get; set; }
        public string BankAccountNumber { get; set; }

    }
}

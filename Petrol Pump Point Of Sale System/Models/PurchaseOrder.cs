﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderId { get; set; }

        public int ProductId { get; set; }
        //public string InvoiceNo { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePurchased { get; set; }
        public DateTime DateTimeReceived { get; set; }
        public int TransactBy { get; set; }
        public int PurchaseType { get; set; }
        public string BankName { get; set; }
        public string DriverDetails { get; set; }


    }
}

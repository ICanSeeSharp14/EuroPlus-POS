﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class Sale
    {

        [Key]
        public int SalesId { get; set; }

        public int ProductId { get; set; }
        
        public int EmployeeId { get; set; }

        //public int CustomerId { get; set; }

        public int SalesInvoiceId { get; set; }    

        public int Quantity { get; set; }

        public decimal SalesRate { get; set; }
        public decimal PurchaseRate { get; set; }

        public decimal Discount { get; set; }

        public DateTime? DateTimeSold { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        
        //[ForeignKey("ProductId")]
        //public virtual Product Product { get; set; }

        [ForeignKey("SalesInvoiceId")]
        public virtual SalesInvoice SalesInvoice { get; set; }

        public PaymentType PaymentType { get; set; }

        public SalesType SalesType { get; set; }
    }
}

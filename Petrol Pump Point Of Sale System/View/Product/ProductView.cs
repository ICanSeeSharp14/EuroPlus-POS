﻿using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Models;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;

namespace Petrol_Pump_Point_Of_Sale_System.View.Product
{
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
            Initialize();  
        }

        private void ProductView_Load(object sender, System.EventArgs e)
        {
          
        }

        
        private void btnSaveChanges_Click(object sender, System.EventArgs e)
        {
            SaveChanges();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            CancelChanges();
        }
    }
}

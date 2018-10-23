﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Core.Models;

namespace Petrol_Pump_Point_Of_Sale_System.View.Account
{
    public partial class AccountView : UserControl, IModule
    {
        public AccountView()
        {
            InitializeComponent();
            Initialize();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
          

        }

        private void LnkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flatTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetAccountDetailsById();
        }

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            //GetAccountDetailsById();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAccountInformation();
        }

      

        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DeActivateAccount();
        }

        private void dgvDeletedUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            CreateAccount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnActivateAccount_Click(object sender, EventArgs e)
        {
            ActivateAccount();
        }

        private void btnPermanentDelete_Click(object sender, EventArgs e)
        {
            DeleteAccount();
        }

        public UserControl Instance()
        {
            return this;
        }
    }
}

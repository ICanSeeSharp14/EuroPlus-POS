﻿using Petrol_Pump_Point_Of_Sale_System.Models;

using Petrol_Pump_Point_Of_Sale_System.View.Account;
using System.Collections.Generic;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Core;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Extensions;
using Petrol_Pump_Point_Of_Sale_System.View.Custom;
using Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Pump_Attendant;
using Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Supplier;
using Petrol_Pump_Point_Of_Sale_System.View.POS;
using Petrol_Pump_Point_Of_Sale_System.View.Product;
using Petrol_Pump_Point_Of_Sale_System.View.Home;
using Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Customers;
using CustomerView = Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Customers.CustomerView;

namespace Petrol_Pump_Point_Of_Sale_System.View.Main
{
    public partial class MainView
    {
        

        private void Initialize() => HomePage();


        private List<Modules> GetManageModules()
        {
            return new List<Modules>
            {
                new Modules { Title = "Home", Instance = new DashboardView(), Tab = tpHome},
                new Modules { Title = "Account", Instance =  new AccountView() , Tab = tpManageAccount},
                new Modules { Title = "Product", Instance =  new ProductView(),Tab = tpManageProduct},
                new Modules { Title = "Customer", Instance =  new CustomerView() , Tab = tpManageCustomers},
                new Modules { Title = "Pump Attendant", Instance =  new PumpAttendantView() , Tab = tpManagePumpAttendants},
                new Modules { Title = "Supplier", Instance =  new SupplierView() , Tab = tpManageSuppliers},

            };
        }

        private List<Modules> GetReportModules()
        {
            return new List<Modules>
            {
                new Modules { Title = "Sales", Instance =  new AccountView() },
                new Modules { Title = "Inventory", Instance = new Account.AccountView() },
                new Modules { Title = "Logs", Instance =  new Account.AccountView() },
            };
        }
      
        private void GetCurrentDateTime()
        {
            //lblDateTime.Text = @"{DateTime.Now.ToString("MMM dd")}} • {{DateTime.Now.ToString("hh:mm tt")}";
        }

        public void FillUserDetails()
        {
           // btnProfile.Text = @"Good Day, {AccountSession.GetAccount.FirstName}!";

            GetCurrentDateTime();
        }

        #region Navigation

        private void Home()
        {
            SetTitle("Home");

            CreateNavigationContents(null);
            tcMenu.SelectTab(tpHome);
        }

        private void Manage()
        {
            SetTitle("Manage");
            CreateNavigationContents(GetManageModules());
        }

        private void Reports()
        {
            SetTitle("POS");

            CreateNavigationContents(null);
        }

        private void Settings()
        {
            SetTitle("Settings");

            CreateNavigationContents(null);
        }

        private void Support()
        {
            CreateNavigationContents(null);

        }

        private void HomePage()
        {
            SetTitle("Dash Board");
            Notification.Show("testing  notification");
            tcMenu.SelectTab(tpHome);
            CreateNavigationContents(null);

        }
        private void POS()
        {
            SetTitle("Point Of Sales");
            tcMenu.SelectTab(tpPointOfSale);
            Notification.Show("testing  notification");

            ClearContents();

            //var pos = new PointOfSaleView();

            //pnlBody.Controls.Add(pos);

            //pos.Dock = DockStyle.Fill;

            CreateNavigationContents(null);
        }

        private void SetTitle(string title)
        {
            lblModuleTitle.Text = title;
        }

        #endregion

        #region Modules

        private void CreateNavigationContents(List<Modules> modules)
        {
            var list = modules;
            if (list == null)
            {
                pnlSubNavigation.Hide();
                return;
            }

            pnlSubNavigation.Show();

            pnlSubNavigation.Initialize(modules);

            pnlSubNavigation.NavigationButtonClicked += (s, e) =>
            {
                ShowModule();
            };
        }

       
        private void ShowModule()
        {
            //ClearContents();
            SetSelectedTab();
            SetModuleTitle();

            //CreateModuleInstance();
        }

        private void CreateModuleInstance()
        {
            var module = pnlSubNavigation.SelectedModule.Instance();

            pnlBody.Controls.Add(module);

            module.Dock = DockStyle.Fill;
        }

        private void SetSelectedTab()
        {
            tcMenu.SelectedTab = pnlSubNavigation.SelectedTabPage;
        }
        private void SetModuleTitle()
        {
            lblModuleTitle.Text = pnlSubNavigation.SelectedTitle;
        }

        private void ClearContents()
        {
           //pnlBody.Controls.Clear();
        }

        #endregion

        #region Sign Off

        private void LockScreen()
        {
            this.Hide();

            //var form = new LockScreenView();
            //form.Show();

            //form.FormClosed += (s, e) => { this.Show(); };
        }

        private bool Logout()
        {
            if (!LogoutMessage()) return false;

            //_isLogout = true;

            return true;
        }

        private bool LogoutMessage()
        {
            return FlatMessageBox.Show("Do you want to logout?", "Logout", DialogButtons.YesNo, DialogType.Info) == DialogButton.Yes
                ? true
                : false;
        }

        private bool ExitApplication()
        {
            if (ExitMessage())
            {
                System.Environment.Exit(0);
            }

            return false;
        }

        private bool ExitMessage()
        {
            return FlatMessageBox.Show("Do you want to exit?", "Exit", DialogButtons.YesNo, DialogType.Info) == DialogButton.Yes
                ? true
                : false;
        }

        #endregion
    }
}
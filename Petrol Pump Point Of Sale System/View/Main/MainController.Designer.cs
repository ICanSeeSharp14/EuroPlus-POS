using System;
using Petrol_Pump_Point_Of_Sale_System.Models;

using Petrol_Pump_Point_Of_Sale_System.View.Account;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Components;
using Petrol_Pump_Point_Of_Sale_System.Core;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Extensions;
using Petrol_Pump_Point_Of_Sale_System.View.POS;
using Petrol_Pump_Point_Of_Sale_System.View.Products;

namespace Petrol_Pump_Point_Of_Sale_System.View.Main
{
    public partial class MainView
    {
        private bool _isLogout = false;
        private Modules _selectedModule = new Modules();

       
        private ProductView ShowProductView() 
           
        {
            return new ProductView();
        }
     
        private  void Initialize()
        {
            var product = new ProductView();
            tpManageProduct.Controls.Add(product);
            product.Dock = DockStyle.Fill;

        }
        public string SelectedTitle
        {
            get { return _selectedModule.Title; }
        }

        public TabPage SelectedTabPage
        {
            get { return _selectedModule.SelectTab; }
        }
        private void SetSelectedButtonProperties(FlatButton button)
        {
            button.BackColorOnDefault = ColorHelper.FlatYellowNormal;
            button.BackColorOnHover = ColorHelper.FlatYellowNormal;
            button.BackColorOnClick = ColorHelper.FlatYellowNormal; 

            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }
        private List<Modules> GetManageModules()
        {
            return new List<Modules>
            {
                new Modules { Title = "Consumables", SelectTab = tabPage10},
                new Modules { Title = "Accounts", SelectTab =  tpManageAccount },
                new Modules { Title = "Products", SelectTab = tpManageProduct },
            };
        }

        //private static List<Modules> GetReportModules()
        //{
        //    return new List<Modules>
        //    {
        //        new Modules { Title = "Sales", Instance =  new AccountView() },
        //        new Modules { Title = "Inventory", Instance = new AccountView() },
        //        new Modules { Title = "Logs", Instance =  new AccountView() },
        //    };
        //}
      
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
        }

        private void Manage()
        {
            CreateNavigationContents(GetManageModules());
        }

        //private void SetSubNavigationButtonProperties()
        //{
        //    foreach (var button in tcSubNavigation.Controls)
        //    {
        //        if (button is FlatButton)
        //        {
        //            var btn = (FlatButton) button;
        //            btn.Margin = new Padding(0, 0, 4, 2);
        //            btn.Height = 50;
        //            btn.Width = 196;
        //            btn.TabStop = false;
        //        }
        //    }
        
        //}
        private void Reports()
        {
            CreateNavigationContents(null);
        }

        private void Settings()
        {
            CreateNavigationContents(null);
        }

        private void Support()
        {
            CreateNavigationContents(null);

        }

        private void POS()
        {
            SetTitle("Point Of Sales");

            ClearContents();

            var pos = new PointOfSaleView();

            pnlBody.Controls.Add(pos);

            pos.Dock = DockStyle.Fill;

            CreateNavigationContents(null);
        }

        private void SetTitle(string title)
        {
            lblModuleTitle.Text = title;
        }

        #endregion

        #region Modules

        private void CreateManageNavigationContent(List<Modules> modules)
        {
            pnlSubNavigation.Show();
           
        }
        private void CreateNavigationContents(List<Modules> modules)
        {

            var list = modules;
            if (list == null)
            {
                pnlSubNavigation.Hide();
                return;
            }
            pnlSubNavigation.Show();
            navigationView.Initialize(modules);
            navigationView.NavigationButtonClicked += (s, e) =>
            {
                ShowModule();
            };
        }

       
        private void ShowModule()
        {
            SetModuleTitle();
            CreateModuleInstance();
        }

        private void CreateModuleInstance()
        {
            var module = navigationView.SelectedTabPage;

            tcMenu.SelectTab(module);

            //module.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void SetModuleTitle()
        {
            lblModuleTitle.Text = navigationView.SelectedTitle;
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

            _isLogout = true;

            return true;
        }

        private bool LogoutMessage()
        {
            return FlatMessageBox.Show("Do you want to logout?", "Logout", DialogButtons.YesNo, DialogType.Info) == DialogButton.Yes
                ? true
                : false;
        }

        private bool Exit()
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
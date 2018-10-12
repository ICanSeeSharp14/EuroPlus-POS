﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Components;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.View.Account
{
    public partial class AccountView
    {
       

        private void Initialize()
        {
            InitializeEvent();
            InitializeButtonTabEvent();
           //paginator.SetRecordsPerPage(3);
            //SetTotalPage();
            //GetAccounts();

        }
        private void InitializeButtonTabEvent()
        {
            SetProductButtonTabEvent();
        }

      

        private void InitializeEvent()
        {
            paginator.PageNavigationButtonClicked += (s, e) =>
            {
                GetAccounts();
            };
            paginator.RefreshButtonClicked += (s, e) =>
            {
                GetAccounts();
            };

            paginator.RecordCountChanged += (s, e) =>
            {
                SetTotalPage();
                GetAccounts();
            };


        }

        private void SetTotalPage()
        {
            paginator.SetMaxPage(new DatabaseContext().Users.Count(p => p.IsActive));
        }
        private void SetProductButtonTabEvent()
        {
            var controls = tlpAccountButtonTab.Controls.Cast<Control>().ToList();

            foreach (var control in controls)
            {
                if (control is FlatButton)
                {
                    var button = control as FlatButton;
                    button.Click += (s, e) =>
                    {
                        SelectButtonTab(button);
                        GetSelectedTab(button);

                    };
                }
            }
        }

        private void SelectButtonTab(FlatButton button)
        {
            SelectedButtonTheme(button);
            DeselectProductTabButton(button);
        }

        private void DeselectProductTabButton(FlatButton button)
        {
            foreach (var control in tlpAccountButtonTab.Controls.Cast<Control>())
            {
                var currentButton = control as FlatButton;

                if (control is FlatButton && !currentButton.Equals(button))
                {
                    DeselectButtonTheme(currentButton);
                }
            }
        }

        private void SelectedButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatYellowNormal;
            button.BackColorOnHover = ColorHelper.FlatYellowNormal;
            button.BackColorOnClick = ColorHelper.FlatYellowNormal;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void GetSelectedTab(FlatButton button)
        {
            var selectedButton = button.Text;
            if (selectedButton != null)
                tcAccountMenu.SelectTab("tp" + selectedButton.Replace(" ", ""));
        }
        private void DeselectButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = Color.FromArgb(72, 72, 72);
            button.BackColorOnHover = Color.FromArgb(72, 72, 72);
            button.BackColorOnClick = Color.FromArgb(72, 72, 72);
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }
        public void GetAccounts()
        {
            using (var db = new DbRepository(new DatabaseContext()))
            {
                var accounts = db.Users.GetAll();
                dgvAccount.DataSource = accounts;
                
            }
        }
    }
}

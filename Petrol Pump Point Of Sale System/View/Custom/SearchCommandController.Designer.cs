﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.View.Custom
{
    public partial class SearchCommandView
    {
        private void Initialize()
        {
            ShowSearchBar = true;
            ShowActionButtons = true;
        }

        public string GetSearchedValue
        {
            get
            {
               return txtSearch.Text;
            }
        }
        public event EventHandler SearchButtonClicked
        {
          
            add { btnSearch.Click += value; }
            
            remove { btnSearch.Click -= value; }
            }
        public event KeyEventHandler FilterOnEnter
        {

            add { txtSearch.KeyDown += value; }

            remove { txtSearch.KeyDown -= value; }
        }



        public event EventHandler UnFilterOnClearText
        {
            
            add { txtSearch.TextChanged += value; }

            remove { txtSearch.TextChanged -= value; }
        }


        private bool _showSearchBar;

        [Category("Custom")]
        public bool ShowSearchBar
        {
            get
            {
                if (_showSearchBar) return true;
                return false;
            }
            set
            {
                if (pnlSearchBar.Visible = value) return;
            }
        }


        private void ShowSearch(bool visibility)
        {
            pnlSearchBar.Visible = visibility;
            btnSearch.Visible = visibility;
        }
       

        [Category("Custom")]
        public bool ShowActionButtons
        {
            get
            {
                if (pnlCommandButton.Visible) return true;
                return false;
            }
            set
            {
                if (pnlCommandButton.Visible = value) return;
            }
        }


        public event EventHandler AddButtonClicked
        {
            add
            {
                btnNew.Click += value;
             
            }
            remove
            {
                btnNew.Click -= value;
             
            }
        }

        public event EventHandler EditButtonClicked
        {
            add
            {
               
                btnEdit.Click += value;
            }
            remove
            {
              
                btnEdit.Click -= value;
            }
        }

        public event EventHandler DeleteButtonClicked
        {
            add
            {

                btnDelete.Click += value;
            }
            remove
            {

                btnDelete.Click -= value;
            }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Commons.Helper;
using Petrol_Pump_Point_Of_Sale_System.Models;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;
using Petrol_Pump_Point_Of_Sale_System.View.Product;

namespace Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Pump_Attendant
{
    public partial class PumpAttendantView
    {
        private void Initialize()
        {
            InitializeEvent();
            //ShowPumpAttendants();
        }

        #region Events
        private void InitializeEvent()
        {
            #region Pagination
            paginator.PageNavigationButtonClicked += (s, e) =>
            {
                ShowPumpAttendants();
            };
            paginator.RefreshButtonClicked += (s, e) =>
            {
                ShowPumpAttendants();
            };

            paginator.RecordCountChanged += (s, e) =>
            {
                SetTotalPage();
                ShowPumpAttendants();
            };

            paginator.PageNavigationButtonClicked += (s, e) =>
            {
                ShowPumpAttendants();
            };
            paginator.RefreshButtonClicked += (s, e) =>
            {
                ShowPumpAttendants();
            };

            paginator.RecordCountChanged += (s, e) =>
            {
                SetTotalPage();
                ShowPumpAttendants();
            };

            #endregion

            #region Command
            command.SearchButtonClicked += (s, e) =>
            {
                SetTotalPage();
                ShowPumpAttendants();
            };

            command.FilterOnEnter += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    paginator.ResetPage();
                    SetTotalPage();
                    ShowPumpAttendants();
                }

            };

            command.UnFilterOnClearText += (s, e) =>
            {
                if (command.GetSearchedValue == "")
                {
                    paginator.ResetPage();
                    SetTotalPage();
                    ShowPumpAttendants();
                }

            };
            command.AddButtonClicked += (s, e) =>
            {
                new CreateProductView().Show();
            };

            command.EditButtonClicked += (s, e) =>
            {
                EditPumpAttendant();
            };

            command.DeleteButtonClicked += (s, e) =>
            {
                DeletePumpAttendant();
            };

            #endregion
        }


#endregion

        #region Methods

        #region Get Methods
        private int GetPumpAttendantId()
        {
            var productId = int.Parse(ControlHelper
                .GetDataGridViewKey(dgvPumpAttendant, 0));
            return productId;
        }

        private IEnumerable<Employee> GetPumpAttendants()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                return repository.PumpAttendants.GetAll();

            }
        }

        #endregion

        #region Set Methods

        private void SetTotalPage()
        {
           
        }
        #endregion

        #region Show Methods

        private void ShowPumpAttendants()
        {
            bsPumpAttendants.DataSource = GetPumpAttendants();
        }
        #endregion

        #region CRUD
        private void DeletePumpAttendant()
        {

        }
        private void EditPumpAttendant()
        {

        }
        #endregion

        #endregion

    }
}

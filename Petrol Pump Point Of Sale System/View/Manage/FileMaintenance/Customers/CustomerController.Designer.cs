using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Commons.Helper;
using Petrol_Pump_Point_Of_Sale_System.Components;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Models;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;

namespace Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Customers
{
    public partial class CustomerView : ICommand
    {
        private void Initialize()
        {
            IsNew = true;
            InitializeEvent();
            InitializeButtonTabEvent();
            InitializeCustomerList();
        }
        private void InitializeCustomerList()
        {
            if (!bwCustomers.IsBusy)
            {
                bwCustomers.RunWorkerAsync();

            }
        }

        #region Events
        private void InitializeEvent()
        {
            #region Background Worker
            bwCustomers.DoWork += (s, e) => GetCustomers();
            bwCustomers.RunWorkerCompleted += (s, e) => ShowCustomers();
            #endregion

            #region Pagination
            paginator.PageNavigationButtonClicked += (s, e) =>
            {
                ShowCustomers();
            };
            paginator.RefreshButtonClicked += (s, e) =>
            {
                ShowCustomers();
            };

            paginator.RecordCountChanged += (s, e) =>
            {
                SetTotalPage();
                ShowCustomers();
            };

            paginator.PageNavigationButtonClicked += (s, e) =>
            {
                ShowCustomers();
            };
            paginator.RefreshButtonClicked += (s, e) =>
            {
                ShowCustomers();
            };

            paginator.RecordCountChanged += (s, e) =>
            {
                SetTotalPage();
                ShowCustomers();
            };

            #endregion

            #region Command
            command.SearchButtonClicked += (s, e) =>
            {
                SetTotalPage();
                ShowCustomers();
            };

            command.FilterOnEnter += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    paginator.ResetPage();
                    SetTotalPage();
                    ShowCustomers();
                }

            };

            command.UnFilterOnClearText += (s, e) =>
            {
                if (command.GetSearchedValue == "")
                {
                    paginator.ResetPage();
                    SetTotalPage();
                    ShowCustomers();
                }

            };
            command.AddButtonClicked += (s, e) => { CreateNewCustomer(); };

            command.EditButtonClicked += (s, e) =>
            {
                EditCustomer();
            };

            command.DeleteButtonClicked += (s, e) =>
            {
                DeleteCustomer();
            };

            #endregion
        }


        #endregion

        #region CRUD
        private void CreateNewCustomer()
        {
            IsNew = true;
            ClearText();
            GoToCustomerDetails();
            EnableControls(true);
        }
        private void CancelChanges()
        {
            ResetToDefault();
        }

        private void SaveChanges()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                if (!IsNew)
                {
                    UpdateCustomerDetails(repository);
                }

                SaveCustomerDetails(repository);
            }
        }
        private void DeleteCustomer()
        {
            var customerId = GetCustomerId();
            if (!ValidateSelectedRecord()) return;

            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var customer = repository.Customers.GetById(customerId);
                if (customer != null)
                {
                    repository.Customers.Remove(customer);
                    repository.Commit();
                    ShowCustomers();
                }

            }

        }
       
        private void EditCustomer()
        {
            if (!ValidateSelectedRecord()) return;
            IsNew = false;
            ClearText();
            GetSupplierDetails();
            GoToCustomerDetails();
            EnableControls(true);
        }

        private void GetSupplierDetails()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var customer = repository.Customers.GetById(GetCustomerId());

                if (customer != null)
                    ShowCustomerDetails(customer);
            }
        }

        
        private void ShowCustomerDetails(Models.Customer selectedCustomer)
        {
            txtSupplierName.Text = selectedCustomer.CustomerName;
            txtCustomerCode.Text = selectedCustomer.Address;
            txtVehicleNo.Text = selectedCustomer.VehicleNo;
            txtVehicleType.Text = selectedCustomer.VehicleType;
            txtContactNo.Text = selectedCustomer.ContactNo;
            GoToCustomerDetails();
        }

     
        private void GoToCustomerDetails() => btnDetails.PerformClick();

        private void SaveCustomerDetails(DbRepository dbRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;

            var repository = dbRepository;
            var customer = new Models.Customer()
            {
              
               CustomerName = txtSupplierName.Text,
               ContactNo = txtContactNo.Text,
               CustomerCode = txtCustomerCode.Text,
               VehicleNo = txtVehicleNo.Text,
               //Address = txtAddress.Text.Trim(),
               IsActive = true,
               DateTimeCreated = DateTime.Now
              
               
            //CreatedBy = AccountSession.GetAccount.Id

        };
            repository.Customers.Add(customer);
            repository.Commit();

            ResetToDefault();
            MessageAlert.Show("New customer has successfully added.", "Customer", AlertType.Info);
        }

        private void UpdateCustomerDetails(DbRepository dbRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;

            var repository = dbRepository;
            var customer = repository.Customers.GetById(GetCustomerId());
            {
                
                customer.VehicleNo = txtVehicleNo.Text;
                customer.ContactNo = txtContactNo.Text;
                customer.CustomerName = txtSupplierName.Text;
                //customer.Address = txtCustomerCode.Text;
                customer.CustomerCode = txtCustomerCode.Text;
                customer.DateTimeModified = DateTime.Now;
                customer.ModifiedBy = 1;


            };
            repository.Commit();

            MessageAlert.Show("Successfully Changed");
            ResetToDefault();
        }
        #endregion

        private void ResetToDefault()
        {
            GoToCustomerList();
            ClearText();
            ClearErrors();
            EnableControls(false);
            ShowCustomers();

        }

        private void EnableControls(bool flag)
        {
            txtSupplierName.Enabled = flag;

            txtVehicleNo.Enabled = flag;
           
            txtContactNo.Enabled = flag;
            txtCustomerCode.Enabled = flag;

            dgvCustomers.Enabled = !flag;

            btnCancel.Enabled = flag;
            btnSaveChanges.Enabled = flag;

        }

        private void GoToCustomerList() => btnList.PerformClick();

        #region Set Methods

        private void SetTotalPage()
        {
           paginator.SetMaxPage(new DatabaseContext().Customers.Count());
        }
        #endregion

        #region Show Methods

        private void ShowCustomers()
        {
            bsCustomers.DataSource = GetCustomers();
        }
        #endregion

        #region Get Methods
        private int GetCustomerId()
        {
            return int.Parse(ControlHelper
                .GetDataGridViewKey(dgvCustomers, 0));
        }

        private IEnumerable<Models.Customer> GetCustomers()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                return repository.Customers.GetAll(paginator.GetCurrentPage, paginator.GetRecordsPerPage);

            }
        }

        #endregion

        #region Other Methods

        private void ClearText()
        {
            ControlHelper.ClearTextBox(tpCustomerDetails);
        }


        #endregion

        #region Validations
        private bool ValidateSelectedRecord()
        {

            if (dgvCustomers.RowCount == 0)
            {
                MessageAlert.Show(MessageHelper.NoSelectedRecord(), "Error", AlertType.BadInfo);
                return false;
            }
            return true;
        }

        private bool ValidateRequiredFields()
        {
            ClearErrors();

            var isValidated = true;
            foreach (var control in tpCustomerDetails.Controls.Cast<Control>())
            {
                if (control is FlatTextBox)
                {
                    var textBox = control as FlatTextBox;
                    if (string.IsNullOrEmpty(textBox.Text.Trim()) && textBox.Required)
                    {
                        isValidated = SetErrorMessage(textBox, MessageHelper.NoInput());
                        textBox.Focus();
                        return isValidated;
                    }
                }

            }

            return isValidated;
        }

        private bool ValidateDuplicateRecord()
        {
            ClearErrors();

            var isValidated = true;

            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var fullName = $"{txtSupplierName.Text}";

                if (IsNew)
                {
                    if (repository.Customers.IsExist(fullName))
                    {
                        MessageAlert.Show(MessageHelper.DuplicateRecord(fullName), "Error", AlertType.Warning);

                        //isValidated = SetErrorMessage(txtSupplierName, MessageHelper.DuplicateRecord(txtSupplierName.Text));
                        
                        return isValidated;
                    }

                }
                else
                {
                    var customerId = GetCustomerId();
                    if (repository.Customers.IsExist(fullName, customerId))
                    {
                        MessageAlert.Show(MessageHelper.DuplicateRecord(fullName), "Error", AlertType.Warning);

                        //isValidated = SetErrorMessage(txtSupplierName, MessageHelper.DuplicateRecord(txtSupplierName.Text));

                        return isValidated;
                    }
                }


            }

            return isValidated;
        }


        private bool SetErrorMessage(Control control, string errorMessage)
        {
            epCustomers.SetError(control, errorMessage);

            return false;
        }

        private void ClearErrors() => epCustomers.Clear();

        #endregion
    
        #region Button Themes
        private void InitializeButtonTabEvent() => SetCustomerButtonTabEvent();

        private void SetCustomerButtonTabEvent()
        {
            var controls = tlpCustomerButtonTab.Controls.Cast<Control>().ToList();

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
            foreach (var control in tlpCustomerButtonTab.Controls.Cast<Control>())
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
            tcPumpAttendantMenu.SelectTab("tp" + selectedButton.ToString().Replace(" ", ""));
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
        #endregion

        public bool IsNew { get; set; }
    }
}

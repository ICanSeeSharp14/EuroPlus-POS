using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Commons.Helper;
using Petrol_Pump_Point_Of_Sale_System.Components;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Models;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;
using Petrol_Pump_Point_Of_Sale_System.View.Product;

namespace Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Supplier
{
    public partial class SupplierView : ICommand
    {
        private void Initialize()
        {
            IsNew = true;
            InitializeEvent();
            InitializeButtonTabEvent();
            InitializeSupplierList();
        }
        private void InitializeSupplierList()
        {
            if (!bwSuppliers.IsBusy)
            {
                bwSuppliers.RunWorkerAsync();

            }
        }

        #region Events
        private void InitializeEvent()
        {
            #region Background Worker
            bwSuppliers.DoWork += (s, e) => GetSuppliers();
            bwSuppliers.RunWorkerCompleted += (s, e) => ShowSuppliers();
            #endregion

            #region Pagination
            paginator.PageNavigationButtonClicked += (s, e) =>
            {
                ShowSuppliers();
            };
            paginator.RefreshButtonClicked += (s, e) =>
            {
                ShowSuppliers();
            };

            paginator.RecordCountChanged += (s, e) =>
            {
                SetTotalPage();
                ShowSuppliers();
            };

            paginator.PageNavigationButtonClicked += (s, e) =>
            {
                ShowSuppliers();
            };
            paginator.RefreshButtonClicked += (s, e) =>
            {
                ShowSuppliers();
            };

            paginator.RecordCountChanged += (s, e) =>
            {
                SetTotalPage();
                ShowSuppliers();
            };

            #endregion

            #region Command
            command.SearchButtonClicked += (s, e) =>
            {
                SetTotalPage();
                ShowSuppliers();
            };

            command.FilterOnEnter += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    paginator.ResetPage();
                    SetTotalPage();
                    ShowSuppliers();
                }

            };

            command.UnFilterOnClearText += (s, e) =>
            {
                if (command.GetSearchedValue == "")
                {
                    paginator.ResetPage();
                    SetTotalPage();
                    ShowSuppliers();
                }

            };
            command.AddButtonClicked += (s, e) => { CreateNewSupplier(); };

            command.EditButtonClicked += (s, e) =>
            {
                EditSupplier();
            };

            command.DeleteButtonClicked += (s, e) =>
            {
                DeleteSupplier();
            };

            #endregion
        }


        #endregion

        #region CRUD
        private void CreateNewSupplier()
        {
            IsNew = true;
            ClearText();
            GoToSupplierDetails();
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
                    UpdateSupplierDetails(repository);
                }

                SaveSupplierDetails(repository);
            }
        }
        private void DeleteSupplier()
        {
            var attendantId = GetSupplierId();
            if (!ValidateSelectedRecord()) return;

            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var selectedAttendant = repository.PumpAttendants.GetById(attendantId);
                if (selectedAttendant != null)
                {
                    repository.PumpAttendants.Remove(selectedAttendant);
                    repository.Commit();
                    ShowSuppliers();
                }

            }

        }
       
        private void EditSupplier()
        {
            if (!ValidateSelectedRecord()) return;
            IsNew = false;
            ClearText();
            GetSupplierDetails();
            GoToSupplierDetails();
            EnableControls(true);
        }

        private void GetSupplierDetails()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var selectedSupplier = repository.Suppliers.GetById(GetSupplierId());

                if (selectedSupplier != null)
                    ShowSupplierDetails(selectedSupplier);
            }
        }

        
        private void ShowSupplierDetails(Models.Supplier selectedSupplier)
        {
            txtSupplierName.Text = selectedSupplier.SupplierName;
            txtAddress.Text = selectedSupplier.Address;
            txtEmail.Text = selectedSupplier.Email;
            
            txtContactNo.Text = selectedSupplier.ContactNo;
            GoToSupplierDetails();
        }

     
        private void GoToSupplierDetails() => btnDetails.PerformClick();

        private void SaveSupplierDetails(DbRepository dbRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;

            var repository = dbRepository;
            var supplier = new Models.Supplier()
            {
              
               SupplierName = txtSupplierName.Text,
               ContactNo = txtContactNo.Text,
               Email = txtEmail.Text,
               Address = txtAddress.Text.Trim(),
               IsActive = true,
               DateTimeCreated = DateTime.Now
              
               
            //CreatedBy = AccountSession.GetAccount.Id

        };
            repository.Suppliers.Add(supplier);
            repository.Commit();

            ResetToDefault();
            MessageAlert.Show("New supplier has successfully added.", "Supplier", AlertType.Info);
        }

        private void UpdateSupplierDetails(DbRepository dbRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;

            var repository = dbRepository;
            var selectedSupplier = repository.Suppliers.GetById(GetSupplierId());
            {
                
                selectedSupplier.Email = txtEmail.Text;
                selectedSupplier.ContactNo = txtContactNo.Text;
                selectedSupplier.SupplierName = txtSupplierName.Text;
                selectedSupplier.Address = txtAddress.Text;
                selectedSupplier.DateTimeModified = DateTime.Now;
               


            };
            repository.Commit();

            MessageAlert.Show("Successfully Changed");
            ResetToDefault();
        }
        #endregion

        private void ResetToDefault()
        {
            GoToSupplierList();
            ClearText();
            ClearErrors();
            EnableControls(false);
            ShowSuppliers();

        }

        private void EnableControls(bool flag)
        {
            txtSupplierName.Enabled = flag;

            txtEmail.Enabled = flag;
           
            txtContactNo.Enabled = flag;
            txtAddress.Enabled = flag;

            dgvSupplier.Enabled = !flag;

            btnCancel.Enabled = flag;
            btnSaveChanges.Enabled = flag;

        }

        private void GoToSupplierList() => btnList.PerformClick();

        #region Set Methods

        private void SetTotalPage()
        {
           paginator.SetMaxPage(new DatabaseContext().Suppliers.Count());
        }
        #endregion

        #region Show Methods

        private void ShowSuppliers()
        {
            bsSuppliers.DataSource = GetSuppliers();
        }
        #endregion

        #region Get Methods
        private int GetSupplierId()
        {
            return int.Parse(ControlHelper
                .GetDataGridViewKey(dgvSupplier, 0));
        }

        private IEnumerable<Models.Supplier> GetSuppliers()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                return repository.Suppliers.GetAll(paginator.GetCurrentPage, paginator.GetRecordsPerPage);

            }
        }

        #endregion

        #region Other Methods

        private void ClearText()
        {
            ControlHelper.ClearTextBox(tpSupplierDetails);
        }


        #endregion

        #region Validations
        private bool ValidateSelectedRecord()
        {

            if (dgvSupplier.RowCount == 0)
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
            foreach (var control in tpSupplierDetails.Controls.Cast<Control>())
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
                    if (repository.Suppliers.IsExist(fullName))
                    {
                        MessageAlert.Show(MessageHelper.DuplicateRecord(fullName), "Error", AlertType.Warning);

                        //isValidated = SetErrorMessage(txtSupplierName, MessageHelper.DuplicateRecord(txtSupplierName.Text));
                        
                        return isValidated;
                    }

                }
                else
                {
                    var supplierId = GetSupplierId();
                    if (repository.Suppliers.IsExist(fullName, supplierId))
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
            epSuppliers.SetError(control, errorMessage);

            return false;
        }

        private void ClearErrors() => epSuppliers.Clear();

        #endregion
    
        #region Button Themes
        private void InitializeButtonTabEvent() => SetPumpAttendantButtonTabEvent();

        private void SetPumpAttendantButtonTabEvent()
        {
            var controls = tlpAttendantButtonTab.Controls.Cast<Control>().ToList();

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
            foreach (var control in tlpAttendantButtonTab.Controls.Cast<Control>())
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

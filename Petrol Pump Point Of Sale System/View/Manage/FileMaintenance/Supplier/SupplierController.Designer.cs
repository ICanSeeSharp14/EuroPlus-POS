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
            ShowSuppliers();
        }

        #region Events
        private void InitializeEvent()
        {
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
                var selectedAttendant = repository.PumpAttendants.GetById(GetSupplierId());

                if (selectedAttendant != null)
                    ShowSupplierDetails(selectedAttendant);
            }
        }

        
        private void ShowSupplierDetails(Employee selectedAttendant)
        {
            txtAttendantCode.Text = selectedAttendant.EmployeeCode;
            txtFirstName.Text = selectedAttendant.FirstName;
            txtLastName.Text = selectedAttendant.LastName;
            txtAttendantAddress.Text = selectedAttendant.Address;
            
            txtContactNo.Text = selectedAttendant.ContactNo;
            GoToSupplierDetails();
        }

     
        private void GoToSupplierDetails() => btnDetails.PerformClick();

        private void SaveSupplierDetails(DbRepository dbRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;

            var repository = dbRepository;
            var newAttendant = new Employee()
            {
               FirstName = txtFirstName.Text,
               EmployeeCode = txtAttendantCode.Text.Trim(),
               ContactNo = txtContactNo.Text,
               Address = txtAttendantAddress.Text,
               LastName = txtLastName.Text.Trim(),
               FullName = $"{txtFirstName.Text} {txtLastName.Text}",
               IsActive = true,
               PositionId = 1
               
            //CreatedBy = AccountSession.GetAccount.Id

        };
            repository.PumpAttendants.Add(newAttendant);
            repository.Commit();

            ResetToDefault();
            MessageAlert.Show("New supplier has successfully added.", "Supplier", AlertType.Info);
        }

        private void UpdateSupplierDetails(DbRepository dbRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;

            var repository = dbRepository;
            var selectedAttendant = repository.PumpAttendants.GetById(GetSupplierId());
            {
                selectedAttendant.FirstName = txtFirstName.Text;
                selectedAttendant.Address = txtAttendantAddress.Text;
                selectedAttendant.ContactNo = txtContactNo.Text;
                selectedAttendant.EmployeeCode = txtAttendantCode.Text;
                selectedAttendant.LastName = txtLastName.Text;
                selectedAttendant.FullName = $"{txtFirstName.Text} {txtLastName.Text}";



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
            txtAttendantCode.Enabled = flag;
            txtFirstName.Enabled = flag;
            txtAttendantAddress.Enabled = flag;
           
            txtContactNo.Enabled = flag;
            txtLastName.Enabled = flag;

            dgvSupplier.Enabled = !flag;

            btnCancel.Enabled = flag;
            btnSaveChanges.Enabled = flag;

        }

        private void GoToSupplierList() => btnList.PerformClick();

        #region Set Methods

        private void SetTotalPage()
        {
           paginator.SetMaxPage(new DatabaseContext().Employees.Count());
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

        private IEnumerable<Employee> GetSuppliers()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                return repository.PumpAttendants.GetAll();

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
                var fullName = $"{txtFirstName.Text} {txtLastName.Text}";

                if (IsNew)
                {
                    if (repository.PumpAttendants.AttendantNameAlreadyExist(fullName))
                    {
                        MessageAlert.Show(MessageHelper.DuplicateRecord(fullName), "Error", AlertType.Warning);

                        isValidated = SetErrorMessage(txtFirstName, MessageHelper.DuplicateRecord(txtFirstName.Text));
                        isValidated = SetErrorMessage(txtLastName, MessageHelper.DuplicateRecord(txtLastName.Text));
                        return isValidated;
                    }

                }
                else
                {
                    var pumpAttendantId = GetSupplierId();
                    if (repository.PumpAttendants.AttendantNameAlreadyExist(fullName, pumpAttendantId))
                    {
                        isValidated = SetErrorMessage(txtFirstName, MessageHelper.DuplicateRecord(txtFirstName.Text.Trim()));
                        isValidated = SetErrorMessage(txtLastName, MessageHelper.DuplicateRecord(txtLastName.Text));

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

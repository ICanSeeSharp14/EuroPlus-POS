using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITA_UI;
using Petrol_Pump_Point_Of_Sale_System.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Commons.Helper;
using Petrol_Pump_Point_Of_Sale_System.Components;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Models;
using System.Data;

namespace Petrol_Pump_Point_Of_Sale_System.View.Account
{
    public partial class AccountView : ICommand
    {
        private void Initialize()
        {
            IsNew = true;
            InitializeEvent();
            InitializeButtonTabEvent();
            InitializeAccountList();
        }

        private void InitializeAccountList()
        {
            if (!bwAccounts.IsBusy)
            {
                bwAccounts.RunWorkerAsync();

            }
        }

        private void InitializeButtonTabEvent()
        {
            SetProductButtonTabEvent();
        }
        
        private void InitializeEvent()
        {
            paginator.PageNavigationButtonClicked += (s, e) =>
            {
                ShowAccounts();
            };
            paginator.RefreshButtonClicked += (s, e) =>
            {
                ShowAccounts();
            };

            paginator.RecordCountChanged += (s, e) =>
            {
                SetTotalPage();
                ShowAccounts();
            };

            bwAccounts.DoWork += (s, e) =>
            {
                GetAccounts();
                GetDeactivatedAccounts();
                GetUsersRole();
            };

            bwAccounts.RunWorkerCompleted += (s, e) =>
            {
                
                ShowAccounts();
                PopulateUsersRole();
                ShowDeactivatedAccounts();
            };

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


        private void PopulateUsersRole()
        {
          
            bsUsersRole.DataSource = GetUsersRole();
        }


        private void ShowDeactivatedAccounts()
        {
            dgvDeletedUsers.DataSource = GetDeactivatedAccounts();
          
        }

        private IEnumerable<dynamic> GetDeactivatedAccounts()
        { 
            using (var accountRepository = new UserRepository(new DatabaseContext()))
            {
               
                return accountRepository.GetAllUsers(Status.InActive);
               
            }
        }

        private IEnumerable<UserRole> GetUsersRole()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                return repository.Roles.GetAll();
            }
        }


        private void SetTotalPage()
        {
            paginator.SetMaxPage(new DatabaseContext().Users.Count(p => p.IsActive));
        }

       
        
    
        private void ShowAccounts()
        {
            bsAccounts.DataSource =  GetAccounts();
        }
  
        private IEnumerable<dynamic> GetAccounts()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                return repository.Users.GetAllUsers(Status.Active);
            }
        }

        private void DeActivateAccount()
        {
            if (dgvAccount.Rows.Count < 1) return;
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var accountId = GetAccountId(dgvAccount);
                var account = repository.Users.GetById(accountId);
                if (account != null)
                {
                   account.IsActive = false;
           
                   repository.Commit();
                   MessageAlert.Show("Successfully Deactivated selected account","DeActivate",AlertType.Delete);
                   ResetToDefault();
                }

            }
        
        }

        private void ActivateAccount()
        {
            if (dgvDeletedUsers.Rows.Count < 1) return;

            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var accountId = GetAccountId(dgvDeletedUsers);
                User account = repository.Users.GetById(accountId);
                if (account != null)
                {
                    account.IsActive = true;

                    repository.Commit();
                    MessageAlert.Show("Account successfully activated", "Activate");

                    ResetToDefault();
                }

            }
        }
        private void GetAccountDetailsById()
        {
            if (dgvAccount.Rows.Count < 1) return;

            using (var accountRepository = new DbRepository(new DatabaseContext()))
            {
                var accountId = GetAccountId(dgvAccount);
                User selectedAccount = accountRepository.Users.GetById(accountId);
                if (selectedAccount != null)
                    ShowAccountInformation(selectedAccount);
            }
        }

       
        private void ShowAccountInformation(User selectedAccount)
        {
            ClearText();
            FillAccountDetails(selectedAccount);
        }   

        private void FillAccountDetails(User selectedAccount)
        {
            txtName.Text = selectedAccount.Name;
            txtUsername.Text = selectedAccount.Username;
            txtUserRole.SelectedText = GetAccountRoleName(selectedAccount.RoleId);
            txtPassword.Text = selectedAccount.Password;
        }

        private string GetAccountRoleName(int roleId)
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var role  = repository.Roles.GetById(roleId);
                return role.UserRoleName;
               
            }
        }

        private void EditAccountInformation()
        {
           EnableControls(true);
           IsNew = false;
           txtUsername.Focus();
        }

        private void CreateAccount()
        {
            IsNew = true;
            EnableControls(true);
            ClearText();
            txtUsername.Focus();
        }

        private void Cancel()
        {
            ResetToDefault();
        }

       
        private void AccountCommand(Command command)
        {
            if (command == Command.Update)
            {
                SaveChanges();
            }
            else if (command == Command.Save)
            {
                SaveChanges();
            }
        }

        private void SaveChanges()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                if (!IsNew)
                {
                    UpdateAccountDetails(repository);
                  
                }
                else
                {
                    SaveNewAccount(repository);
                }
            }
          
        }


        private void UpdateAccountDetails(DbRepository userRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;

            var repository = userRepository;
            var accountId = GetAccountId(dgvAccount);
            var account = repository.Users.GetById(accountId);
            if (account != null)
            {
                account.Name = txtName.Text;
                account.Password = txtPassword.Text;
                account.RoleId = (int) txtUserRole.SelectedValue;
                account.Username = txtUsername.Text;

                repository.Commit();
                MessageAlert.Show("Successfully Changed","Update");
                ResetToDefault();

            }
        }

        private void SaveNewAccount(DbRepository userRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;


            var repository = userRepository;

            var newAccount = new User()
            {
                Name = txtName.Text,
                Password = txtPassword.Text,
                RoleId = (int)txtUserRole.SelectedValue,
                Username = txtUsername.Text,
                IsActive = true,
                DateTimeCreated = DateTime.Now
            };

            repository.Users.Add(newAccount);
            repository.Commit();
            MessageAlert.Show("Successfully Saved");
            ResetToDefault();
        }

     
        private void DeleteAccount()
        {
            if (dgvDeletedUsers.Rows.Count < 1) return;

            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var accountId = GetAccountId(dgvDeletedUsers);
                var account = repository.Users.GetById(accountId);
                repository.Users.Remove(account);
                repository.Commit();
                MessageAlert.Show("Successfully Deleted");
                ResetToDefault();
            }
        }
        private void ResetToDefault()
        {
            ShowAccounts();
            ClearText();
            EnableControls(false);
            ShowDeactivatedAccounts();
            PopulateUsersRole();
            txtSearch.Focus();
            ClearErrors();

        }

        private void EnableControls(bool flag)
        {
            txtPassword.Enabled = flag;
            txtName.Enabled = flag;
            txtUserRole.Enabled = flag;
            txtUsername.Enabled = flag;
            btnCancel.Enabled = flag;
            btnSaveChanges.Enabled = flag;
            
            tlpCommandButton.Enabled = !flag;

        }

        private bool ValidateDuplicateRecord()
        {
            var isValidated = true;

            using (var accountRepository = new DbRepository(new DatabaseContext()))
            {
                if (IsNew)
                {
                    if (accountRepository.Users.UserNameAlreadyUsed(txtUsername.Text.Trim()))
                    {
                        isValidated = SetErrorMessage(txtUsername, MessageHelper.DuplicateRecord(txtUsername.Text.Trim()));
                        return isValidated;
                    }
                    ClearErrors();

                }
                else
                {
                    var accountId = GetAccountId(dgvAccount);
                    if (accountRepository.Users.UserNameAlreadyUsed(txtUsername.Text.Trim(), accountId))
                    {
                        isValidated = SetErrorMessage(txtUsername, MessageHelper.DuplicateRecord(txtUsername.Text.Trim()));
                        return isValidated;
                    }

                    ClearErrors();
                }
                

            }

            return isValidated;
        }
        
        private bool ValidateRequiredFields()
        {
            var isValidated = true;
            foreach (var control in flpAccountDetails.Controls.Cast<Control>())
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
                     ClearErrors();
                }

            }

            return isValidated;

        }
        private int GetAccountId(FlatTable dgv)
        {
            return int.Parse(ControlHelper.GetDataGridViewKey(dgv, 0));
        }
        private bool SetErrorMessage(Control control, string errorMessage)
        {
            epAccount.SetError(control, errorMessage);

            return false;
        }

        private void ClearErrors()
        {
            epAccount.Clear();
        }

        

        private void ClearText()
        {
            ControlHelper.ClearTextBox(flpAccountDetails);
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

        public bool IsNew { get; set; }
    }
}

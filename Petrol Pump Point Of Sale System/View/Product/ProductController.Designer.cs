using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Components;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Models;
using System;
using System.Collections.Generic;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Commons.Helper;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Monostates;
using Petrol_Pump_Point_Of_Sale_System.View.Custom;

namespace Petrol_Pump_Point_Of_Sale_System.View.Product
{
    public partial class ProductView : ICommand
    {
        #region Initialization
        private void Initialize()
        {
            IsNew = true;
            InitializeEvent();
            InitializeButtonTabEvent();
            InitializeProductList();
        }
        #endregion

        #region Events
        private void InitializeEvent()
        {
            #region Background Worker
            bwProducts.DoWork += (s, e) => GetProducts();
            bwProducts.RunWorkerCompleted += (s, e) => ShowProducts();
            #endregion

            #region Pagination
            paginator.PageNavigationButtonClicked += (s, e) => ShowProducts();
            paginator.RefreshButtonClicked += (s, e) => ShowProducts();
            paginator.RecordCountChanged += OnPaginatorOnRecordCountChanged;

            #endregion

            #region Commands
            command.SearchButtonClicked += OnCommandOnSearchButtonClicked;

            command.FilterOnEnter += OnCommandOnFilterOnEnter;
            command.UnFilterOnClearText += OnCommandOnUnFilterOnClearText;
            command.AddButtonClicked += (s, e) => CreateProduct();

            command.EditButtonClicked += (s, e) => EditProduct();

            command.DeleteButtonClicked += (s, e) => DeleteProduct();
            #endregion

        }
        #region Event Methods
        private void OnCommandOnUnFilterOnClearText(object s, EventArgs e)
        {
            if (command.GetSearchedValue == "")
            {
                paginator.ResetPage();
                SetTotalPage();
                ShowProducts();
            }
        }

        private void OnCommandOnFilterOnEnter(object s, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginator.ResetPage();
                SetTotalPage();
                ShowProducts();
            }
        }

        private void OnCommandOnSearchButtonClicked(object s, EventArgs e)
        {
            SetTotalPage();
            ShowProducts();
        }

        private void OnPaginatorOnRecordCountChanged(object s, EventArgs e)
        {
            SetTotalPage();
            ShowProducts();
        }
        #endregion
        private void InitializeButtonTabEvent() => SetProductButtonTabEvent();

        #endregion

        #region Methods
        private void InitializeProductList()
        {
            if (!bwProducts.IsBusy)
            {
                bwProducts.RunWorkerAsync();

            }
        }

        #region Show Methods
        public void ShowProducts() => dgvProduct.DataSource = GetProducts();
        private void ShowProductDetails(Products selectedProduct)
        {
            txtProductCode.Text = selectedProduct.ProductCode;
            txtProductName.Text = selectedProduct.ProductName;
            txtUnit.Text = selectedProduct.ProductName;
            txtPurchaseRate.Text = Convert.ToString(selectedProduct.PurchaseRate);
            txtSalesRate.Text = Convert.ToString(selectedProduct.SalesRate);
            txtQuantity.Text = Convert.ToString(selectedProduct.Quantity);
            GotoProductDetailsTab();
        }
        #endregion

        #region Get Methods
        private IEnumerable<Products> GetProducts()
        {
            using (var db = new DbRepository(new DatabaseContext()))
            {
                return db.Products
                         .GetAll(pageIndex: paginator.GetCurrentPage,
                                 pageSize: paginator.GetRecordsPerPage)
                         .Where(p => p.ProductName.Contains(command.GetSearchedValue) ||
                                p.ProductCode.Contains((command.GetSearchedValue)))
                        .ToList();
            }
        }
        private void GetProductDetails()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var productId = GetProductId();

                var selectedProduct = repository.Products.GetById(productId);

                if (selectedProduct != null)
                    ShowProductDetails(selectedProduct);
            }
        }
        #endregion

        #endregion


        private void EditProduct()
        {
            if (!ValidateSelectedRecord()) return;
            IsNew = false;
            ClearText();
            GetProductDetails();
            GoToProductDetails();
            EnableControls(true);
        }
        

        private void GotoProductDetailsTab()
        {
            tcProductMenu.SelectTab(tpProductDetails);
        }

        private void ShowErrorMessage()
        {
           MessageAlert.Show(MessageHelper.NoSelectedRecord(),"Error",AlertType.Error);
           
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
                    UpdateProductDetails(repository);
                }
         
                SaveNewProduct(repository);
            }   
        }

        private void SaveNewProduct(DbRepository repository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;

            var productRepository = repository;
            if (FlatMessageBox.Show("Do you want to save new product?", "Update Product", DialogButtons.YesNo,
                    DialogType.Question) == DialogButton.Yes)
            {
                var newProduct = new Products()
                {
                    ProductCode = txtProductCode.Text.Trim(),
                    ProductName = txtProductCode.Text.Trim(),
                    SalesRate = decimal.Parse(txtSalesRate.Text),
                    PurchaseRate = decimal.Parse(txtPurchaseRate.Text),
                    Unit = txtUnit.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Quantity = int.Parse(txtQuantity.Text),
                    DateTimeCreated = DateTime.Now,
                    IsActive = true
         
                };
                productRepository.Products.Add(newProduct);
                productRepository.Commit();
            }
               
          
            
            ResetToDefault();
            MessageAlert.Show("New product has successfully added.","New Product",AlertType.Info);
        }

        private void UpdateProductDetails(DbRepository dbRepository)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;
            if (FlatMessageBox.Show("Do you want to update the changes?", "Update Product", DialogButtons.YesNo,
                    DialogType.Question) == DialogButton.Yes)
            {
                var repository = dbRepository;
                var selectedProduct = repository.Products.GetById(GetProductId());
                {
                    selectedProduct.ProductCode = txtProductCode.Text.Trim();
                    selectedProduct.ProductName = txtProductCode.Text.Trim();
                    selectedProduct.SalesRate = decimal.Parse(txtSalesRate.Text);
                    selectedProduct.PurchaseRate = decimal.Parse(txtPurchaseRate.Text);
                    selectedProduct.Unit = txtUnit.Text.Trim();
                    selectedProduct.Description = txtDescription.Text.Trim();
                    selectedProduct.Quantity = int.Parse(txtQuantity.Text);
                    selectedProduct.DateTimeModified = DateTime.Now;
                    //selectedProduct.ModifiedBy = AccountSession.GetAccount.Id;
                };
                repository.Commit();
            }

            MessageAlert.Show("Successfully Changed");
            ResetToDefault();
        }

        private void ResetToDefault()
        {
            GoToProductList();
            ClearText();
            ClearErrors();
            EnableControls(false);
            ShowProducts();
            
        }

        private void GoToProductList()
        {
            tcProductMenu.SelectTab(tpProductList);
        }
        private void CreateProduct()
        {
            ClearText();
            GoToProductDetails();
            EnableControls(true);
        }
        private void GoToProductDetails()
        {
            btnDetails.PerformClick();
            tcProductMenu.SelectTab(tpProductDetails);
        }
        
        
        private void EnableControls(bool flag)
        {
            txtProductCode.Enabled = flag;
            txtProductName.Enabled = flag;
            txtPurchaseRate.Enabled = flag;
            txtDescription.Enabled = flag;
            txtQuantity.Enabled = flag;
            txtSalesRate.Enabled = flag;
            txtUnit.Enabled = flag;

            dgvProduct.Enabled = !flag;

            btnCancel.Enabled = flag;
            btnSaveChanges.Enabled = flag;

        }

        private void ClearText()
        {
            ControlHelper.ClearTextBox(tpProductDetails);
        }
        private void DeleteProduct()
        {
            if (!ValidateSelectedRecord()) return;

            if (FlatMessageBox.Show("Selected product will be deleted. Do you want to continue?", "Delete Product", DialogButtons.YesNo, DialogType.Warning) ==
                DialogButton.Yes)
            {
                using (var repository = new DbRepository(new DatabaseContext()))
                {
                    var selectedProduct = repository.Products.GetById(GetProductId());
                    if (selectedProduct != null)
                    {
                        repository.Products.Remove(selectedProduct);
                        repository.Commit();
                        MessageAlert.Show("Product successfully removed from the list","Deleted",AlertType.Delete);
                        ShowProducts();
                    }
                }
                   
            }
        }

      

        #region Validations
        private bool ValidateSelectedRecord()
        {
            
            if (!IsNew && dgvProduct.RowCount == 0)
            {
                MessageAlert.Show(MessageHelper.NoSelectedRecord(), "Error", AlertType.BadInfo);
                return false;
            }
            return true;
        }

        private bool ValidateRequiredFields()
        {
            var isValidated = true;
            foreach (var control in tpProductDetails.Controls.Cast<Control>())
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

        private bool ValidateDuplicateRecord()
        {
            ClearErrors();

            var isValidated = true;

            using (var repository = new DbRepository(new DatabaseContext()))
            {
                if (IsNew)
                {
                    if (repository.Products.ProductNameAlreadyExist(txtProductName.Text))
                    {
                        isValidated = SetErrorMessage(txtProductName, MessageHelper.DuplicateRecord(txtProductName.Text.Trim()));
                        return isValidated;
                    }
                   
                }
                else
                {
                    var productId = GetProductId();
                    if (repository.Products.ProductNameAlreadyExist(txtProductName.Text, productId))
                    {
                        isValidated = SetErrorMessage(txtProductName, MessageHelper.DuplicateRecord(txtProductName.Text.Trim()));
                        return isValidated;
                    }
                }


            }

            return isValidated;
        }


        private bool SetErrorMessage(Control control, string errorMessage)
        {
            epProducts.SetError(control, errorMessage);

            return false;
        }

        private void ClearErrors()
        {
            epProducts.Clear();
        }

        #endregion
        private int GetProductId()
        {
            return int.Parse(ControlHelper
                .GetDataGridViewKey(dgvProduct, 0));
        }
        private void RemoveFromList(Products product)
        {
            using (var db = new DbRepository(new DatabaseContext()))
            {
                db.Products.Remove(product);
                db.Commit();
                ShowProducts();
            }

        }

       
        private void SetTotalPage()
        {
            paginator.SetMaxPage(new DatabaseContext().Products.Count(p => p.IsActive));
        }

        #region Button Themes
        private void SetProductButtonTabEvent()
        {
            var controls = tlpProductButtonTab.Controls.Cast<Control>().ToList();

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
            foreach (var control in tlpProductButtonTab.Controls.Cast<Control>())
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
            tcProductMenu.SelectTab("tp" + selectedButton.ToString().Replace(" ",""));
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

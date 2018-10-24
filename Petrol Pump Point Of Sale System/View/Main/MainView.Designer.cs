﻿using ITA_UI;
using Petrol_Pump_Point_Of_Sale_System.Components;
using Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Supplier;
using FlatButton = Petrol_Pump_Point_Of_Sale_System.Components.FlatButton;

namespace Petrol_Pump_Point_Of_Sale_System.View.Main
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.pnlTopMenuContainer = new System.Windows.Forms.Panel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.btnExit = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnMaximize = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.t = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbIcon = new Petrol_Pump_Point_Of_Sale_System.Components.FlatPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tcMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tpManageProduct = new System.Windows.Forms.TabPage();
            this.productView = new Petrol_Pump_Point_Of_Sale_System.View.Product.ProductView();
            this.tpManageAccount = new System.Windows.Forms.TabPage();
            this._accountViewView3 = new Petrol_Pump_Point_Of_Sale_System.View.Account.AccountView();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.dashboardView1 = new Petrol_Pump_Point_Of_Sale_System.View.Home.DashboardView();
            this.tpManageCustomers = new System.Windows.Forms.TabPage();
            this.tpPointOfSale = new System.Windows.Forms.TabPage();
            this.tpManagePumpAttendants = new System.Windows.Forms.TabPage();
            this.pumpAttendantView1 = new Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Pump_Attendant.PumpAttendantView();
            this.tpManageSuppliers = new System.Windows.Forms.TabPage();
            this.lblModuleTitle = new System.Windows.Forms.Label();
            this.pnlSubNavigation = new Petrol_Pump_Point_Of_Sale_System.View.Main.NavigationView();
            this.pnlSideNavigation = new Petrol_Pump_Point_Of_Sale_System.Components.FlatNavigationPanel();
            this.btnHelp = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnSettings = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnReports = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnManage = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnPOS = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnHome = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.supplierView2 = new Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Supplier.SupplierView();
            this.pnlTopMenuContainer.SuspendLayout();
            this.pnlControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.tpManageProduct.SuspendLayout();
            this.tpManageAccount.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpManagePumpAttendants.SuspendLayout();
            this.tpManageSuppliers.SuspendLayout();
            this.pnlSideNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopMenuContainer
            // 
            this.pnlTopMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnlTopMenuContainer.Controls.Add(this.pnlControlBox);
            this.pnlTopMenuContainer.Controls.Add(this.lblTitle);
            this.pnlTopMenuContainer.Controls.Add(this.pbIcon);
            this.pnlTopMenuContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenuContainer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTopMenuContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenuContainer.Name = "pnlTopMenuContainer";
            this.pnlTopMenuContainer.Size = new System.Drawing.Size(1368, 40);
            this.pnlTopMenuContainer.TabIndex = 0;
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Controls.Add(this.btnExit);
            this.pnlControlBox.Controls.Add(this.btnMaximize);
            this.pnlControlBox.Controls.Add(this.t);
            this.pnlControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControlBox.Location = new System.Drawing.Point(1285, 0);
            this.pnlControlBox.Name = "pnlControlBox";
            this.pnlControlBox.Size = new System.Drawing.Size(83, 40);
            this.pnlControlBox.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnExit.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnExit.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnExit.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.EllipseOnClick = 0;
            this.btnExit.EllipseOnDefault = 0;
            this.btnExit.EllipseOnHover = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ForeColorOnClick = System.Drawing.Color.White;
            this.btnExit.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnExit.ForeColorOnHover = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(52, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "r";
            this.btnExit.ToolTip = "";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMaximize.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMaximize.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMaximize.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaximize.EllipseOnClick = 0;
            this.btnMaximize.EllipseOnDefault = 0;
            this.btnMaximize.EllipseOnHover = 0;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.ForeColorOnClick = System.Drawing.Color.White;
            this.btnMaximize.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnMaximize.ForeColorOnHover = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(31, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(21, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "1";
            this.btnMaximize.ToolTip = "";
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.t.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.t.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.t.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.t.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t.Dock = System.Windows.Forms.DockStyle.Left;
            this.t.EllipseOnClick = 0;
            this.t.EllipseOnDefault = 0;
            this.t.EllipseOnHover = 0;
            this.t.FlatAppearance.BorderSize = 0;
            this.t.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.t.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.t.ForeColor = System.Drawing.Color.White;
            this.t.ForeColorOnClick = System.Drawing.Color.White;
            this.t.ForeColorOnDefault = System.Drawing.Color.White;
            this.t.ForeColorOnHover = System.Drawing.Color.White;
            this.t.Location = new System.Drawing.Point(0, 0);
            this.t.Margin = new System.Windows.Forms.Padding(0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(31, 40);
            this.t.TabIndex = 0;
            this.t.Text = "0";
            this.t.ToolTip = "";
            this.t.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(67, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1301, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "EuroPlus Gasoline Station";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pbIcon.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pbIcon.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pbIcon.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.EllipseOnClick = 0;
            this.pbIcon.EllipseOnDefault = 0;
            this.pbIcon.EllipseOnHover = 0;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(67, 40);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.ToolTip = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 727);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 43);
            this.panel1.TabIndex = 9;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBody.Controls.Add(this.tcMenu);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(298, 70);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1070, 657);
            this.pnlBody.TabIndex = 11;
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpManageProduct);
            this.tcMenu.Controls.Add(this.tpManageAccount);
            this.tcMenu.Controls.Add(this.tpHome);
            this.tcMenu.Controls.Add(this.tpManageCustomers);
            this.tcMenu.Controls.Add(this.tpPointOfSale);
            this.tcMenu.Controls.Add(this.tpManagePumpAttendants);
            this.tcMenu.Controls.Add(this.tpManageSuppliers);
            this.tcMenu.Depth = 0;
            this.tcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMenu.Location = new System.Drawing.Point(0, 0);
            this.tcMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(1070, 657);
            this.tcMenu.TabIndex = 1;
            // 
            // tpManageProduct
            // 
            this.tpManageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpManageProduct.Controls.Add(this.productView);
            this.tpManageProduct.Location = new System.Drawing.Point(4, 22);
            this.tpManageProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tpManageProduct.Name = "tpManageProduct";
            this.tpManageProduct.Size = new System.Drawing.Size(1062, 631);
            this.tpManageProduct.TabIndex = 1;
            this.tpManageProduct.Text = "Manage Products";
            this.tpManageProduct.Click += new System.EventHandler(this.tpManageAccount_Click);
            // 
            // productView
            // 
            this.productView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productView.IsNew = true;
            this.productView.Location = new System.Drawing.Point(0, 0);
            this.productView.Name = "productView";
            this.productView.Size = new System.Drawing.Size(1062, 631);
            this.productView.TabIndex = 9;
            this.productView.Load += new System.EventHandler(this.productView_Load);
            // 
            // tpManageAccount
            // 
            this.tpManageAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpManageAccount.Controls.Add(this._accountViewView3);
            this.tpManageAccount.Location = new System.Drawing.Point(4, 22);
            this.tpManageAccount.Margin = new System.Windows.Forms.Padding(0);
            this.tpManageAccount.Name = "tpManageAccount";
            this.tpManageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageAccount.Size = new System.Drawing.Size(1062, 631);
            this.tpManageAccount.TabIndex = 2;
            this.tpManageAccount.Text = "Manage AccountView";
            // 
            // _accountViewView3
            // 
            this._accountViewView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._accountViewView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._accountViewView3.IsNew = false;
            this._accountViewView3.Location = new System.Drawing.Point(3, 3);
            this._accountViewView3.Name = "_accountViewView3";
            this._accountViewView3.Size = new System.Drawing.Size(1056, 625);
            this._accountViewView3.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpHome.Controls.Add(this.dashboardView1);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1062, 631);
            this.tpHome.TabIndex = 3;
            this.tpHome.Text = "Home";
            // 
            // dashboardView1
            // 
            this.dashboardView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashboardView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardView1.Location = new System.Drawing.Point(3, 3);
            this.dashboardView1.Name = "dashboardView1";
            this.dashboardView1.Padding = new System.Windows.Forms.Padding(25);
            this.dashboardView1.Size = new System.Drawing.Size(1056, 625);
            this.dashboardView1.TabIndex = 11;
            // 
            // tpManageCustomers
            // 
            this.tpManageCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpManageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tpManageCustomers.Name = "tpManageCustomers";
            this.tpManageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageCustomers.Size = new System.Drawing.Size(1062, 631);
            this.tpManageCustomers.TabIndex = 4;
            this.tpManageCustomers.Text = "Manage Customers";
            // 
            // tpPointOfSale
            // 
            this.tpPointOfSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpPointOfSale.Location = new System.Drawing.Point(4, 22);
            this.tpPointOfSale.Name = "tpPointOfSale";
            this.tpPointOfSale.Padding = new System.Windows.Forms.Padding(3);
            this.tpPointOfSale.Size = new System.Drawing.Size(1062, 631);
            this.tpPointOfSale.TabIndex = 5;
            this.tpPointOfSale.Text = "POS";
            // 
            // tpManagePumpAttendants
            // 
            this.tpManagePumpAttendants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpManagePumpAttendants.Controls.Add(this.pumpAttendantView1);
            this.tpManagePumpAttendants.Location = new System.Drawing.Point(4, 22);
            this.tpManagePumpAttendants.Name = "tpManagePumpAttendants";
            this.tpManagePumpAttendants.Size = new System.Drawing.Size(1062, 631);
            this.tpManagePumpAttendants.TabIndex = 6;
            this.tpManagePumpAttendants.Text = "Manage Attendant";
            // 
            // pumpAttendantView1
            // 
            this.pumpAttendantView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pumpAttendantView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pumpAttendantView1.IsNew = true;
            this.pumpAttendantView1.Location = new System.Drawing.Point(0, 0);
            this.pumpAttendantView1.Name = "pumpAttendantView1";
            this.pumpAttendantView1.Size = new System.Drawing.Size(1062, 631);
            this.pumpAttendantView1.TabIndex = 0;
            // 
            // tpManageSuppliers
            // 
            this.tpManageSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpManageSuppliers.Controls.Add(this.supplierView2);
            this.tpManageSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tpManageSuppliers.Name = "tpManageSuppliers";
            this.tpManageSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageSuppliers.Size = new System.Drawing.Size(1062, 631);
            this.tpManageSuppliers.TabIndex = 7;
            this.tpManageSuppliers.Text = "Manage Suppliers";
            // 
            // lblModuleTitle
            // 
            this.lblModuleTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lblModuleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModuleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lblModuleTitle.ForeColor = System.Drawing.Color.White;
            this.lblModuleTitle.Location = new System.Drawing.Point(298, 40);
            this.lblModuleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblModuleTitle.Name = "lblModuleTitle";
            this.lblModuleTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblModuleTitle.Size = new System.Drawing.Size(1070, 30);
            this.lblModuleTitle.TabIndex = 12;
            this.lblModuleTitle.Text = "Title";
            this.lblModuleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSubNavigation
            // 
            this.pnlSubNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlSubNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubNavigation.Location = new System.Drawing.Point(107, 40);
            this.pnlSubNavigation.Name = "pnlSubNavigation";
            this.pnlSubNavigation.Size = new System.Drawing.Size(191, 687);
            this.pnlSubNavigation.TabIndex = 10;
            // 
            // pnlSideNavigation
            // 
            this.pnlSideNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnlSideNavigation.Controls.Add(this.btnHelp);
            this.pnlSideNavigation.Controls.Add(this.btnSettings);
            this.pnlSideNavigation.Controls.Add(this.btnReports);
            this.pnlSideNavigation.Controls.Add(this.btnManage);
            this.pnlSideNavigation.Controls.Add(this.btnPOS);
            this.pnlSideNavigation.Controls.Add(this.btnHome);
            this.pnlSideNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideNavigation.Location = new System.Drawing.Point(0, 40);
            this.pnlSideNavigation.Name = "pnlSideNavigation";
            this.pnlSideNavigation.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlSideNavigation.SelectorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.pnlSideNavigation.Size = new System.Drawing.Size(107, 687);
            this.pnlSideNavigation.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnHelp.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHelp.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnHelp.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.EllipseOnClick = 0;
            this.btnHelp.EllipseOnDefault = 0;
            this.btnHelp.EllipseOnHover = 0;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.ForeColorOnClick = System.Drawing.Color.White;
            this.btnHelp.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnHelp.ForeColorOnHover = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.Location = new System.Drawing.Point(0, 505);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(102, 101);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.ToolTip = "";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(25)))));
            this.btnSettings.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSettings.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(25)))));
            this.btnSettings.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.EllipseOnClick = 0;
            this.btnSettings.EllipseOnDefault = 0;
            this.btnSettings.EllipseOnHover = 0;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ForeColorOnClick = System.Drawing.Color.White;
            this.btnSettings.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnSettings.ForeColorOnHover = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.Location = new System.Drawing.Point(0, 404);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(102, 101);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.ToolTip = "";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.btnReports.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnReports.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.btnReports.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.EllipseOnClick = 0;
            this.btnReports.EllipseOnDefault = 0;
            this.btnReports.EllipseOnHover = 0;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ForeColorOnClick = System.Drawing.Color.White;
            this.btnReports.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnReports.ForeColorOnHover = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.Location = new System.Drawing.Point(0, 303);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(102, 101);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReports.ToolTip = "";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnManage.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnManage.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnManage.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManage.EllipseOnClick = 0;
            this.btnManage.EllipseOnDefault = 0;
            this.btnManage.EllipseOnHover = 0;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.ForeColorOnClick = System.Drawing.Color.White;
            this.btnManage.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnManage.ForeColorOnHover = System.Drawing.Color.White;
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManage.Location = new System.Drawing.Point(0, 202);
            this.btnManage.Margin = new System.Windows.Forms.Padding(0);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(102, 101);
            this.btnManage.TabIndex = 3;
            this.btnManage.Text = "Manage";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManage.ToolTip = "";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(55)))));
            this.btnPOS.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnPOS.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(55)))));
            this.btnPOS.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOS.EllipseOnClick = 0;
            this.btnPOS.EllipseOnDefault = 0;
            this.btnPOS.EllipseOnHover = 0;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.ForeColorOnClick = System.Drawing.Color.White;
            this.btnPOS.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnPOS.ForeColorOnHover = System.Drawing.Color.White;
            this.btnPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPOS.Image")));
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPOS.Location = new System.Drawing.Point(0, 101);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(102, 101);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPOS.ToolTip = "";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(65)))));
            this.btnHome.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHome.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(65)))));
            this.btnHome.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.EllipseOnClick = 0;
            this.btnHome.EllipseOnDefault = 0;
            this.btnHome.EllipseOnHover = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ForeColorOnClick = System.Drawing.Color.White;
            this.btnHome.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnHome.ForeColorOnHover = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(102, 101);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.ToolTip = "";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // supplierView2
            // 
            this.supplierView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplierView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierView2.IsNew = true;
            this.supplierView2.Location = new System.Drawing.Point(3, 3);
            this.supplierView2.Name = "supplierView2";
            this.supplierView2.Size = new System.Drawing.Size(1056, 625);
            this.supplierView2.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 770);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.lblModuleTitle);
            this.Controls.Add(this.pnlSubNavigation);
            this.Controls.Add(this.pnlSideNavigation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopMenuContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainView_Load);
            this.pnlTopMenuContainer.ResumeLayout(false);
            this.pnlControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.tcMenu.ResumeLayout(false);
            this.tpManageProduct.ResumeLayout(false);
            this.tpManageAccount.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpManagePumpAttendants.ResumeLayout(false);
            this.tpManageSuppliers.ResumeLayout(false);
            this.pnlSideNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenuContainer;
        private FlatPictureBox pbIcon;
        private FlatNavigationPanel pnlSideNavigation;
        private FlatButton btnHome;
        private FlatButton btnSettings;
        private FlatButton btnReports;
        private FlatButton btnManage;
        private FlatButton btnPOS;
        private System.Windows.Forms.Panel pnlControlBox;
        private FlatButton t;
        private System.Windows.Forms.Label lblTitle;
        private FlatButton btnHelp;
        private FlatButton btnExit;
        private FlatButton btnMaximize;
        private System.Windows.Forms.Panel panel1;
        private NavigationView pnlSubNavigation;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblModuleTitle;
        private MaterialSkin.Controls.MaterialTabControl tcMenu;
        private System.Windows.Forms.TabPage tpManageProduct;
        private System.Windows.Forms.TabPage tpManageAccount;
        private Product.ProductView productView;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpManageCustomers;
      
        private Account.AccountView _accountViewView3;
        private System.Windows.Forms.TabPage tpPointOfSale;
        private System.Windows.Forms.TabPage tpManagePumpAttendants;
        
        private Home.DashboardView dashboardView1;
        private System.Windows.Forms.TabPage tpManageSuppliers;
        
        private Manage.FileMaintenance.Pump_Attendant.PumpAttendantView pumpAttendantView1;
        private SupplierView supplierView2;
    }
}
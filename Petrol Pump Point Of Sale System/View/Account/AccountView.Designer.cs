﻿using Petrol_Pump_Point_Of_Sale_System.Components;

namespace Petrol_Pump_Point_Of_Sale_System.View.Account
{
    partial class AccountView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountView));
            this.pnlAccountList = new System.Windows.Forms.Panel();
            this.txtSearch = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.dgvAccount = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTable();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.paginator = new Petrol_Pump_Point_Of_Sale_System.View.Custom.PaginatorView();
            this.pnlButtonTab = new System.Windows.Forms.Panel();
            this.tlpAccountButtonTab = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsersAccess = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnDeletedUsers = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnAccountDetails = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.tcAccountMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tpAccountDetails = new System.Windows.Forms.TabPage();
            this.flpAccountDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserRole = new Petrol_Pump_Point_Of_Sale_System.Components.FlatComboBox();
            this.bsUsersRole = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveChanges = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnCancel = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.tlpCommandButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteAccount = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnAddAccount = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnEdit = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.tpDeletedUsers = new System.Windows.Forms.TabPage();
            this.dgvDeletedUsers = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTable();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPermanentDelete = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnActivateAccount = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.tpAccountAccess = new System.Windows.Forms.TabPage();
            this.dgvAccountAccess = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTable();
            this.bsDeactivatedUsers = new System.Windows.Forms.BindingSource(this.components);
            this.bwAccounts = new System.ComponentModel.BackgroundWorker();
            this.bsUsersAccess = new System.Windows.Forms.BindingSource(this.components);
            this.epAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAccountList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).BeginInit();
            this.pnlButtonTab.SuspendLayout();
            this.tlpAccountButtonTab.SuspendLayout();
            this.tcAccountMenu.SuspendLayout();
            this.tpAccountDetails.SuspendLayout();
            this.flpAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersRole)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpCommandButton.SuspendLayout();
            this.tpDeletedUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedUsers)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpAccountAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeactivatedUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccountList
            // 
            this.pnlAccountList.Controls.Add(this.txtSearch);
            this.pnlAccountList.Controls.Add(this.dgvAccount);
            this.pnlAccountList.Controls.Add(this.paginator);
            this.pnlAccountList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccountList.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountList.Name = "pnlAccountList";
            this.pnlAccountList.Padding = new System.Windows.Forms.Padding(2);
            this.pnlAccountList.Size = new System.Drawing.Size(554, 639);
            this.pnlAccountList.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BackColorOnError = System.Drawing.Color.Empty;
            this.txtSearch.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.txtSearch.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSearch.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtSearch.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.None;
            this.txtSearch.Location = new System.Drawing.Point(2, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = null;
            this.txtSearch.Required = false;
            this.txtSearch.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtSearch.RequiredForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.RequiredForeColorOnValidate = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtSearch.Size = new System.Drawing.Size(550, 27);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.ValidateOnLeave = false;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AllowUserToResizeColumns = false;
            this.dgvAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.AutoGenerateColumns = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.ColumnHeadersHeight = 30;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Role});
            this.dgvAccount.DataSource = this.bsAccounts;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccount.EllipseOnDefault = 0;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.dgvAccount.Location = new System.Drawing.Point(2, 78);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.RowHeadersWidth = 10;
            this.dgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccount.RowTemplate.Height = 40;
            this.dgvAccount.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.ShowCellErrors = false;
            this.dgvAccount.ShowCellToolTips = false;
            this.dgvAccount.ShowEditingIcon = false;
            this.dgvAccount.ShowRowErrors = false;
            this.dgvAccount.Size = new System.Drawing.Size(550, 512);
            this.dgvAccount.TabIndex = 29;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            this.dgvAccount.SelectionChanged += new System.EventHandler(this.dgvAccount_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 91.22443F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 117.405F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.FillWeight = 91.37056F;
            this.Role.HeaderText = "User Type";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // bsAccounts
            // 
            this.bsAccounts.DataSource = typeof(Petrol_Pump_Point_Of_Sale_System.Models.User);
            // 
            // paginator
            // 
            this.paginator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.paginator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginator.GetCurrentPage = 1;
            this.paginator.HasRecordCount = true;
            this.paginator.HasRefresh = true;
            this.paginator.Location = new System.Drawing.Point(2, 590);
            this.paginator.Name = "paginator";
            this.paginator.Size = new System.Drawing.Size(550, 47);
            this.paginator.TabIndex = 5;
            // 
            // pnlButtonTab
            // 
            this.pnlButtonTab.Controls.Add(this.tlpAccountButtonTab);
            this.pnlButtonTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonTab.Location = new System.Drawing.Point(554, 0);
            this.pnlButtonTab.Name = "pnlButtonTab";
            this.pnlButtonTab.Size = new System.Drawing.Size(516, 40);
            this.pnlButtonTab.TabIndex = 15;
            // 
            // tlpAccountButtonTab
            // 
            this.tlpAccountButtonTab.ColumnCount = 4;
            this.tlpAccountButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpAccountButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpAccountButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpAccountButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 623F));
            this.tlpAccountButtonTab.Controls.Add(this.btnUsersAccess, 0, 0);
            this.tlpAccountButtonTab.Controls.Add(this.btnDeletedUsers, 0, 0);
            this.tlpAccountButtonTab.Controls.Add(this.btnAccountDetails, 0, 0);
            this.tlpAccountButtonTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAccountButtonTab.Location = new System.Drawing.Point(0, 0);
            this.tlpAccountButtonTab.Name = "tlpAccountButtonTab";
            this.tlpAccountButtonTab.RowCount = 1;
            this.tlpAccountButtonTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAccountButtonTab.Size = new System.Drawing.Size(516, 40);
            this.tlpAccountButtonTab.TabIndex = 1;
            // 
            // btnUsersAccess
            // 
            this.btnUsersAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnUsersAccess.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnUsersAccess.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnUsersAccess.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnUsersAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsersAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsersAccess.EllipseOnClick = 0;
            this.btnUsersAccess.EllipseOnDefault = 0;
            this.btnUsersAccess.EllipseOnHover = 0;
            this.btnUsersAccess.FlatAppearance.BorderSize = 0;
            this.btnUsersAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnUsersAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnUsersAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersAccess.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnUsersAccess.ForeColor = System.Drawing.Color.White;
            this.btnUsersAccess.ForeColorOnClick = System.Drawing.Color.White;
            this.btnUsersAccess.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnUsersAccess.ForeColorOnHover = System.Drawing.Color.White;
            this.btnUsersAccess.Location = new System.Drawing.Point(302, 2);
            this.btnUsersAccess.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.btnUsersAccess.Name = "btnUsersAccess";
            this.btnUsersAccess.Size = new System.Drawing.Size(148, 36);
            this.btnUsersAccess.TabIndex = 13;
            this.btnUsersAccess.Text = "Account Access";
            this.btnUsersAccess.ToolTip = "";
            this.btnUsersAccess.UseVisualStyleBackColor = false;
            this.btnUsersAccess.Visible = false;
            // 
            // btnDeletedUsers
            // 
            this.btnDeletedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeletedUsers.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeletedUsers.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeletedUsers.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeletedUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletedUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletedUsers.EllipseOnClick = 0;
            this.btnDeletedUsers.EllipseOnDefault = 0;
            this.btnDeletedUsers.EllipseOnHover = 0;
            this.btnDeletedUsers.FlatAppearance.BorderSize = 0;
            this.btnDeletedUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeletedUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeletedUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnDeletedUsers.ForeColor = System.Drawing.Color.White;
            this.btnDeletedUsers.ForeColorOnClick = System.Drawing.Color.White;
            this.btnDeletedUsers.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnDeletedUsers.ForeColorOnHover = System.Drawing.Color.White;
            this.btnDeletedUsers.Location = new System.Drawing.Point(152, 2);
            this.btnDeletedUsers.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.btnDeletedUsers.Name = "btnDeletedUsers";
            this.btnDeletedUsers.Size = new System.Drawing.Size(148, 36);
            this.btnDeletedUsers.TabIndex = 11;
            this.btnDeletedUsers.Text = "Deleted Users";
            this.btnDeletedUsers.ToolTip = "";
            this.btnDeletedUsers.UseVisualStyleBackColor = false;
            // 
            // btnAccountDetails
            // 
            this.btnAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnAccountDetails.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountDetails.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnAccountDetails.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountDetails.EllipseOnClick = 0;
            this.btnAccountDetails.EllipseOnDefault = 0;
            this.btnAccountDetails.EllipseOnHover = 0;
            this.btnAccountDetails.FlatAppearance.BorderSize = 0;
            this.btnAccountDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnAccountDetails.ForeColor = System.Drawing.Color.White;
            this.btnAccountDetails.ForeColorOnClick = System.Drawing.Color.White;
            this.btnAccountDetails.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnAccountDetails.ForeColorOnHover = System.Drawing.Color.White;
            this.btnAccountDetails.Location = new System.Drawing.Point(2, 2);
            this.btnAccountDetails.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.btnAccountDetails.Name = "btnAccountDetails";
            this.btnAccountDetails.Size = new System.Drawing.Size(148, 36);
            this.btnAccountDetails.TabIndex = 12;
            this.btnAccountDetails.Text = "Account Details";
            this.btnAccountDetails.ToolTip = "";
            this.btnAccountDetails.UseVisualStyleBackColor = false;
            // 
            // tcAccountMenu
            // 
            this.tcAccountMenu.Controls.Add(this.tpAccountDetails);
            this.tcAccountMenu.Controls.Add(this.tpDeletedUsers);
            this.tcAccountMenu.Controls.Add(this.tpAccountAccess);
            this.tcAccountMenu.Depth = 0;
            this.tcAccountMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAccountMenu.Location = new System.Drawing.Point(554, 40);
            this.tcAccountMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcAccountMenu.Name = "tcAccountMenu";
            this.tcAccountMenu.SelectedIndex = 0;
            this.tcAccountMenu.Size = new System.Drawing.Size(516, 599);
            this.tcAccountMenu.TabIndex = 16;
            // 
            // tpAccountDetails
            // 
            this.tpAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpAccountDetails.Controls.Add(this.flpAccountDetails);
            this.tpAccountDetails.Controls.Add(this.tlpCommandButton);
            this.tpAccountDetails.Location = new System.Drawing.Point(4, 22);
            this.tpAccountDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tpAccountDetails.Name = "tpAccountDetails";
            this.tpAccountDetails.Padding = new System.Windows.Forms.Padding(2);
            this.tpAccountDetails.Size = new System.Drawing.Size(508, 573);
            this.tpAccountDetails.TabIndex = 1;
            this.tpAccountDetails.Text = "AccountView Details";
            // 
            // flpAccountDetails
            // 
            this.flpAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.flpAccountDetails.Controls.Add(this.label1);
            this.flpAccountDetails.Controls.Add(this.txtUsername);
            this.flpAccountDetails.Controls.Add(this.label2);
            this.flpAccountDetails.Controls.Add(this.txtPassword);
            this.flpAccountDetails.Controls.Add(this.label3);
            this.flpAccountDetails.Controls.Add(this.txtName);
            this.flpAccountDetails.Controls.Add(this.label4);
            this.flpAccountDetails.Controls.Add(this.txtUserRole);
            this.flpAccountDetails.Controls.Add(this.tableLayoutPanel1);
            this.flpAccountDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAccountDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAccountDetails.Location = new System.Drawing.Point(2, 2);
            this.flpAccountDetails.Margin = new System.Windows.Forms.Padding(0);
            this.flpAccountDetails.Name = "flpAccountDetails";
            this.flpAccountDetails.Padding = new System.Windows.Forms.Padding(25);
            this.flpAccountDetails.Size = new System.Drawing.Size(504, 522);
            this.flpAccountDetails.TabIndex = 1;
            this.flpAccountDetails.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUsername.BackColorOnEnter = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BackColorOnError = System.Drawing.Color.Empty;
            this.txtUsername.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUsername.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtUsername.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Enabled = false;
            this.flpAccountDetails.SetFlowBreak(this.txtUsername, true);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUsername.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUsername.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUsername.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUsername.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epAccount.SetIconPadding(this.txtUsername, 5);
            this.txtUsername.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtUsername.Location = new System.Drawing.Point(25, 70);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceHolder = null;
            this.txtUsername.Required = true;
            this.txtUsername.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtUsername.RequiredForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUsername.RequiredForeColorOnValidate = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtUsername.Size = new System.Drawing.Size(438, 27);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.ValidateOnLeave = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPassword.BackColorOnEnter = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BackColorOnError = System.Drawing.Color.Empty;
            this.txtPassword.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPassword.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Enabled = false;
            this.flpAccountDetails.SetFlowBreak(this.txtPassword, true);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPassword.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtPassword.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPassword.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPassword.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epAccount.SetIconPadding(this.txtPassword, 5);
            this.txtPassword.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtPassword.Location = new System.Drawing.Point(25, 122);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolder = null;
            this.txtPassword.Required = true;
            this.txtPassword.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtPassword.RequiredForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPassword.RequiredForeColorOnValidate = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtPassword.Size = new System.Drawing.Size(438, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.ValidateOnLeave = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Account Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtName.BackColorOnEnter = System.Drawing.Color.WhiteSmoke;
            this.txtName.BackColorOnError = System.Drawing.Color.Empty;
            this.txtName.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtName.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtName.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Enabled = false;
            this.flpAccountDetails.SetFlowBreak(this.txtName, true);
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtName.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epAccount.SetIconPadding(this.txtName, 5);
            this.txtName.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtName.Location = new System.Drawing.Point(25, 174);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.PlaceHolder = "";
            this.txtName.Required = true;
            this.txtName.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtName.RequiredForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtName.RequiredForeColorOnValidate = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtName.Size = new System.Drawing.Size(438, 27);
            this.txtName.TabIndex = 9;
            this.txtName.ValidateOnLeave = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Type";
            // 
            // txtUserRole
            // 
            this.txtUserRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtUserRole.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtUserRole.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtUserRole.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtUserRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsUsersRole, "Id", true));
            this.txtUserRole.DataSource = this.bsUsersRole;
            this.txtUserRole.DisplayMember = "UserRoleName";
            this.txtUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUserRole.Enabled = false;
            this.txtUserRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUserRole.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserRole.ForeColor = System.Drawing.Color.White;
            this.txtUserRole.ForeColorOnClick = System.Drawing.Color.White;
            this.txtUserRole.ForeColorOnDefault = System.Drawing.Color.White;
            this.txtUserRole.ForeColorOnHover = System.Drawing.Color.White;
            this.txtUserRole.FormattingEnabled = true;
            this.txtUserRole.Location = new System.Drawing.Point(28, 229);
            this.txtUserRole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(432, 28);
            this.txtUserRole.TabIndex = 13;
            this.txtUserRole.ValueMember = "Id";
            // 
            // bsUsersRole
            // 
            this.bsUsersRole.DataSource = typeof(Petrol_Pump_Point_Of_Sale_System.Models.UserRole);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveChanges, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 268);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 47);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSaveChanges.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSaveChanges.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSaveChanges.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveChanges.EllipseOnClick = 0;
            this.btnSaveChanges.EllipseOnDefault = 0;
            this.btnSaveChanges.EllipseOnHover = 0;
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.ForeColorOnClick = System.Drawing.Color.White;
            this.btnSaveChanges.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnSaveChanges.ForeColorOnHover = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(289, 2);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(142, 43);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.ToolTip = "";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnCancel.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnCancel.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnCancel.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.EllipseOnClick = 0;
            this.btnCancel.EllipseOnDefault = 0;
            this.btnCancel.EllipseOnHover = 0;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ForeColorOnClick = System.Drawing.Color.White;
            this.btnCancel.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnCancel.ForeColorOnHover = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(145, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ToolTip = "";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tlpCommandButton
            // 
            this.tlpCommandButton.ColumnCount = 3;
            this.tlpCommandButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCommandButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCommandButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCommandButton.Controls.Add(this.btnDeleteAccount, 2, 0);
            this.tlpCommandButton.Controls.Add(this.btnAddAccount, 1, 0);
            this.tlpCommandButton.Controls.Add(this.btnEdit, 0, 0);
            this.tlpCommandButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpCommandButton.Location = new System.Drawing.Point(2, 524);
            this.tlpCommandButton.Name = "tlpCommandButton";
            this.tlpCommandButton.RowCount = 1;
            this.tlpCommandButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCommandButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpCommandButton.Size = new System.Drawing.Size(504, 47);
            this.tlpCommandButton.TabIndex = 0;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteAccount.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteAccount.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteAccount.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteAccount.EllipseOnClick = 0;
            this.btnDeleteAccount.EllipseOnDefault = 0;
            this.btnDeleteAccount.EllipseOnHover = 0;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.ForeColorOnClick = System.Drawing.Color.White;
            this.btnDeleteAccount.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnDeleteAccount.ForeColorOnHover = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(337, 2);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(166, 43);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Deactivate";
            this.btnDeleteAccount.ToolTip = "";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnAddAccount.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnAddAccount.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnAddAccount.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAccount.EllipseOnClick = 0;
            this.btnAddAccount.EllipseOnDefault = 0;
            this.btnAddAccount.EllipseOnHover = 0;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.ForeColorOnClick = System.Drawing.Color.White;
            this.btnAddAccount.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnAddAccount.ForeColorOnHover = System.Drawing.Color.White;
            this.btnAddAccount.Location = new System.Drawing.Point(169, 2);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(166, 43);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.ToolTip = "";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnEdit.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.btnEdit.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnEdit.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.EllipseOnClick = 0;
            this.btnEdit.EllipseOnDefault = 0;
            this.btnEdit.EllipseOnHover = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ForeColorOnClick = System.Drawing.Color.White;
            this.btnEdit.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnEdit.ForeColorOnHover = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1, 2);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 43);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit Account";
            this.btnEdit.ToolTip = "";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tpDeletedUsers
            // 
            this.tpDeletedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpDeletedUsers.Controls.Add(this.dgvDeletedUsers);
            this.tpDeletedUsers.Controls.Add(this.tableLayoutPanel2);
            this.tpDeletedUsers.Location = new System.Drawing.Point(4, 22);
            this.tpDeletedUsers.Margin = new System.Windows.Forms.Padding(0);
            this.tpDeletedUsers.Name = "tpDeletedUsers";
            this.tpDeletedUsers.Padding = new System.Windows.Forms.Padding(2);
            this.tpDeletedUsers.Size = new System.Drawing.Size(508, 573);
            this.tpDeletedUsers.TabIndex = 2;
            this.tpDeletedUsers.Text = "Remove Users";
            // 
            // dgvDeletedUsers
            // 
            this.dgvDeletedUsers.AllowUserToAddRows = false;
            this.dgvDeletedUsers.AllowUserToDeleteRows = false;
            this.dgvDeletedUsers.AllowUserToResizeColumns = false;
            this.dgvDeletedUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvDeletedUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDeletedUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDeletedUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvDeletedUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeletedUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeletedUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDeletedUsers.ColumnHeadersHeight = 30;
            this.dgvDeletedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDeletedUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDeletedUsers.EllipseOnDefault = 0;
            this.dgvDeletedUsers.EnableHeadersVisualStyles = false;
            this.dgvDeletedUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.dgvDeletedUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.dgvDeletedUsers.Location = new System.Drawing.Point(2, 16);
            this.dgvDeletedUsers.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDeletedUsers.MultiSelect = false;
            this.dgvDeletedUsers.Name = "dgvDeletedUsers";
            this.dgvDeletedUsers.ReadOnly = true;
            this.dgvDeletedUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDeletedUsers.RowHeadersVisible = false;
            this.dgvDeletedUsers.RowHeadersWidth = 10;
            this.dgvDeletedUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeletedUsers.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDeletedUsers.RowTemplate.Height = 40;
            this.dgvDeletedUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeletedUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeletedUsers.ShowCellErrors = false;
            this.dgvDeletedUsers.ShowCellToolTips = false;
            this.dgvDeletedUsers.ShowEditingIcon = false;
            this.dgvDeletedUsers.ShowRowErrors = false;
            this.dgvDeletedUsers.Size = new System.Drawing.Size(504, 508);
            this.dgvDeletedUsers.TabIndex = 30;
            this.dgvDeletedUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeletedUsers_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.btnPermanentDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActivateAccount, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 524);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(504, 47);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // btnPermanentDelete
            // 
            this.btnPermanentDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPermanentDelete.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPermanentDelete.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPermanentDelete.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPermanentDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPermanentDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPermanentDelete.EllipseOnClick = 0;
            this.btnPermanentDelete.EllipseOnDefault = 0;
            this.btnPermanentDelete.EllipseOnHover = 0;
            this.btnPermanentDelete.FlatAppearance.BorderSize = 0;
            this.btnPermanentDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPermanentDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPermanentDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermanentDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnPermanentDelete.ForeColor = System.Drawing.Color.White;
            this.btnPermanentDelete.ForeColorOnClick = System.Drawing.Color.White;
            this.btnPermanentDelete.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnPermanentDelete.ForeColorOnHover = System.Drawing.Color.White;
            this.btnPermanentDelete.Location = new System.Drawing.Point(302, 2);
            this.btnPermanentDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPermanentDelete.Name = "btnPermanentDelete";
            this.btnPermanentDelete.Size = new System.Drawing.Size(201, 43);
            this.btnPermanentDelete.TabIndex = 2;
            this.btnPermanentDelete.Text = "Delete Account";
            this.btnPermanentDelete.ToolTip = "";
            this.btnPermanentDelete.UseVisualStyleBackColor = false;
            this.btnPermanentDelete.Click += new System.EventHandler(this.btnPermanentDelete_Click);
            // 
            // btnActivateAccount
            // 
            this.btnActivateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnActivateAccount.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnActivateAccount.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnActivateAccount.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnActivateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivateAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActivateAccount.EllipseOnClick = 0;
            this.btnActivateAccount.EllipseOnDefault = 0;
            this.btnActivateAccount.EllipseOnHover = 0;
            this.btnActivateAccount.FlatAppearance.BorderSize = 0;
            this.btnActivateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnActivateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnActivateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnActivateAccount.ForeColor = System.Drawing.Color.White;
            this.btnActivateAccount.ForeColorOnClick = System.Drawing.Color.White;
            this.btnActivateAccount.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnActivateAccount.ForeColorOnHover = System.Drawing.Color.White;
            this.btnActivateAccount.Location = new System.Drawing.Point(101, 2);
            this.btnActivateAccount.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnActivateAccount.Name = "btnActivateAccount";
            this.btnActivateAccount.Size = new System.Drawing.Size(199, 43);
            this.btnActivateAccount.TabIndex = 1;
            this.btnActivateAccount.Text = "Restore Account";
            this.btnActivateAccount.ToolTip = "";
            this.btnActivateAccount.UseVisualStyleBackColor = false;
            this.btnActivateAccount.Click += new System.EventHandler(this.btnActivateAccount_Click);
            // 
            // tpAccountAccess
            // 
            this.tpAccountAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpAccountAccess.Controls.Add(this.dgvAccountAccess);
            this.tpAccountAccess.Location = new System.Drawing.Point(4, 22);
            this.tpAccountAccess.Name = "tpAccountAccess";
            this.tpAccountAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountAccess.Size = new System.Drawing.Size(508, 573);
            this.tpAccountAccess.TabIndex = 3;
            this.tpAccountAccess.Text = "AccountView Access";
            // 
            // dgvAccountAccess
            // 
            this.dgvAccountAccess.AllowUserToAddRows = false;
            this.dgvAccountAccess.AllowUserToDeleteRows = false;
            this.dgvAccountAccess.AllowUserToResizeColumns = false;
            this.dgvAccountAccess.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            this.dgvAccountAccess.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAccountAccess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountAccess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAccountAccess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvAccountAccess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccountAccess.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccountAccess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountAccess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAccountAccess.ColumnHeadersHeight = 30;
            this.dgvAccountAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountAccess.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAccountAccess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccountAccess.EllipseOnDefault = 0;
            this.dgvAccountAccess.EnableHeadersVisualStyles = false;
            this.dgvAccountAccess.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.dgvAccountAccess.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.dgvAccountAccess.Location = new System.Drawing.Point(3, 49);
            this.dgvAccountAccess.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAccountAccess.MultiSelect = false;
            this.dgvAccountAccess.Name = "dgvAccountAccess";
            this.dgvAccountAccess.ReadOnly = true;
            this.dgvAccountAccess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountAccess.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAccountAccess.RowHeadersVisible = false;
            this.dgvAccountAccess.RowHeadersWidth = 10;
            this.dgvAccountAccess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountAccess.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAccountAccess.RowTemplate.Height = 40;
            this.dgvAccountAccess.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountAccess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountAccess.ShowCellErrors = false;
            this.dgvAccountAccess.ShowCellToolTips = false;
            this.dgvAccountAccess.ShowEditingIcon = false;
            this.dgvAccountAccess.ShowRowErrors = false;
            this.dgvAccountAccess.Size = new System.Drawing.Size(502, 521);
            this.dgvAccountAccess.TabIndex = 31;
            // 
            // bsDeactivatedUsers
            // 
            this.bsDeactivatedUsers.AllowNew = false;
            this.bsDeactivatedUsers.DataSource = typeof(Petrol_Pump_Point_Of_Sale_System.Models.User);
            // 
            // bsUsersAccess
            // 
            this.bsUsersAccess.AllowNew = false;
            this.bsUsersAccess.DataSource = typeof(Petrol_Pump_Point_Of_Sale_System.Models.UserAccess);
            // 
            // epAccount
            // 
            this.epAccount.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epAccount.ContainerControl = this;
            this.epAccount.Icon = ((System.Drawing.Icon)(resources.GetObject("epAccount.Icon")));
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tcAccountMenu);
            this.Controls.Add(this.pnlButtonTab);
            this.Controls.Add(this.pnlAccountList);
            this.Name = "AccountView";
            this.Size = new System.Drawing.Size(1070, 639);
            this.Load += new System.EventHandler(this.AccountView_Load);
            this.pnlAccountList.ResumeLayout(false);
            this.pnlAccountList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).EndInit();
            this.pnlButtonTab.ResumeLayout(false);
            this.tlpAccountButtonTab.ResumeLayout(false);
            this.tcAccountMenu.ResumeLayout(false);
            this.tpAccountDetails.ResumeLayout(false);
            this.flpAccountDetails.ResumeLayout(false);
            this.flpAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersRole)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpCommandButton.ResumeLayout(false);
            this.tpDeletedUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedUsers)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tpAccountAccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeactivatedUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    
        private System.Windows.Forms.Panel pnlAccountList;
        private System.Windows.Forms.Panel pnlButtonTab;
        private System.Windows.Forms.TableLayoutPanel tlpAccountButtonTab;
        private MaterialSkin.Controls.MaterialTabControl tcAccountMenu;
        private System.Windows.Forms.TabPage tpAccountDetails;
        private System.Windows.Forms.TabPage tpDeletedUsers;
        private System.Windows.Forms.TabPage tpAccountAccess;
        private Custom.PaginatorView paginator;
        private Components.FlatButton btnDeletedUsers;
        private Components.FlatButton btnAccountDetails;
        private Components.FlatButton btnUsersAccess;
        private FlatTable dgvAccount;
        private FlatTable dgvDeletedUsers;
        private FlatTable dgvAccountAccess;
        private FlatTextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flpAccountDetails;
        private System.Windows.Forms.TableLayoutPanel tlpCommandButton;
        private Components.FlatButton btnDeleteAccount;
        private Components.FlatButton btnAddAccount;
        private Components.FlatButton btnEdit;
        private System.Windows.Forms.BindingSource bsAccounts;
        private System.ComponentModel.BackgroundWorker bwAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FlatComboBox txtUserRole;
        private System.Windows.Forms.BindingSource bsUsersRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.FlatButton btnSaveChanges;
        private Components.FlatButton btnCancel;
        private System.Windows.Forms.BindingSource bsDeactivatedUsers;
        private System.Windows.Forms.BindingSource bsUsersAccess;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Components.FlatButton btnPermanentDelete;
        private Components.FlatButton btnActivateAccount;
        private FlatTextBox txtUsername;
        private FlatTextBox txtPassword;
        private System.Windows.Forms.ErrorProvider epAccount;
        private FlatTextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}

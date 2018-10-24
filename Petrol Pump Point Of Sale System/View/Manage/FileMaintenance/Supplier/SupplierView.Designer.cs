using Petrol_Pump_Point_Of_Sale_System.Components;

namespace Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Supplier
{
    partial class SupplierView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierView));
            this.tcPumpAttendantMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tpSupplierList = new System.Windows.Forms.TabPage();
            this.command = new Petrol_Pump_Point_Of_Sale_System.View.Custom.CommandView();
            this.dgvSupplier = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTable();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSuppliers = new System.Windows.Forms.BindingSource(this.components);
            this.paginator = new Petrol_Pump_Point_Of_Sale_System.View.Custom.PaginatorView();
            this.tpSupplierDetails = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveChanges = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnCancel = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.txtEmail = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactNo = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplierName = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bwSuppliers = new System.ComponentModel.BackgroundWorker();
            this.epSuppliers = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpAttendantButtonTab = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeactivate = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnList = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnDetails = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnRateHistory = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.tcPumpAttendantMenu.SuspendLayout();
            this.tpSupplierList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).BeginInit();
            this.tpSupplierDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSuppliers)).BeginInit();
            this.tlpAttendantButtonTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPumpAttendantMenu
            // 
            this.tcPumpAttendantMenu.Controls.Add(this.tpSupplierList);
            this.tcPumpAttendantMenu.Controls.Add(this.tpSupplierDetails);
            this.tcPumpAttendantMenu.Depth = 0;
            this.tcPumpAttendantMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPumpAttendantMenu.Location = new System.Drawing.Point(0, 40);
            this.tcPumpAttendantMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcPumpAttendantMenu.Name = "tcPumpAttendantMenu";
            this.tcPumpAttendantMenu.SelectedIndex = 0;
            this.tcPumpAttendantMenu.Size = new System.Drawing.Size(1065, 624);
            this.tcPumpAttendantMenu.TabIndex = 13;
            // 
            // tpSupplierList
            // 
            this.tpSupplierList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpSupplierList.Controls.Add(this.command);
            this.tpSupplierList.Controls.Add(this.dgvSupplier);
            this.tpSupplierList.Controls.Add(this.paginator);
            this.tpSupplierList.Location = new System.Drawing.Point(4, 22);
            this.tpSupplierList.Margin = new System.Windows.Forms.Padding(0);
            this.tpSupplierList.Name = "tpSupplierList";
            this.tpSupplierList.Padding = new System.Windows.Forms.Padding(4);
            this.tpSupplierList.Size = new System.Drawing.Size(1057, 598);
            this.tpSupplierList.TabIndex = 0;
            this.tpSupplierList.Text = "Pump Attendance List";
            // 
            // command
            // 
            this.command.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.command.Dock = System.Windows.Forms.DockStyle.Top;
            this.command.GetSearchedValue = "";
            this.command.Location = new System.Drawing.Point(4, 4);
            this.command.Name = "command";
            this.command.ShowActionButtons = true;
            this.command.ShowSearchBar = true;
            this.command.Size = new System.Drawing.Size(1049, 53);
            this.command.TabIndex = 7;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.AllowUserToResizeColumns = false;
            this.dgvSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.AutoGenerateColumns = false;
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplier.ColumnHeadersHeight = 30;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SupplierName,
            this.addressDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.Email});
            this.dgvSupplier.DataSource = this.bsSuppliers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSupplier.EllipseOnDefault = 0;
            this.dgvSupplier.EnableHeadersVisualStyles = false;
            this.dgvSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.dgvSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.dgvSupplier.Location = new System.Drawing.Point(4, 75);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSupplier.MultiSelect = false;
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.RowHeadersWidth = 10;
            this.dgvSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSupplier.RowTemplate.Height = 40;
            this.dgvSupplier.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.ShowCellErrors = false;
            this.dgvSupplier.ShowCellToolTips = false;
            this.dgvSupplier.ShowEditingIcon = false;
            this.dgvSupplier.ShowRowErrors = false;
            this.dgvSupplier.Size = new System.Drawing.Size(1049, 469);
            this.dgvSupplier.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // bsSuppliers
            // 
            this.bsSuppliers.DataSource = typeof(Petrol_Pump_Point_Of_Sale_System.Models.Supplier);
            // 
            // paginator
            // 
            this.paginator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginator.GetCurrentPage = 1;
            this.paginator.HasRecordCount = true;
            this.paginator.HasRefresh = true;
            this.paginator.Location = new System.Drawing.Point(4, 544);
            this.paginator.Name = "paginator";
            this.paginator.Size = new System.Drawing.Size(1049, 50);
            this.paginator.TabIndex = 6;
            // 
            // tpSupplierDetails
            // 
            this.tpSupplierDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpSupplierDetails.Controls.Add(this.tableLayoutPanel1);
            this.tpSupplierDetails.Controls.Add(this.txtEmail);
            this.tpSupplierDetails.Controls.Add(this.label7);
            this.tpSupplierDetails.Controls.Add(this.txtContactNo);
            this.tpSupplierDetails.Controls.Add(this.label6);
            this.tpSupplierDetails.Controls.Add(this.txtAddress);
            this.tpSupplierDetails.Controls.Add(this.label4);
            this.tpSupplierDetails.Controls.Add(this.txtSupplierName);
            this.tpSupplierDetails.Controls.Add(this.label1);
            this.tpSupplierDetails.Location = new System.Drawing.Point(4, 22);
            this.tpSupplierDetails.Name = "tpSupplierDetails";
            this.tpSupplierDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpSupplierDetails.Size = new System.Drawing.Size(1057, 598);
            this.tpSupplierDetails.TabIndex = 1;
            this.tpSupplierDetails.Text = "tabPage1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveChanges, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(336, 305);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 47);
            this.tableLayoutPanel1.TabIndex = 65;
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
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
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
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtEmail.BackColorOnError = System.Drawing.Color.Empty;
            this.txtEmail.BackColorOnLeave = System.Drawing.Color.White;
            this.txtEmail.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtEmail.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtEmail.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtEmail.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtEmail.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtEmail.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtEmail.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtEmail.Location = new System.Drawing.Point(404, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceHolder = null;
            this.txtEmail.Required = true;
            this.txtEmail.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtEmail.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtEmail.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtEmail.Size = new System.Drawing.Size(363, 27);
            this.txtEmail.TabIndex = 64;
            this.txtEmail.ValidateOnLeave = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(288, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Email Address";
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtContactNo.BackColorOnError = System.Drawing.Color.Empty;
            this.txtContactNo.BackColorOnLeave = System.Drawing.Color.White;
            this.txtContactNo.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtContactNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtContactNo.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtContactNo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtContactNo.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtContactNo.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtContactNo.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtContactNo.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtContactNo.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.NumericNoSpace;
            this.txtContactNo.Location = new System.Drawing.Point(404, 205);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PlaceHolder = null;
            this.txtContactNo.Required = true;
            this.txtContactNo.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtContactNo.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtContactNo.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtContactNo.Size = new System.Drawing.Size(363, 27);
            this.txtContactNo.TabIndex = 62;
            this.txtContactNo.ValidateOnLeave = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(288, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Contact No.";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtAddress.BackColorOnError = System.Drawing.Color.Empty;
            this.txtAddress.BackColorOnLeave = System.Drawing.Color.White;
            this.txtAddress.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtAddress.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtAddress.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtAddress.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAddress.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAddress.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAddress.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.Alphabet;
            this.txtAddress.Location = new System.Drawing.Point(405, 164);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceHolder = null;
            this.txtAddress.Required = true;
            this.txtAddress.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtAddress.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtAddress.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtAddress.Size = new System.Drawing.Size(363, 27);
            this.txtAddress.TabIndex = 58;
            this.txtAddress.ValidateOnLeave = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(289, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Address";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.Color.White;
            this.txtSupplierName.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtSupplierName.BackColorOnError = System.Drawing.Color.Empty;
            this.txtSupplierName.BackColorOnLeave = System.Drawing.Color.White;
            this.txtSupplierName.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSupplierName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtSupplierName.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSupplierName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtSupplierName.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSupplierName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSupplierName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSupplierName.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumericNoSpace;
            this.txtSupplierName.Location = new System.Drawing.Point(405, 124);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PlaceHolder = null;
            this.txtSupplierName.Required = true;
            this.txtSupplierName.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtSupplierName.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtSupplierName.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtSupplierName.Size = new System.Drawing.Size(363, 27);
            this.txtSupplierName.TabIndex = 53;
            this.txtSupplierName.ValidateOnLeave = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(289, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Supplier Name";
            // 
            // epSuppliers
            // 
            this.epSuppliers.ContainerControl = this;
            this.epSuppliers.Icon = ((System.Drawing.Icon)(resources.GetObject("epSuppliers.Icon")));
            // 
            // tlpAttendantButtonTab
            // 
            this.tlpAttendantButtonTab.ColumnCount = 5;
            this.tlpAttendantButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpAttendantButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpAttendantButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpAttendantButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpAttendantButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tlpAttendantButtonTab.Controls.Add(this.btnDeactivate, 3, 0);
            this.tlpAttendantButtonTab.Controls.Add(this.btnList, 0, 0);
            this.tlpAttendantButtonTab.Controls.Add(this.btnDetails, 1, 0);
            this.tlpAttendantButtonTab.Controls.Add(this.btnRateHistory, 2, 0);
            this.tlpAttendantButtonTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAttendantButtonTab.Location = new System.Drawing.Point(0, 0);
            this.tlpAttendantButtonTab.Name = "tlpAttendantButtonTab";
            this.tlpAttendantButtonTab.RowCount = 1;
            this.tlpAttendantButtonTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAttendantButtonTab.Size = new System.Drawing.Size(1065, 40);
            this.tlpAttendantButtonTab.TabIndex = 14;
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeactivate.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeactivate.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeactivate.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeactivate.EllipseOnClick = 0;
            this.btnDeactivate.EllipseOnDefault = 0;
            this.btnDeactivate.EllipseOnHover = 0;
            this.btnDeactivate.FlatAppearance.BorderSize = 0;
            this.btnDeactivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeactivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnDeactivate.ForeColor = System.Drawing.Color.White;
            this.btnDeactivate.ForeColorOnClick = System.Drawing.Color.White;
            this.btnDeactivate.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnDeactivate.ForeColorOnHover = System.Drawing.Color.White;
            this.btnDeactivate.Location = new System.Drawing.Point(452, 2);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(148, 36);
            this.btnDeactivate.TabIndex = 51;
            this.btnDeactivate.Text = "Inactive Products";
            this.btnDeactivate.ToolTip = "";
            this.btnDeactivate.UseVisualStyleBackColor = false;
            this.btnDeactivate.Visible = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnList.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnList.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnList.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnList.EllipseOnClick = 0;
            this.btnList.EllipseOnDefault = 0;
            this.btnList.EllipseOnHover = 0;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.ForeColorOnClick = System.Drawing.Color.White;
            this.btnList.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnList.ForeColorOnHover = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(2, 2);
            this.btnList.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(148, 36);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "Supplier List";
            this.btnList.ToolTip = "";
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDetails.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDetails.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDetails.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetails.EllipseOnClick = 0;
            this.btnDetails.EllipseOnDefault = 0;
            this.btnDetails.EllipseOnHover = 0;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.ForeColorOnClick = System.Drawing.Color.White;
            this.btnDetails.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnDetails.ForeColorOnHover = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(152, 2);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(148, 36);
            this.btnDetails.TabIndex = 9;
            this.btnDetails.Text = "Supplier Details";
            this.btnDetails.ToolTip = "";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnRateHistory
            // 
            this.btnRateHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnRateHistory.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnRateHistory.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnRateHistory.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnRateHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRateHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRateHistory.EllipseOnClick = 0;
            this.btnRateHistory.EllipseOnDefault = 0;
            this.btnRateHistory.EllipseOnHover = 0;
            this.btnRateHistory.FlatAppearance.BorderSize = 0;
            this.btnRateHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnRateHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnRateHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRateHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnRateHistory.ForeColor = System.Drawing.Color.White;
            this.btnRateHistory.ForeColorOnClick = System.Drawing.Color.White;
            this.btnRateHistory.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnRateHistory.ForeColorOnHover = System.Drawing.Color.White;
            this.btnRateHistory.Location = new System.Drawing.Point(302, 2);
            this.btnRateHistory.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.btnRateHistory.Name = "btnRateHistory";
            this.btnRateHistory.Size = new System.Drawing.Size(148, 36);
            this.btnRateHistory.TabIndex = 10;
            this.btnRateHistory.Text = "Rate History";
            this.btnRateHistory.ToolTip = "";
            this.btnRateHistory.UseVisualStyleBackColor = false;
            this.btnRateHistory.Visible = false;
            // 
            // SupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tcPumpAttendantMenu);
            this.Controls.Add(this.tlpAttendantButtonTab);
            this.Name = "SupplierView";
            this.Size = new System.Drawing.Size(1065, 664);
            this.tcPumpAttendantMenu.ResumeLayout(false);
            this.tpSupplierList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).EndInit();
            this.tpSupplierDetails.ResumeLayout(false);
            this.tpSupplierDetails.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epSuppliers)).EndInit();
            this.tlpAttendantButtonTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tcPumpAttendantMenu;
        private System.Windows.Forms.TabPage tpSupplierList;
        private FlatTable dgvSupplier;
        private System.ComponentModel.BackgroundWorker bwSuppliers;
        private System.Windows.Forms.BindingSource bsSuppliers;
        private System.Windows.Forms.ErrorProvider epSuppliers;
        private System.Windows.Forms.TableLayoutPanel tlpAttendantButtonTab;
        private FlatButton btnDeactivate;
        private FlatButton btnList;
        private FlatButton btnDetails;
        private FlatButton btnRateHistory;
        private System.Windows.Forms.TabPage tpSupplierDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FlatButton btnSaveChanges;
        private FlatButton btnCancel;
        private FlatTextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private FlatTextBox txtContactNo;
        private System.Windows.Forms.Label label6;
        private FlatTextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private FlatTextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private Custom.PaginatorView paginator;
        private Custom.CommandView command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

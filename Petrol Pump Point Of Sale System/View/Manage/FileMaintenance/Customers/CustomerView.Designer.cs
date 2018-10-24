using Petrol_Pump_Point_Of_Sale_System.Components;

namespace Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Customers
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            this.tcPumpAttendantMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tpCustomerList = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTable();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.tpCustomerDetails = new System.Windows.Forms.TabPage();
            this.txtVehicleType = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveChanges = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnCancel = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.txtVehicleNo = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactNo = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplierName = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bwCustomers = new System.ComponentModel.BackgroundWorker();
            this.epCustomers = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpCustomerButtonTab = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeactivate = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnList = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnDetails = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnRateHistory = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.command = new Petrol_Pump_Point_Of_Sale_System.View.Custom.CommandView();
            this.paginator = new Petrol_Pump_Point_Of_Sale_System.View.Custom.PaginatorView();
            this.tcPumpAttendantMenu.SuspendLayout();
            this.tpCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.tpCustomerDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomers)).BeginInit();
            this.tlpCustomerButtonTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPumpAttendantMenu
            // 
            this.tcPumpAttendantMenu.Controls.Add(this.tpCustomerList);
            this.tcPumpAttendantMenu.Controls.Add(this.tpCustomerDetails);
            this.tcPumpAttendantMenu.Depth = 0;
            this.tcPumpAttendantMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPumpAttendantMenu.Location = new System.Drawing.Point(0, 40);
            this.tcPumpAttendantMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcPumpAttendantMenu.Name = "tcPumpAttendantMenu";
            this.tcPumpAttendantMenu.SelectedIndex = 0;
            this.tcPumpAttendantMenu.Size = new System.Drawing.Size(1065, 624);
            this.tcPumpAttendantMenu.TabIndex = 13;
            // 
            // tpCustomerList
            // 
            this.tpCustomerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpCustomerList.Controls.Add(this.command);
            this.tpCustomerList.Controls.Add(this.dgvCustomers);
            this.tpCustomerList.Controls.Add(this.paginator);
            this.tpCustomerList.Location = new System.Drawing.Point(4, 22);
            this.tpCustomerList.Margin = new System.Windows.Forms.Padding(0);
            this.tpCustomerList.Name = "tpCustomerList";
            this.tpCustomerList.Padding = new System.Windows.Forms.Padding(4);
            this.tpCustomerList.Size = new System.Drawing.Size(1057, 598);
            this.tpCustomerList.TabIndex = 0;
            this.tpCustomerList.Text = "Pump Attendance List";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeight = 30;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerCodeDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.vehicleNoDataGridViewTextBoxColumn,
            this.VehicleType});
            this.dgvCustomers.DataSource = this.bsCustomers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomers.EllipseOnDefault = 0;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.dgvCustomers.Location = new System.Drawing.Point(4, 75);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 10;
            this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomers.RowTemplate.Height = 40;
            this.dgvCustomers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.ShowCellErrors = false;
            this.dgvCustomers.ShowCellToolTips = false;
            this.dgvCustomers.ShowEditingIcon = false;
            this.dgvCustomers.ShowRowErrors = false;
            this.dgvCustomers.Size = new System.Drawing.Size(1049, 469);
            this.dgvCustomers.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerCodeDataGridViewTextBoxColumn
            // 
            this.customerCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerCode";
            this.customerCodeDataGridViewTextBoxColumn.HeaderText = "Customer Code";
            this.customerCodeDataGridViewTextBoxColumn.Name = "customerCodeDataGridViewTextBoxColumn";
            this.customerCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleNoDataGridViewTextBoxColumn
            // 
            this.vehicleNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleNo";
            this.vehicleNoDataGridViewTextBoxColumn.HeaderText = "Vehicle No";
            this.vehicleNoDataGridViewTextBoxColumn.Name = "vehicleNoDataGridViewTextBoxColumn";
            this.vehicleNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "Vehicle Type";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // bsCustomers
            // 
            this.bsCustomers.DataSource = typeof(Petrol_Pump_Point_Of_Sale_System.Models.Customer);
            // 
            // tpCustomerDetails
            // 
            this.tpCustomerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpCustomerDetails.Controls.Add(this.txtVehicleType);
            this.tpCustomerDetails.Controls.Add(this.label2);
            this.tpCustomerDetails.Controls.Add(this.tableLayoutPanel1);
            this.tpCustomerDetails.Controls.Add(this.txtVehicleNo);
            this.tpCustomerDetails.Controls.Add(this.label7);
            this.tpCustomerDetails.Controls.Add(this.txtContactNo);
            this.tpCustomerDetails.Controls.Add(this.label6);
            this.tpCustomerDetails.Controls.Add(this.txtCustomerCode);
            this.tpCustomerDetails.Controls.Add(this.label4);
            this.tpCustomerDetails.Controls.Add(this.txtSupplierName);
            this.tpCustomerDetails.Controls.Add(this.label1);
            this.tpCustomerDetails.Location = new System.Drawing.Point(4, 22);
            this.tpCustomerDetails.Name = "tpCustomerDetails";
            this.tpCustomerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomerDetails.Size = new System.Drawing.Size(1057, 598);
            this.tpCustomerDetails.TabIndex = 1;
            this.tpCustomerDetails.Text = "Customer Details";
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.BackColor = System.Drawing.Color.White;
            this.txtVehicleType.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtVehicleType.BackColorOnError = System.Drawing.Color.Empty;
            this.txtVehicleType.BackColorOnLeave = System.Drawing.Color.White;
            this.txtVehicleType.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtVehicleType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtVehicleType.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtVehicleType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtVehicleType.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtVehicleType.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtVehicleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtVehicleType.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtVehicleType.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtVehicleType.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtVehicleType.Location = new System.Drawing.Point(404, 287);
            this.txtVehicleType.Margin = new System.Windows.Forms.Padding(0);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.PlaceHolder = null;
            this.txtVehicleType.Required = true;
            this.txtVehicleType.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtVehicleType.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtVehicleType.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtVehicleType.Size = new System.Drawing.Size(363, 27);
            this.txtVehicleType.TabIndex = 67;
            this.txtVehicleType.ValidateOnLeave = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(280, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Vehicle Type";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveChanges, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(336, 352);
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
            // txtVehicleNo
            // 
            this.txtVehicleNo.BackColor = System.Drawing.Color.White;
            this.txtVehicleNo.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtVehicleNo.BackColorOnError = System.Drawing.Color.Empty;
            this.txtVehicleNo.BackColorOnLeave = System.Drawing.Color.White;
            this.txtVehicleNo.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtVehicleNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtVehicleNo.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtVehicleNo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtVehicleNo.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtVehicleNo.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtVehicleNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtVehicleNo.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtVehicleNo.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtVehicleNo.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtVehicleNo.Location = new System.Drawing.Point(404, 249);
            this.txtVehicleNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.PlaceHolder = null;
            this.txtVehicleNo.Required = true;
            this.txtVehicleNo.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtVehicleNo.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtVehicleNo.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtVehicleNo.Size = new System.Drawing.Size(363, 27);
            this.txtVehicleNo.TabIndex = 64;
            this.txtVehicleNo.ValidateOnLeave = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(280, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Vehicle No";
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
            this.label6.Location = new System.Drawing.Point(286, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Contact No.";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.BackColor = System.Drawing.Color.White;
            this.txtCustomerCode.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtCustomerCode.BackColorOnError = System.Drawing.Color.Empty;
            this.txtCustomerCode.BackColorOnLeave = System.Drawing.Color.White;
            this.txtCustomerCode.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCustomerCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtCustomerCode.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCustomerCode.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCustomerCode.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtCustomerCode.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCustomerCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtCustomerCode.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtCustomerCode.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtCustomerCode.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.Alphabet;
            this.txtCustomerCode.Location = new System.Drawing.Point(405, 164);
            this.txtCustomerCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.PlaceHolder = null;
            this.txtCustomerCode.Required = true;
            this.txtCustomerCode.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtCustomerCode.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtCustomerCode.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtCustomerCode.Size = new System.Drawing.Size(363, 27);
            this.txtCustomerCode.TabIndex = 58;
            this.txtCustomerCode.ValidateOnLeave = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(280, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Customer Code";
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
            this.label1.Location = new System.Drawing.Point(275, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Customer Name";
            // 
            // epCustomers
            // 
            this.epCustomers.ContainerControl = this;
            this.epCustomers.Icon = ((System.Drawing.Icon)(resources.GetObject("epCustomers.Icon")));
            // 
            // tlpCustomerButtonTab
            // 
            this.tlpCustomerButtonTab.ColumnCount = 5;
            this.tlpCustomerButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpCustomerButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpCustomerButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpCustomerButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpCustomerButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tlpCustomerButtonTab.Controls.Add(this.btnDeactivate, 3, 0);
            this.tlpCustomerButtonTab.Controls.Add(this.btnList, 0, 0);
            this.tlpCustomerButtonTab.Controls.Add(this.btnDetails, 1, 0);
            this.tlpCustomerButtonTab.Controls.Add(this.btnRateHistory, 2, 0);
            this.tlpCustomerButtonTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCustomerButtonTab.Location = new System.Drawing.Point(0, 0);
            this.tlpCustomerButtonTab.Name = "tlpCustomerButtonTab";
            this.tlpCustomerButtonTab.RowCount = 1;
            this.tlpCustomerButtonTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCustomerButtonTab.Size = new System.Drawing.Size(1065, 40);
            this.tlpCustomerButtonTab.TabIndex = 14;
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
            this.btnList.Text = "Customer List";
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
            this.btnDetails.Text = "Customer Details";
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
            // paginator
            // 
            this.paginator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginator.GetCurrentPage = 1;
            this.paginator.HasRecordCount = true;
            this.paginator.HasRefresh = true;
            this.paginator.Location = new System.Drawing.Point(4, 544);
            this.paginator.Name = "paginator";
            this.paginator.Size = new System.Drawing.Size(1049, 50);
            this.paginator.TabIndex = 8;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tcPumpAttendantMenu);
            this.Controls.Add(this.tlpCustomerButtonTab);
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(1065, 664);
            this.tcPumpAttendantMenu.ResumeLayout(false);
            this.tpCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.tpCustomerDetails.ResumeLayout(false);
            this.tpCustomerDetails.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epCustomers)).EndInit();
            this.tlpCustomerButtonTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tcPumpAttendantMenu;
        private System.Windows.Forms.TabPage tpCustomerList;
        private FlatTable dgvCustomers;
        private System.ComponentModel.BackgroundWorker bwCustomers;
        private System.Windows.Forms.BindingSource bsCustomers;
        private System.Windows.Forms.ErrorProvider epCustomers;
        private System.Windows.Forms.TableLayoutPanel tlpCustomerButtonTab;
        private FlatButton btnDeactivate;
        private FlatButton btnList;
        private FlatButton btnDetails;
        private FlatButton btnRateHistory;
        private System.Windows.Forms.TabPage tpCustomerDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FlatButton btnSaveChanges;
        private FlatButton btnCancel;
        private FlatTextBox txtVehicleNo;
        private System.Windows.Forms.Label label7;
        private FlatTextBox txtContactNo;
        private System.Windows.Forms.Label label6;
        private FlatTextBox txtCustomerCode;
        private System.Windows.Forms.Label label4;
        private FlatTextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private FlatTextBox txtVehicleType;
        private System.Windows.Forms.Label label2;
        private Custom.CommandView command;
        private Custom.PaginatorView paginator;
    }
}

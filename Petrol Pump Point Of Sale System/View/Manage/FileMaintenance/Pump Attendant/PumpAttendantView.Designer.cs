using Petrol_Pump_Point_Of_Sale_System.Components;
using Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Customers;

namespace Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Pump_Attendant
{
    partial class PumpAttendantView
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
            this.tpAttendantList = new System.Windows.Forms.TabPage();
            this.command = new Petrol_Pump_Point_Of_Sale_System.View.Custom.CommandView();
            this.dgvPumpAttendant = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTable();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAppliedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateResignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPumpAttendants = new System.Windows.Forms.BindingSource(this.components);
            this.tpAttendantDetails = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveChanges = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnCancel = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.txtAttendantAddress = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactNo = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.txtAttendantCode = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bwAttendants = new System.ComponentModel.BackgroundWorker();
            this.epPumpAttendants = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpAttendantButtonTab = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeactivate = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnList = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnDetails = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnRateHistory = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.paginator = new Petrol_Pump_Point_Of_Sale_System.View.Custom.PaginatorView();
            this.tcPumpAttendantMenu.SuspendLayout();
            this.tpAttendantList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPumpAttendant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPumpAttendants)).BeginInit();
            this.tpAttendantDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPumpAttendants)).BeginInit();
            this.tlpAttendantButtonTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPumpAttendantMenu
            // 
            this.tcPumpAttendantMenu.Controls.Add(this.tpAttendantList);
            this.tcPumpAttendantMenu.Controls.Add(this.tpAttendantDetails);
            this.tcPumpAttendantMenu.Depth = 0;
            this.tcPumpAttendantMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPumpAttendantMenu.Location = new System.Drawing.Point(0, 40);
            this.tcPumpAttendantMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcPumpAttendantMenu.Name = "tcPumpAttendantMenu";
            this.tcPumpAttendantMenu.SelectedIndex = 0;
            this.tcPumpAttendantMenu.Size = new System.Drawing.Size(1065, 624);
            this.tcPumpAttendantMenu.TabIndex = 13;
            // 
            // tpAttendantList
            // 
            this.tpAttendantList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpAttendantList.Controls.Add(this.command);
            this.tpAttendantList.Controls.Add(this.dgvPumpAttendant);
            this.tpAttendantList.Controls.Add(this.paginator);
            this.tpAttendantList.Location = new System.Drawing.Point(4, 22);
            this.tpAttendantList.Margin = new System.Windows.Forms.Padding(0);
            this.tpAttendantList.Name = "tpAttendantList";
            this.tpAttendantList.Padding = new System.Windows.Forms.Padding(4);
            this.tpAttendantList.Size = new System.Drawing.Size(1057, 598);
            this.tpAttendantList.TabIndex = 0;
            this.tpAttendantList.Text = "Pump Attendance List";
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
            this.command.TabIndex = 5;
            // 
            // dgvPumpAttendant
            // 
            this.dgvPumpAttendant.AllowUserToAddRows = false;
            this.dgvPumpAttendant.AllowUserToDeleteRows = false;
            this.dgvPumpAttendant.AllowUserToResizeColumns = false;
            this.dgvPumpAttendant.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvPumpAttendant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPumpAttendant.AutoGenerateColumns = false;
            this.dgvPumpAttendant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPumpAttendant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPumpAttendant.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvPumpAttendant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPumpAttendant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPumpAttendant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPumpAttendant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPumpAttendant.ColumnHeadersHeight = 30;
            this.dgvPumpAttendant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPumpAttendant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.employeeCodeDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.dateAppliedDataGridViewTextBoxColumn,
            this.dateHiredDataGridViewTextBoxColumn,
            this.dateResignedDataGridViewTextBoxColumn});
            this.dgvPumpAttendant.DataSource = this.bsPumpAttendants;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPumpAttendant.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPumpAttendant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPumpAttendant.EllipseOnDefault = 0;
            this.dgvPumpAttendant.EnableHeadersVisualStyles = false;
            this.dgvPumpAttendant.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.dgvPumpAttendant.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.dgvPumpAttendant.Location = new System.Drawing.Point(4, 75);
            this.dgvPumpAttendant.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPumpAttendant.MultiSelect = false;
            this.dgvPumpAttendant.Name = "dgvPumpAttendant";
            this.dgvPumpAttendant.ReadOnly = true;
            this.dgvPumpAttendant.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPumpAttendant.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPumpAttendant.RowHeadersVisible = false;
            this.dgvPumpAttendant.RowHeadersWidth = 10;
            this.dgvPumpAttendant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPumpAttendant.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPumpAttendant.RowTemplate.Height = 40;
            this.dgvPumpAttendant.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPumpAttendant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPumpAttendant.ShowCellErrors = false;
            this.dgvPumpAttendant.ShowCellToolTips = false;
            this.dgvPumpAttendant.ShowEditingIcon = false;
            this.dgvPumpAttendant.ShowRowErrors = false;
            this.dgvPumpAttendant.Size = new System.Drawing.Size(1049, 469);
            this.dgvPumpAttendant.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // employeeCodeDataGridViewTextBoxColumn
            // 
            this.employeeCodeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCode";
            this.employeeCodeDataGridViewTextBoxColumn.HeaderText = "Attendant Code";
            this.employeeCodeDataGridViewTextBoxColumn.Name = "employeeCodeDataGridViewTextBoxColumn";
            this.employeeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dateAppliedDataGridViewTextBoxColumn
            // 
            this.dateAppliedDataGridViewTextBoxColumn.DataPropertyName = "DateApplied";
            this.dateAppliedDataGridViewTextBoxColumn.HeaderText = "Date Applied";
            this.dateAppliedDataGridViewTextBoxColumn.Name = "dateAppliedDataGridViewTextBoxColumn";
            this.dateAppliedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAppliedDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateHiredDataGridViewTextBoxColumn
            // 
            this.dateHiredDataGridViewTextBoxColumn.DataPropertyName = "DateHired";
            this.dateHiredDataGridViewTextBoxColumn.HeaderText = "Date Hired";
            this.dateHiredDataGridViewTextBoxColumn.Name = "dateHiredDataGridViewTextBoxColumn";
            this.dateHiredDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateHiredDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateResignedDataGridViewTextBoxColumn
            // 
            this.dateResignedDataGridViewTextBoxColumn.DataPropertyName = "DateResigned";
            this.dateResignedDataGridViewTextBoxColumn.HeaderText = "Date Resigned";
            this.dateResignedDataGridViewTextBoxColumn.Name = "dateResignedDataGridViewTextBoxColumn";
            this.dateResignedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateResignedDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsPumpAttendants
            // 
            this.bsPumpAttendants.DataSource = typeof(Petrol_Pump_Point_Of_Sale_System.Models.Employee);
            // 
            // tpAttendantDetails
            // 
            this.tpAttendantDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpAttendantDetails.Controls.Add(this.tableLayoutPanel1);
            this.tpAttendantDetails.Controls.Add(this.txtAttendantAddress);
            this.tpAttendantDetails.Controls.Add(this.label7);
            this.tpAttendantDetails.Controls.Add(this.txtContactNo);
            this.tpAttendantDetails.Controls.Add(this.label6);
            this.tpAttendantDetails.Controls.Add(this.txtLastName);
            this.tpAttendantDetails.Controls.Add(this.label4);
            this.tpAttendantDetails.Controls.Add(this.txtFirstName);
            this.tpAttendantDetails.Controls.Add(this.txtAttendantCode);
            this.tpAttendantDetails.Controls.Add(this.label2);
            this.tpAttendantDetails.Controls.Add(this.label1);
            this.tpAttendantDetails.Location = new System.Drawing.Point(4, 22);
            this.tpAttendantDetails.Name = "tpAttendantDetails";
            this.tpAttendantDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpAttendantDetails.Size = new System.Drawing.Size(1057, 598);
            this.tpAttendantDetails.TabIndex = 1;
            this.tpAttendantDetails.Text = "tabPage1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveChanges, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(337, 350);
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
            // txtAttendantAddress
            // 
            this.txtAttendantAddress.BackColor = System.Drawing.Color.White;
            this.txtAttendantAddress.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtAttendantAddress.BackColorOnError = System.Drawing.Color.Empty;
            this.txtAttendantAddress.BackColorOnLeave = System.Drawing.Color.White;
            this.txtAttendantAddress.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAttendantAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtAttendantAddress.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAttendantAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtAttendantAddress.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtAttendantAddress.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtAttendantAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAttendantAddress.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAttendantAddress.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAttendantAddress.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtAttendantAddress.Location = new System.Drawing.Point(405, 294);
            this.txtAttendantAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAttendantAddress.Name = "txtAttendantAddress";
            this.txtAttendantAddress.PlaceHolder = null;
            this.txtAttendantAddress.Required = true;
            this.txtAttendantAddress.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtAttendantAddress.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtAttendantAddress.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtAttendantAddress.Size = new System.Drawing.Size(363, 27);
            this.txtAttendantAddress.TabIndex = 64;
            this.txtAttendantAddress.ValidateOnLeave = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(289, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Address";
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
            this.txtContactNo.Location = new System.Drawing.Point(405, 250);
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
            this.label6.Location = new System.Drawing.Point(289, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Contact No.";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtLastName.BackColorOnError = System.Drawing.Color.Empty;
            this.txtLastName.BackColorOnLeave = System.Drawing.Color.White;
            this.txtLastName.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtLastName.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtLastName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtLastName.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtLastName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtLastName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtLastName.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.Alphabet;
            this.txtLastName.Location = new System.Drawing.Point(406, 209);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceHolder = null;
            this.txtLastName.Required = true;
            this.txtLastName.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtLastName.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtLastName.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtLastName.Size = new System.Drawing.Size(363, 27);
            this.txtLastName.TabIndex = 58;
            this.txtLastName.ValidateOnLeave = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(290, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtFirstName.BackColorOnError = System.Drawing.Color.Empty;
            this.txtFirstName.BackColorOnLeave = System.Drawing.Color.White;
            this.txtFirstName.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtFirstName.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtFirstName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtFirstName.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtFirstName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtFirstName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtFirstName.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.Alphabet;
            this.txtFirstName.Location = new System.Drawing.Point(405, 164);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceHolder = null;
            this.txtFirstName.Required = true;
            this.txtFirstName.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtFirstName.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtFirstName.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtFirstName.Size = new System.Drawing.Size(363, 27);
            this.txtFirstName.TabIndex = 54;
            this.txtFirstName.ValidateOnLeave = false;
            // 
            // txtAttendantCode
            // 
            this.txtAttendantCode.BackColor = System.Drawing.Color.White;
            this.txtAttendantCode.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtAttendantCode.BackColorOnError = System.Drawing.Color.Empty;
            this.txtAttendantCode.BackColorOnLeave = System.Drawing.Color.White;
            this.txtAttendantCode.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAttendantCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtAttendantCode.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAttendantCode.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtAttendantCode.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtAttendantCode.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtAttendantCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAttendantCode.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAttendantCode.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtAttendantCode.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumericNoSpace;
            this.txtAttendantCode.Location = new System.Drawing.Point(405, 124);
            this.txtAttendantCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtAttendantCode.Name = "txtAttendantCode";
            this.txtAttendantCode.PlaceHolder = null;
            this.txtAttendantCode.Required = true;
            this.txtAttendantCode.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtAttendantCode.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtAttendantCode.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtAttendantCode.Size = new System.Drawing.Size(363, 27);
            this.txtAttendantCode.TabIndex = 53;
            this.txtAttendantCode.ValidateOnLeave = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(289, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(289, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Attendant Code";
            // 
            // epPumpAttendants
            // 
            this.epPumpAttendants.ContainerControl = this;
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
            this.btnList.Text = "Attendant List";
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
            this.btnDetails.Text = "Attendant Details";
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
            // PumpAttendantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tcPumpAttendantMenu);
            this.Controls.Add(this.tlpAttendantButtonTab);
            this.Name = "PumpAttendantView";
            this.Size = new System.Drawing.Size(1065, 664);
            this.tcPumpAttendantMenu.ResumeLayout(false);
            this.tpAttendantList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPumpAttendant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPumpAttendants)).EndInit();
            this.tpAttendantDetails.ResumeLayout(false);
            this.tpAttendantDetails.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epPumpAttendants)).EndInit();
            this.tlpAttendantButtonTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tcPumpAttendantMenu;
        private System.Windows.Forms.TabPage tpAttendantList;
        private FlatTable dgvPumpAttendant;
        private System.ComponentModel.BackgroundWorker bwAttendants;
        private System.Windows.Forms.BindingSource bsPumpAttendants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAppliedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateHiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateResignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider epPumpAttendants;
        private System.Windows.Forms.TableLayoutPanel tlpAttendantButtonTab;
        private FlatButton btnDeactivate;
        private FlatButton btnList;
        private FlatButton btnDetails;
        private FlatButton btnRateHistory;
        private System.Windows.Forms.TabPage tpAttendantDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FlatButton btnSaveChanges;
        private FlatButton btnCancel;
        private FlatTextBox txtAttendantAddress;
        private System.Windows.Forms.Label label7;
        private FlatTextBox txtContactNo;
        private System.Windows.Forms.Label label6;
        private FlatTextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private FlatTextBox txtFirstName;
        private FlatTextBox txtAttendantCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Custom.CommandView command;
        private Custom.PaginatorView paginator;
    }
}

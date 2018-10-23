using Petrol_Pump_Point_Of_Sale_System.Components;

namespace Petrol_Pump_Point_Of_Sale_System.View.Product
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.pnlButtonTab = new System.Windows.Forms.Panel();
            this.tlpProductButtonTab = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeactivate = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnList = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnDetails = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnRateHistory = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.tcProductMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tpProductList = new System.Windows.Forms.TabPage();
            this.command = new Petrol_Pump_Point_Of_Sale_System.View.Custom.CommandView();
            this.dgvProduct = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTable();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.paginator = new Petrol_Pump_Point_Of_Sale_System.View.Custom.PaginatorView();
            this.tpProductDetails = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveChanges = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.btnCancel = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.txtPurchaseRate = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalesRate = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.txtProductCode = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpRateHistory = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flatButton1 = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.flatButton2 = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.bwProducts = new System.ComponentModel.BackgroundWorker();
            this.epProducts = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlButtonTab.SuspendLayout();
            this.tlpProductButtonTab.SuspendLayout();
            this.tcProductMenu.SuspendLayout();
            this.tpProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            this.tpProductDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtonTab
            // 
            this.pnlButtonTab.Controls.Add(this.tlpProductButtonTab);
            this.pnlButtonTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonTab.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonTab.Name = "pnlButtonTab";
            this.pnlButtonTab.Size = new System.Drawing.Size(1065, 40);
            this.pnlButtonTab.TabIndex = 11;
            // 
            // tlpProductButtonTab
            // 
            this.tlpProductButtonTab.ColumnCount = 5;
            this.tlpProductButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpProductButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpProductButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpProductButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpProductButtonTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tlpProductButtonTab.Controls.Add(this.btnDeactivate, 3, 0);
            this.tlpProductButtonTab.Controls.Add(this.btnList, 0, 0);
            this.tlpProductButtonTab.Controls.Add(this.btnDetails, 1, 0);
            this.tlpProductButtonTab.Controls.Add(this.btnRateHistory, 2, 0);
            this.tlpProductButtonTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProductButtonTab.Location = new System.Drawing.Point(0, 0);
            this.tlpProductButtonTab.Name = "tlpProductButtonTab";
            this.tlpProductButtonTab.RowCount = 1;
            this.tlpProductButtonTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProductButtonTab.Size = new System.Drawing.Size(1065, 40);
            this.tlpProductButtonTab.TabIndex = 1;
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
            this.btnList.Text = "Product List";
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
            this.btnDetails.Text = "Product Details";
            this.btnDetails.ToolTip = "";
            this.btnDetails.UseVisualStyleBackColor = false;
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
            // tcProductMenu
            // 
            this.tcProductMenu.Controls.Add(this.tpProductList);
            this.tcProductMenu.Controls.Add(this.tpProductDetails);
            this.tcProductMenu.Controls.Add(this.tpRateHistory);
            this.tcProductMenu.Controls.Add(this.tabPage1);
            this.tcProductMenu.Depth = 0;
            this.tcProductMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProductMenu.Location = new System.Drawing.Point(0, 40);
            this.tcProductMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcProductMenu.Name = "tcProductMenu";
            this.tcProductMenu.SelectedIndex = 0;
            this.tcProductMenu.Size = new System.Drawing.Size(1065, 624);
            this.tcProductMenu.TabIndex = 12;
            // 
            // tpProductList
            // 
            this.tpProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpProductList.Controls.Add(this.command);
            this.tpProductList.Controls.Add(this.dgvProduct);
            this.tpProductList.Controls.Add(this.paginator);
            this.tpProductList.Location = new System.Drawing.Point(4, 22);
            this.tpProductList.Margin = new System.Windows.Forms.Padding(0);
            this.tpProductList.Name = "tpProductList";
            this.tpProductList.Padding = new System.Windows.Forms.Padding(4);
            this.tpProductList.Size = new System.Drawing.Size(1057, 598);
            this.tpProductList.TabIndex = 0;
            this.tpProductList.Text = "Products List";
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
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeight = 30;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.salesRateDataGridViewTextBoxColumn,
            this.purchaseRateDataGridViewTextBoxColumn});
            this.dgvProduct.DataSource = this.bsProducts;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProduct.EllipseOnDefault = 0;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.dgvProduct.Location = new System.Drawing.Point(4, 70);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 10;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.RowTemplate.Height = 40;
            this.dgvProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.ShowCellErrors = false;
            this.dgvProduct.ShowCellToolTips = false;
            this.dgvProduct.ShowEditingIcon = false;
            this.dgvProduct.ShowRowErrors = false;
            this.dgvProduct.Size = new System.Drawing.Size(1049, 477);
            this.dgvProduct.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Product Code";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesRateDataGridViewTextBoxColumn
            // 
            this.salesRateDataGridViewTextBoxColumn.DataPropertyName = "SalesRate";
            this.salesRateDataGridViewTextBoxColumn.HeaderText = "Sales Rate";
            this.salesRateDataGridViewTextBoxColumn.Name = "salesRateDataGridViewTextBoxColumn";
            this.salesRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseRateDataGridViewTextBoxColumn
            // 
            this.purchaseRateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseRate";
            this.purchaseRateDataGridViewTextBoxColumn.HeaderText = "Purchase Rate";
            this.purchaseRateDataGridViewTextBoxColumn.Name = "purchaseRateDataGridViewTextBoxColumn";
            this.purchaseRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsProducts
            // 
            this.bsProducts.DataSource = typeof(Petrol_Pump_Point_Of_Sale_System.Models.Products);
            // 
            // paginator
            // 
            this.paginator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.paginator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginator.GetCurrentPage = 1;
            this.paginator.HasRecordCount = false;
            this.paginator.HasRefresh = false;
            this.paginator.Location = new System.Drawing.Point(4, 547);
            this.paginator.Name = "paginator";
            this.paginator.Size = new System.Drawing.Size(1049, 47);
            this.paginator.TabIndex = 6;
            // 
            // tpProductDetails
            // 
            this.tpProductDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpProductDetails.Controls.Add(this.tableLayoutPanel1);
            this.tpProductDetails.Controls.Add(this.txtPurchaseRate);
            this.tpProductDetails.Controls.Add(this.label7);
            this.tpProductDetails.Controls.Add(this.txtSalesRate);
            this.tpProductDetails.Controls.Add(this.label6);
            this.tpProductDetails.Controls.Add(this.txtQuantity);
            this.tpProductDetails.Controls.Add(this.label5);
            this.tpProductDetails.Controls.Add(this.txtUnit);
            this.tpProductDetails.Controls.Add(this.label4);
            this.tpProductDetails.Controls.Add(this.txtDescription);
            this.tpProductDetails.Controls.Add(this.label3);
            this.tpProductDetails.Controls.Add(this.txtProductName);
            this.tpProductDetails.Controls.Add(this.txtProductCode);
            this.tpProductDetails.Controls.Add(this.label2);
            this.tpProductDetails.Controls.Add(this.label1);
            this.epProducts.SetIconPadding(this.tpProductDetails, 10);
            this.tpProductDetails.Location = new System.Drawing.Point(4, 22);
            this.tpProductDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tpProductDetails.Name = "tpProductDetails";
            this.tpProductDetails.Size = new System.Drawing.Size(1057, 598);
            this.tpProductDetails.TabIndex = 1;
            this.tpProductDetails.Text = "Products Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveChanges, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(301, 377);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 47);
            this.tableLayoutPanel1.TabIndex = 50;
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
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.BackColor = System.Drawing.Color.White;
            this.txtPurchaseRate.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtPurchaseRate.BackColorOnError = System.Drawing.Color.Empty;
            this.txtPurchaseRate.BackColorOnLeave = System.Drawing.Color.White;
            this.txtPurchaseRate.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPurchaseRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtPurchaseRate.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPurchaseRate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPurchaseRate.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtPurchaseRate.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPurchaseRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPurchaseRate.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPurchaseRate.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epProducts.SetIconPadding(this.txtPurchaseRate, 10);
            this.txtPurchaseRate.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.Decimal;
            this.txtPurchaseRate.Location = new System.Drawing.Point(370, 330);
            this.txtPurchaseRate.Margin = new System.Windows.Forms.Padding(0);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.PlaceHolder = null;
            this.txtPurchaseRate.Required = true;
            this.txtPurchaseRate.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtPurchaseRate.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtPurchaseRate.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtPurchaseRate.Size = new System.Drawing.Size(363, 27);
            this.txtPurchaseRate.TabIndex = 49;
            this.txtPurchaseRate.ValidateOnLeave = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(254, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Purchase Rate";
            // 
            // txtSalesRate
            // 
            this.txtSalesRate.BackColor = System.Drawing.Color.White;
            this.txtSalesRate.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtSalesRate.BackColorOnError = System.Drawing.Color.Empty;
            this.txtSalesRate.BackColorOnLeave = System.Drawing.Color.White;
            this.txtSalesRate.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSalesRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtSalesRate.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSalesRate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSalesRate.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtSalesRate.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSalesRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSalesRate.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSalesRate.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epProducts.SetIconPadding(this.txtSalesRate, 10);
            this.txtSalesRate.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.Decimal;
            this.txtSalesRate.Location = new System.Drawing.Point(370, 286);
            this.txtSalesRate.Margin = new System.Windows.Forms.Padding(0);
            this.txtSalesRate.Name = "txtSalesRate";
            this.txtSalesRate.PlaceHolder = null;
            this.txtSalesRate.Required = true;
            this.txtSalesRate.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtSalesRate.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtSalesRate.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtSalesRate.Size = new System.Drawing.Size(363, 27);
            this.txtSalesRate.TabIndex = 47;
            this.txtSalesRate.ValidateOnLeave = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(254, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sales Rate";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtQuantity.BackColorOnError = System.Drawing.Color.Empty;
            this.txtQuantity.BackColorOnLeave = System.Drawing.Color.White;
            this.txtQuantity.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtQuantity.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtQuantity.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtQuantity.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtQuantity.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtQuantity.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epProducts.SetIconPadding(this.txtQuantity, 10);
            this.txtQuantity.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.Numeric;
            this.txtQuantity.Location = new System.Drawing.Point(370, 239);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceHolder = null;
            this.txtQuantity.Required = true;
            this.txtQuantity.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtQuantity.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtQuantity.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtQuantity.Size = new System.Drawing.Size(363, 27);
            this.txtQuantity.TabIndex = 45;
            this.txtQuantity.ValidateOnLeave = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(254, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Quantity";
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtUnit.BackColorOnError = System.Drawing.Color.Empty;
            this.txtUnit.BackColorOnLeave = System.Drawing.Color.White;
            this.txtUnit.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtUnit.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUnit.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUnit.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUnit.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUnit.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epProducts.SetIconPadding(this.txtUnit, 10);
            this.txtUnit.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtUnit.Location = new System.Drawing.Point(370, 196);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(0);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PlaceHolder = null;
            this.txtUnit.Required = true;
            this.txtUnit.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtUnit.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtUnit.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtUnit.Size = new System.Drawing.Size(363, 27);
            this.txtUnit.TabIndex = 43;
            this.txtUnit.ValidateOnLeave = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(254, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Unit";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtDescription.BackColorOnError = System.Drawing.Color.Empty;
            this.txtDescription.BackColorOnLeave = System.Drawing.Color.White;
            this.txtDescription.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtDescription.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDescription.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtDescription.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtDescription.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtDescription.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epProducts.SetIconPadding(this.txtDescription, 10);
            this.txtDescription.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.Alphabet;
            this.txtDescription.Location = new System.Drawing.Point(370, 154);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceHolder = null;
            this.txtDescription.Required = false;
            this.txtDescription.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtDescription.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtDescription.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtDescription.Size = new System.Drawing.Size(363, 27);
            this.txtDescription.TabIndex = 41;
            this.txtDescription.ValidateOnLeave = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(254, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Description";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtProductName.BackColorOnError = System.Drawing.Color.Empty;
            this.txtProductName.BackColorOnLeave = System.Drawing.Color.White;
            this.txtProductName.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtProductName.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProductName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtProductName.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtProductName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtProductName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epProducts.SetIconPadding(this.txtProductName, 10);
            this.txtProductName.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumeric;
            this.txtProductName.Location = new System.Drawing.Point(370, 113);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceHolder = null;
            this.txtProductName.Required = true;
            this.txtProductName.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtProductName.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtProductName.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtProductName.Size = new System.Drawing.Size(363, 27);
            this.txtProductName.TabIndex = 39;
            this.txtProductName.ValidateOnLeave = false;
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.Color.White;
            this.txtProductCode.BackColorOnEnter = System.Drawing.SystemColors.Control;
            this.txtProductCode.BackColorOnError = System.Drawing.Color.Empty;
            this.txtProductCode.BackColorOnLeave = System.Drawing.Color.White;
            this.txtProductCode.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtProductCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtProductCode.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtProductCode.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProductCode.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtProductCode.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtProductCode.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtProductCode.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.epProducts.SetIconPadding(this.txtProductCode, 10);
            this.txtProductCode.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.AlphaNumericNoSpace;
            this.txtProductCode.Location = new System.Drawing.Point(370, 73);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PlaceHolder = null;
            this.txtProductCode.Required = true;
            this.txtProductCode.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtProductCode.RequiredForeColorOnLeave = System.Drawing.Color.White;
            this.txtProductCode.RequiredForeColorOnValidate = System.Drawing.Color.White;
            this.txtProductCode.Size = new System.Drawing.Size(363, 27);
            this.txtProductCode.TabIndex = 38;
            this.txtProductCode.ValidateOnLeave = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(254, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Products Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(254, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Products Code";
            // 
            // tpRateHistory
            // 
            this.tpRateHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpRateHistory.Location = new System.Drawing.Point(4, 22);
            this.tpRateHistory.Margin = new System.Windows.Forms.Padding(0);
            this.tpRateHistory.Name = "tpRateHistory";
            this.tpRateHistory.Size = new System.Drawing.Size(1057, 598);
            this.tpRateHistory.TabIndex = 2;
            this.tpRateHistory.Text = "Rate History";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1057, 598);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.flatButton1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.flatButton2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 548);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1051, 47);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton1.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton1.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton1.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatButton1.EllipseOnClick = 0;
            this.flatButton1.EllipseOnDefault = 0;
            this.flatButton1.EllipseOnHover = 0;
            this.flatButton1.Enabled = false;
            this.flatButton1.FlatAppearance.BorderSize = 0;
            this.flatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.ForeColorOnClick = System.Drawing.Color.White;
            this.flatButton1.ForeColorOnDefault = System.Drawing.Color.White;
            this.flatButton1.ForeColorOnHover = System.Drawing.Color.White;
            this.flatButton1.Location = new System.Drawing.Point(701, 2);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(349, 43);
            this.flatButton1.TabIndex = 2;
            this.flatButton1.Text = "Save Changes";
            this.flatButton1.ToolTip = "";
            this.flatButton1.UseVisualStyleBackColor = false;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton2.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton2.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton2.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatButton2.EllipseOnClick = 0;
            this.flatButton2.EllipseOnDefault = 0;
            this.flatButton2.EllipseOnHover = 0;
            this.flatButton2.Enabled = false;
            this.flatButton2.FlatAppearance.BorderSize = 0;
            this.flatButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.flatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.flatButton2.ForeColor = System.Drawing.Color.White;
            this.flatButton2.ForeColorOnClick = System.Drawing.Color.White;
            this.flatButton2.ForeColorOnDefault = System.Drawing.Color.White;
            this.flatButton2.ForeColorOnHover = System.Drawing.Color.White;
            this.flatButton2.Location = new System.Drawing.Point(351, 2);
            this.flatButton2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Size = new System.Drawing.Size(348, 43);
            this.flatButton2.TabIndex = 6;
            this.flatButton2.Text = "Cancel";
            this.flatButton2.ToolTip = "";
            this.flatButton2.UseVisualStyleBackColor = false;
            // 
            // epProducts
            // 
            this.epProducts.ContainerControl = this;
            this.epProducts.Icon = ((System.Drawing.Icon)(resources.GetObject("epProducts.Icon")));
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tcProductMenu);
            this.Controls.Add(this.pnlButtonTab);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(1065, 664);
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.pnlButtonTab.ResumeLayout(false);
            this.tlpProductButtonTab.ResumeLayout(false);
            this.tcProductMenu.ResumeLayout(false);
            this.tpProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.tpProductDetails.ResumeLayout(false);
            this.tpProductDetails.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FlatButton btnRateHistory;
        private Components.FlatButton btnDetails;
        private Components.FlatButton btnList;
        private System.Windows.Forms.Panel pnlButtonTab;
        private System.Windows.Forms.TableLayoutPanel tlpProductButtonTab;
        private MaterialSkin.Controls.MaterialTabControl tcProductMenu;
        private System.Windows.Forms.TabPage tpProductList;
        private System.Windows.Forms.TabPage tpProductDetails;
        private System.Windows.Forms.TabPage tpRateHistory;
        private FlatTable dgvProduct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingSource bsProducts;
        
        private System.ComponentModel.BackgroundWorker bwProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FlatButton flatButton1;
        private FlatButton flatButton2;
        private FlatTextBox txtPurchaseRate;
        private System.Windows.Forms.Label label7;
        private FlatTextBox txtSalesRate;
        private System.Windows.Forms.Label label6;
        private FlatTextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private FlatTextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private FlatTextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private FlatTextBox txtProductName;
        private FlatTextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FlatButton btnSaveChanges;
        private FlatButton btnCancel;
        private System.Windows.Forms.ErrorProvider epProducts;
        private FlatButton btnDeactivate;
        private Custom.PaginatorView paginator;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseRateDataGridViewTextBoxColumn;
        private Custom.CommandView command;
    }
}

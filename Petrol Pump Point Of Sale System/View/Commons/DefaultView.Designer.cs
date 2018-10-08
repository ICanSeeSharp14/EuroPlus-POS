namespace Petrol_Pump_Point_Of_Sale_System.View.Commons
{
    partial class DefaultView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpProductContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tpProductList = new System.Windows.Forms.TabPage();
            this.pnlAccountList = new System.Windows.Forms.Panel();
            this.txtSearch = new ITA_UI.FlatTextBox();
            this.dgvProductList = new ITSpecialProject.Components.FlatTable();
            this.pgProduct = new Petrol_Pump_Point_Of_Sale_System.View.Custom.PaginatorView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tpProductContainer.SuspendLayout();
            this.tpProductList.SuspendLayout();
            this.pnlAccountList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // tpProductContainer
            // 
            this.tpProductContainer.Controls.Add(this.tpProductList);
            this.tpProductContainer.Controls.Add(this.tabPage2);
            this.tpProductContainer.Depth = 0;
            this.tpProductContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpProductContainer.Location = new System.Drawing.Point(0, 221);
            this.tpProductContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpProductContainer.Name = "tpProductContainer";
            this.tpProductContainer.SelectedIndex = 0;
            this.tpProductContainer.Size = new System.Drawing.Size(853, 423);
            this.tpProductContainer.TabIndex = 1;
            // 
            // tpProductList
            // 
            this.tpProductList.Controls.Add(this.pnlAccountList);
            this.tpProductList.Location = new System.Drawing.Point(4, 22);
            this.tpProductList.Name = "tpProductList";
            this.tpProductList.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductList.Size = new System.Drawing.Size(845, 397);
            this.tpProductList.TabIndex = 0;
            this.tpProductList.Text = "tabPage1";
            this.tpProductList.UseVisualStyleBackColor = true;
            // 
            // pnlAccountList
            // 
            this.pnlAccountList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlAccountList.Controls.Add(this.txtSearch);
            this.pnlAccountList.Controls.Add(this.dgvProductList);
            this.pnlAccountList.Controls.Add(this.pgProduct);
            this.pnlAccountList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccountList.Location = new System.Drawing.Point(3, 3);
            this.pnlAccountList.Name = "pnlAccountList";
            this.pnlAccountList.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAccountList.Size = new System.Drawing.Size(839, 391);
            this.pnlAccountList.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSearch.FontOnEnter = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.FontOnLeave = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.InputValidation = ITA_UI.FlatTextBox.Validation.None;
            this.txtSearch.Location = new System.Drawing.Point(5, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = "Search product name";
            this.txtSearch.Size = new System.Drawing.Size(829, 33);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductList.ColumnHeadersHeight = 30;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductList.EllipseOnDefault = 0;
            this.dgvProductList.EnableHeadersVisualStyles = false;
            this.dgvProductList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.dgvProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.dgvProductList.Location = new System.Drawing.Point(5, 5);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProductList.MultiSelect = false;
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductList.RowHeadersWidth = 10;
            this.dgvProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductList.RowTemplate.Height = 40;
            this.dgvProductList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.ShowCellErrors = false;
            this.dgvProductList.ShowCellToolTips = false;
            this.dgvProductList.ShowEditingIcon = false;
            this.dgvProductList.ShowRowErrors = false;
            this.dgvProductList.Size = new System.Drawing.Size(829, 331);
            this.dgvProductList.TabIndex = 1;
            // 
            // pgProduct
            // 
            this.pgProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pgProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgProduct.HasRecordCount = false;
            this.pgProduct.HasRefresh = false;
            this.pgProduct.Location = new System.Drawing.Point(5, 336);
            this.pgProduct.Name = "pgProduct";
            this.pgProduct.Size = new System.Drawing.Size(829, 50);
            this.pgProduct.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // DefaultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpProductContainer);
            this.Name = "DefaultView";
            this.Size = new System.Drawing.Size(853, 644);
            this.tpProductContainer.ResumeLayout(false);
            this.tpProductList.ResumeLayout(false);
            this.pnlAccountList.ResumeLayout(false);
            this.pnlAccountList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tpProductContainer;
        private System.Windows.Forms.TabPage tpProductList;
        private System.Windows.Forms.Panel pnlAccountList;
        private ITA_UI.FlatTextBox txtSearch;
        private ITSpecialProject.Components.FlatTable dgvProductList;
        private Custom.PaginatorView pgProduct;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

﻿namespace Petrol_Pump_Point_Of_Sale_System.View.Home
{
    partial class DashboardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            this.flatPanel1 = new Petrol_Pump_Point_Of_Sale_System.Components.FlatPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GraphStatistics = new Bunifu.DataViz.BunifuDataViz();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowCardContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.cardSales = new Petrol_Pump_Point_Of_Sale_System.View.Home.DashboardCard();
            this.cardTransactions = new Petrol_Pump_Point_Of_Sale_System.View.Home.DashboardCard();
            this.cardCancelledTransactions = new Petrol_Pump_Point_Of_Sale_System.View.Home.DashboardCard();
            this.lblModuleTitle = new System.Windows.Forms.Label();
            this.flatPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowCardContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatPanel1
            // 
            this.flatPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flatPanel1.ColorAOnDefault = System.Drawing.Color.Transparent;
            this.flatPanel1.ColorBOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.flatPanel1.ColorCOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.flatPanel1.ColorToneOnDefault = ITSpecialProject.Commons.Enums.ColorCombination.SoloColor;
            this.flatPanel1.Controls.Add(this.panel2);
            this.flatPanel1.Controls.Add(this.panel1);
            this.flatPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatPanel1.EllipseOnDefault = 0;
            this.flatPanel1.GradientAngleOnDefault = 45;
            this.flatPanel1.Location = new System.Drawing.Point(25, 25);
            this.flatPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flatPanel1.Name = "flatPanel1";
            this.flatPanel1.Size = new System.Drawing.Size(950, 550);
            this.flatPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GraphStatistics);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 300);
            this.panel2.TabIndex = 4;
            // 
            // GraphStatistics
            // 
            this.GraphStatistics.animationEnabled = false;
            this.GraphStatistics.AxisLineColor = System.Drawing.Color.LightGray;
            this.GraphStatistics.AxisXFontColor = System.Drawing.Color.Gray;
            this.GraphStatistics.AxisXGridColor = System.Drawing.Color.Gray;
            this.GraphStatistics.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GraphStatistics.AxisYFontColor = System.Drawing.Color.Gray;
            this.GraphStatistics.AxisYGridColor = System.Drawing.Color.Gray;
            this.GraphStatistics.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GraphStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GraphStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphStatistics.Location = new System.Drawing.Point(0, 30);
            this.GraphStatistics.Name = "GraphStatistics";
            this.GraphStatistics.Size = new System.Drawing.Size(950, 270);
            this.GraphStatistics.TabIndex = 7;
            this.GraphStatistics.Theme = Bunifu.DataViz.BunifuDataViz._theme.theme1;
            this.GraphStatistics.Title = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(950, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Notifications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowCardContainer);
            this.panel1.Controls.Add(this.lblModuleTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 200);
            this.panel1.TabIndex = 3;
            // 
            // flowCardContainer
            // 
            this.flowCardContainer.Controls.Add(this.cardSales);
            this.flowCardContainer.Controls.Add(this.cardTransactions);
            this.flowCardContainer.Controls.Add(this.cardCancelledTransactions);
            this.flowCardContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCardContainer.Location = new System.Drawing.Point(0, 30);
            this.flowCardContainer.Margin = new System.Windows.Forms.Padding(0);
            this.flowCardContainer.Name = "flowCardContainer";
            this.flowCardContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowCardContainer.Size = new System.Drawing.Size(950, 170);
            this.flowCardContainer.TabIndex = 7;
            this.flowCardContainer.WrapContents = false;
            // 
            // cardSales
            // 
            this.cardSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.cardSales.CardIcon = global::Petrol_Pump_Point_Of_Sale_System.Properties.Resources.Sales_100;
            this.cardSales.CardText = "Sales";
            this.cardSales.CardValue = "0";
            this.cardSales.Location = new System.Drawing.Point(0, 10);
            this.cardSales.Margin = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.cardSales.Name = "cardSales";
            this.cardSales.NavigationBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSales.NavigationText = "Sales Report";
            this.cardSales.Size = new System.Drawing.Size(300, 125);
            this.cardSales.TabIndex = 0;
            // 
            // cardTransactions
            // 
            this.cardTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.cardTransactions.CardIcon = ((System.Drawing.Image)(resources.GetObject("cardTransactions.CardIcon")));
            this.cardTransactions.CardText = "Transactions";
            this.cardTransactions.CardValue = "0";
            this.cardTransactions.Location = new System.Drawing.Point(325, 10);
            this.cardTransactions.Margin = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.cardTransactions.Name = "cardTransactions";
            this.cardTransactions.NavigationBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardTransactions.NavigationText = "Sales Report";
            this.cardTransactions.Size = new System.Drawing.Size(300, 125);
            this.cardTransactions.TabIndex = 1;
            // 
            // cardCancelledTransactions
            // 
            this.cardCancelledTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cardCancelledTransactions.CardIcon = global::Petrol_Pump_Point_Of_Sale_System.Properties.Resources.Cancel_100;
            this.cardCancelledTransactions.CardText = "Cancelled Transactions";
            this.cardCancelledTransactions.CardValue = "0";
            this.cardCancelledTransactions.Location = new System.Drawing.Point(650, 10);
            this.cardCancelledTransactions.Margin = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.cardCancelledTransactions.Name = "cardCancelledTransactions";
            this.cardCancelledTransactions.NavigationBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCancelledTransactions.NavigationText = "Sales Report";
            this.cardCancelledTransactions.Size = new System.Drawing.Size(300, 125);
            this.cardCancelledTransactions.TabIndex = 2;
            // 
            // lblModuleTitle
            // 
            this.lblModuleTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lblModuleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModuleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lblModuleTitle.ForeColor = System.Drawing.Color.White;
            this.lblModuleTitle.Location = new System.Drawing.Point(0, 0);
            this.lblModuleTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblModuleTitle.Name = "lblModuleTitle";
            this.lblModuleTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblModuleTitle.Size = new System.Drawing.Size(950, 30);
            this.lblModuleTitle.TabIndex = 6;
            this.lblModuleTitle.Text = "Daily Statistics";
            this.lblModuleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.flatPanel1);
            this.Name = "DashboardView";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(1000, 600);
            this.flatPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowCardContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FlatPanel flatPanel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.DataViz.BunifuDataViz GraphStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowCardContainer;
        private DashboardCard cardSales;
        private DashboardCard cardTransactions;
        private DashboardCard cardCancelledTransactions;
        private System.Windows.Forms.Label lblModuleTitle;
    }
}

namespace Petrol_Pump_Point_Of_Sale_System.View.Commons
{
    partial class PumpCardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PumpCardView));
            this.pnlIsAvailable = new System.Windows.Forms.Panel();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.flatPictureBox1 = new ITA_UI.Classes.Controls.FlatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIsAvailable
            // 
            this.pnlIsAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.pnlIsAvailable.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIsAvailable.Location = new System.Drawing.Point(0, 0);
            this.pnlIsAvailable.Name = "pnlIsAvailable";
            this.pnlIsAvailable.Size = new System.Drawing.Size(5, 119);
            this.pnlIsAvailable.TabIndex = 4;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblItemPrice.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.White;
            this.lblItemPrice.Location = new System.Drawing.Point(98, 89);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(185, 30);
            this.lblItemPrice.TabIndex = 6;
            this.lblItemPrice.Text = "0.00";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lblItemName.Location = new System.Drawing.Point(98, 0);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Padding = new System.Windows.Forms.Padding(2);
            this.lblItemName.Size = new System.Drawing.Size(185, 89);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "Lorem Ipsum";
            // 
            // flatPictureBox1
            // 
            this.flatPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.flatPictureBox1.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.flatPictureBox1.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.flatPictureBox1.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.flatPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatPictureBox1.EllipseOnClick = 0;
            this.flatPictureBox1.EllipseOnDefault = 0;
            this.flatPictureBox1.EllipseOnHover = 0;
            this.flatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("flatPictureBox1.Image")));
            this.flatPictureBox1.Location = new System.Drawing.Point(5, 0);
            this.flatPictureBox1.Name = "flatPictureBox1";
            this.flatPictureBox1.Size = new System.Drawing.Size(93, 119);
            this.flatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flatPictureBox1.TabIndex = 5;
            this.flatPictureBox1.TabStop = false;
            this.flatPictureBox1.ToolTip = "";
            // 
            // PumpCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.flatPictureBox1);
            this.Controls.Add(this.pnlIsAvailable);
            this.Name = "PumpCardView";
            this.Size = new System.Drawing.Size(283, 119);
            ((System.ComponentModel.ISupportInitialize)(this.flatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIsAvailable;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemName;
        private ITA_UI.Classes.Controls.FlatPictureBox flatPictureBox1;
    }
}

using Petrol_Pump_Point_Of_Sale_System.Components;

namespace Petrol_Pump_Point_Of_Sale_System.View.Commons
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.txtUsername = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.txtPassword = new Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox();
            this.btnSumit = new Petrol_Pump_Point_Of_Sale_System.Components.FlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlControlBox.SuspendLayout();
            this.pnlTopMenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(250, 40);
            this.lblTitle.Text = "Login Authentication";
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Location = new System.Drawing.Point(298, 0);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // pnlTitleBorder
            // 
            this.pnlTitleBorder.Size = new System.Drawing.Size(381, 4);
            // 
            // pnlTopMenuContainer
            // 
            this.pnlTopMenuContainer.Size = new System.Drawing.Size(381, 40);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUsername.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUsername.BackColorOnError = System.Drawing.Color.Empty;
            this.txtUsername.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUsername.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtUsername.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUsername.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUsername.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUsername.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUsername.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUsername.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.None;
            this.txtUsername.Location = new System.Drawing.Point(53, 225);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceHolder = "Username";
            this.txtUsername.Required = true;
            this.txtUsername.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtUsername.RequiredForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUsername.RequiredForeColorOnValidate = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtUsername.Size = new System.Drawing.Size(274, 27);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.ValidateOnLeave = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPassword.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPassword.BackColorOnError = System.Drawing.Color.Empty;
            this.txtPassword.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPassword.BackColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderColorOnRequired = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPassword.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtPassword.FontOnLeave = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPassword.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPassword.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPassword.InputValidation = Petrol_Pump_Point_Of_Sale_System.Components.FlatTextBox.Validation.None;
            this.txtPassword.Location = new System.Drawing.Point(53, 274);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceHolder = "Password";
            this.txtPassword.Required = true;
            this.txtPassword.RequiredFontStyle = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.txtPassword.RequiredForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPassword.RequiredForeColorOnValidate = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtPassword.Size = new System.Drawing.Size(274, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.ValidateOnLeave = false;
            // 
            // btnSumit
            // 
            this.btnSumit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnSumit.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnSumit.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnSumit.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnSumit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumit.EllipseOnClick = 2;
            this.btnSumit.EllipseOnDefault = 2;
            this.btnSumit.EllipseOnHover = 2;
            this.btnSumit.FlatAppearance.BorderSize = 0;
            this.btnSumit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnSumit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnSumit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnSumit.ForeColor = System.Drawing.Color.White;
            this.btnSumit.ForeColorOnClick = System.Drawing.Color.White;
            this.btnSumit.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnSumit.ForeColorOnHover = System.Drawing.Color.White;
            this.btnSumit.Location = new System.Drawing.Point(53, 323);
            this.btnSumit.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.btnSumit.Name = "btnSumit";
            this.btnSumit.Size = new System.Drawing.Size(274, 39);
            this.btnSumit.TabIndex = 65;
            this.btnSumit.Text = "Login";
            this.btnSumit.ToolTip = "";
            this.btnSumit.UseVisualStyleBackColor = false;
            this.btnSumit.Click += new System.EventHandler(this.btnSumit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(125, 15, 125, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 499);
            this.ColorAOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ColorBOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ColorCOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ColorToneOnDefault = ITSpecialProject.Commons.Enums.ColorCombination.TriColor;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSumit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.DoubleBuffered = true;
            this.EllipseOnDefault = 2;
            this.GradientAngleOnDefault = 60;
            this.HasClose = true;
            this.HasIcon = true;
            this.HasMaximize = true;
            this.HasMinimize = true;
            this.HasTitleBar = true;
            this.HasTitleBorder = true;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.btnSumit, 0);
            this.Controls.SetChildIndex(this.pnlTitleBorder, 0);
            this.Controls.SetChildIndex(this.pnlTopMenuContainer, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlControlBox.ResumeLayout(false);
            this.pnlTopMenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private FlatTextBox txtUsername;
        private FlatTextBox txtPassword;
        private FlatButton btnSumit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
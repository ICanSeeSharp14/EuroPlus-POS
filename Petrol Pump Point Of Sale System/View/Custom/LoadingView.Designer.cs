namespace Petrol_Pump_Point_Of_Sale_System.View.Custom
{
    partial class LoadingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingView));
            this.imgLoadingList = new System.Windows.Forms.ImageList(this.components);
            this.tmrImageLoader = new System.Windows.Forms.Timer(this.components);
            this.pbLoading = new ITA_UI.Classes.Controls.FlatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLoadingList
            // 
            this.imgLoadingList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLoadingList.ImageStream")));
            this.imgLoadingList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLoadingList.Images.SetKeyName(0, "1.png");
            this.imgLoadingList.Images.SetKeyName(1, "2.png");
            this.imgLoadingList.Images.SetKeyName(2, "3.png");
            this.imgLoadingList.Images.SetKeyName(3, "4.png");
            this.imgLoadingList.Images.SetKeyName(4, "5.png");
            this.imgLoadingList.Images.SetKeyName(5, "6.png");
            this.imgLoadingList.Images.SetKeyName(6, "7.png");
            this.imgLoadingList.Images.SetKeyName(7, "8.png");
            // 
            // tmrImageLoader
            // 
            this.tmrImageLoader.Enabled = true;
            this.tmrImageLoader.Interval = 200;
            this.tmrImageLoader.Tick += new System.EventHandler(this.tmrImageLoader_Tick);
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pbLoading.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pbLoading.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pbLoading.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pbLoading.EllipseOnClick = 0;
            this.pbLoading.EllipseOnDefault = 0;
            this.pbLoading.EllipseOnHover = 0;
            this.pbLoading.Location = new System.Drawing.Point(335, 209);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(53, 55);
            this.pbLoading.TabIndex = 0;
            this.pbLoading.TabStop = false;
            this.pbLoading.ToolTip = "";
            // 
            // LoadingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pbLoading);
            this.Name = "LoadingView";
            this.Size = new System.Drawing.Size(768, 529);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ITA_UI.Classes.Controls.FlatPictureBox pbLoading;
        private System.Windows.Forms.ImageList imgLoadingList;
        private System.Windows.Forms.Timer tmrImageLoader;
    }
}

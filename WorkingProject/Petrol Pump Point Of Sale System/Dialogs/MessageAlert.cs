using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ITA_UI;
using ITA_UI.Classes.Controls;
using ITA_UI.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using FlatButton = Petrol_Pump_Point_Of_Sale_System.Components.FlatButton;


namespace Petrol_Pump_Point_Of_Sale_System.Dialogs
{
    public partial class MessageAlert : Form
    {
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;
        private readonly int _screenX = Screen.PrimaryScreen.Bounds.Width;
        private readonly int _screenY = Screen.PrimaryScreen.Bounds.Height;
        private int _interval;
        public MessageAlert()
        {
            InitializeComponent();
        }

        private  MessageAlert(string message, string messageTitle, AlertType alertType)
        {
            Initialize(message);

            SetMessageAlert(alertType, messageTitle);
        }


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Initialize(string message)
        {
            InitializeComponent();

            TopMost = true;
            Left = _screenX - Width - 50;
            Top = -1 * _screenY;

            lblMessage.Text = message;

            AllMouseMove(Controls);
        }

        private void AllMouseMove(Control.ControlCollection coll)
        {
            foreach (Control c in coll)
            {
                if (!(c is FlatButton))
                    c.MouseMove += (sender, e) =>
                    {
                        if (e.Button != MouseButtons.Left) return;

                        ReleaseCapture();

                        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
                    };

                AllMouseMove(c.Controls);
            }
        }

        private void SetMessageAlert(AlertType alertType, string messageTitle)
        {

            switch (alertType)
            {
                case AlertType.Info:
                    BackColor = ColorHelper.FlatBlueNormal;
                    pbIcon.Image = imgResources.Images["Info_48.png"];
                    break;
                case AlertType.BadInfo:
                    BackColor = ColorHelper.FlatRedNormal;
                    pbIcon.Image = imgResources.Images["Info_48.png"];
                    break;
                case AlertType.Update:
                    BackColor = ColorHelper.FlatGreenNormal;
                    pbIcon.Image = imgResources.Images["Update_48.png"];
                    break;
                case AlertType.Delete:
                    BackColor = ColorHelper.FlatRedNormal;
                    pbIcon.Image = imgResources.Images["Delete_48.png"];
                    break;
                case AlertType.Notification:
                    BackColor = ColorHelper.FlatGreenNormal;
                    pbIcon.Image = imgResources.Images["Notification_48.png"];
                    break;
                case AlertType.Message:
                    BackColor = ColorHelper.FlatGreenNormal;
                    pbIcon.Image = imgResources.Images["Message_48.png"];
                    break;
                case AlertType.Hand:
                    BackColor = ColorHelper.FlatYellowNormal;
                    pbIcon.Image = imgResources.Images["Hand_48.png"];
                    break;
                case AlertType.Warning:
                    BackColor = ColorHelper.FlatYellowNormal;
                    pbIcon.Image = imgResources.Images["Warning_48.png"];
                    break;
                case AlertType.Error:
                    BackColor = ColorHelper.FlatRedNormal;
                    pbIcon.Image = imgResources.Images["Error_48.png"];
                    break;
            }

            SetMessageTitle(alertType, messageTitle);
            BeginShowing();
        }

        private void BeginShowing()
        {
            tmrShow.Enabled = true;
            tmrShow.Start();
        }

        private void SetMessageTitle(AlertType alertType, string messageTitle)
        {
            lblTitle.Text = string.IsNullOrEmpty(messageTitle) ? alertType.ToString() : messageTitle;
        }




        public static void Show(string message, string messageTitle = "Info", AlertType alertType = AlertType.Info)
        {
            new MessageAlert(message, messageTitle, alertType).Show();
        }

        private void MessageAlert_Load(object sender, EventArgs e)
        {
                
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (Top < 50)
            {
                Top = _interval;
                _interval += 2;
            }
            else
            {
                tmrShow.Stop();

                tmrDelay.Enabled = true;
                tmrDelay.Start();
            }
        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            tmrDelay.Stop();
            tmrClose.Enabled = true;
            tmrClose.Start();
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(Opacity) > 0.00)
                Opacity -= 0.05;
            else
                Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

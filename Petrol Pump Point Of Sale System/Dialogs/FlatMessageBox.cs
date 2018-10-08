using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITA_UI.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Classes.Helpers;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Components;

namespace Petrol_Pump_Point_Of_Sale_System.Dialogs
{
    public partial class FlatMessageBox : Form
    {
        public FlatMessageBox()
        {
            InitializeComponent();
        }

        public static DialogButton Show(string message,
            string messageTitle = "Info",
            DialogButtons dialogButtons = DialogButtons.Ok,
            DialogType dialogType = DialogType.Info)
        {
            using (var msg = new FlatMessageBox(message, messageTitle, dialogButtons, dialogType))
            {
                msg.ShowDialog();

                return msg.SelectedDialogButton;
            }
        }

        #region Initialization

        public DialogButtons DialogButtons;

        public DialogButton SelectedDialogButton { get; set; }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FlatMessageBox(string message, string messageTitle, DialogButtons dialogButtonses, DialogType dialogType)
        {
            InitializeComponent();

            //lblMessage.Text = message;
            //lblTitle.Text = messageTitle;

            SelectedButton(dialogButtonses);

            SetBackGroundColor(dialogType);

            DialogButtons = dialogButtonses;

            AllMouseMove(Controls);
        }

        private void AllMouseMove(Control.ControlCollection coll)
        {
            foreach (Control c in coll)
                if (!(c is FlatButton))
                {
                    c.MouseMove += (sender, e) =>
                    {
                        if (e.Button != MouseButtons.Left) return;

                        ReleaseCapture();
                        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
                    };

                    AllMouseMove(c.Controls);
                }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    switch (DialogButtons)
                    {
                        case DialogButtons.Ok:
                        case DialogButtons.OkCancel:
                            SelectedDialogButton = DialogButton.Ok;
                            break;
                        case DialogButtons.YesNo:
                        case DialogButtons.YesNoCancel:
                            SelectedDialogButton = DialogButton.Yes;
                            break;
                        case DialogButtons.ApplyCancel:
                            SelectedDialogButton = DialogButton.Apply;
                            break;
                        case DialogButtons.SaveCancel:
                            SelectedDialogButton = DialogButton.Save;
                            break;
                    }

                    Close();
                    break;
                case Keys.Escape:
                    SelectedDialogButton = DialogButton.Cancel;
                    Close();
                    break;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SelectedButton(DialogButtons db)
        {
            switch (db)
            {
                case DialogButtons.Ok:
                    SetButtonVisibility(true, false, false, false, false, false);
                    break;
                case DialogButtons.OkCancel:
                    SetButtonVisibility(true, false, false, false, false, true);
                    break;
                case DialogButtons.YesNoCancel:
                    SetButtonVisibility(false, true, true, false, false, true);
                    break;
                case DialogButtons.YesNo:
                    SetButtonVisibility(false, true, true, false, false, false);
                    break;
                case DialogButtons.ApplyCancel:
                    SetButtonVisibility(false, false, false, true, false, true);
                    break;
                case DialogButtons.SaveCancel:
                    SetButtonVisibility(false, false, false, false, true, true);
                    break;
            }
        }

        private void SetButtonVisibility(bool ok, bool yes, bool no, bool apply, bool save, bool cancel)
        {
            //btnOk.Visible = ok;
            //btnYes.Visible = yes;
            //btnNo.Visible = no;
            //btnApply.Visible = apply;
            //btnSave.Visible = save;
            //btnCancel.Visible = cancel;
        }

        private void SetBackGroundColor(DialogType dialogType)
        {
            switch (dialogType)
            {
                case DialogType.Info:
                    BackColor = ColorHelper.FlatBlueNormal;
                    break;
                case DialogType.Question:
                    BackColor = ColorHelper.FlatBlueNormal;
                    break;
                case DialogType.Hand:
                    BackColor = ColorHelper.FlatYellowNormal;
                    break;
                case DialogType.Warning:
                    BackColor = ColorHelper.FlatYellowNormal;
                    break;
                case DialogType.Error:
                    BackColor = ColorHelper.FlatBlueNormal;
                    break;
            }
        }

        #endregion
    }
}

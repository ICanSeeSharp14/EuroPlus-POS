using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Classes.Helpers;
using Tulpep.NotificationWindow;

namespace Petrol_Pump_Point_Of_Sale_System.View.Custom
{
    public class Notification
    {
        public enum AlertColor : byte
        {
            Blue = 1, Green = 2, Yellow = 3, Red = 4
        }

        public static void Show(string message, string title = "Info", AlertColor alertColor = AlertColor.Blue)
        {
            var popup = new PopupNotifier
            {
                TitleText = title,
                ContentText = message,
                TitleColor = Color.White,
                ContentColor = Color.White,
                TitleFont = new Font("Segoe UI Semibold", 11.25f, FontStyle.Regular),
                ContentFont = new Font("Segoe UI Semibold", 10.75f, FontStyle.Regular),

            };

            switch (alertColor)
            {
                case AlertColor.Blue:
                    popup.HeaderColor = ColorHelper.FlatBlueNormal;
                    popup.BodyColor = ColorHelper.FlatBlackLight;
                    break;
                case AlertColor.Green:
                    popup.HeaderColor = Color.FromArgb(15, 110, 60);
                    popup.BodyColor = Color.FromArgb(45, 140, 90);
                    break;
                case AlertColor.Yellow:
                    popup.HeaderColor = Color.FromArgb(190, 135, 0);
                    popup.BodyColor = Color.FromArgb(220, 165, 30);
                    break;
                case AlertColor.Red:
                    popup.HeaderColor = Color.FromArgb(190, 30, 30);
                    popup.BodyColor = Color.FromArgb(200, 60, 60);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(alertColor), alertColor, null);
            }

            popup.Popup();
        
           
        }
    }
}

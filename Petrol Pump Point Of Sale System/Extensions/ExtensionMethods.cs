using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.Extensions
{
    public static class ExtensionMethods
    {
        public static UserControl Instance(this UserControl userControl)
        {
            return userControl;
        }
    }
}

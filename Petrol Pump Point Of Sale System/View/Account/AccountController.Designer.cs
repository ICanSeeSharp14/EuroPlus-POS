using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Core;

namespace Petrol_Pump_Point_Of_Sale_System.View.Account
{
    public partial class AccountView : IModule
    {
        public UserControl Instance()
        {
            return new AccountView();
        }
    }
}

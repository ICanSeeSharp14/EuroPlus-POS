using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Monostates
{
    public static class AccountSession
    {
        public static void SetAccount(User account)
        {
            GetAccount = account;
        }

        public static User GetAccount { get; private set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Pump_Point_Of_Sale_System.Commons.Helper
{
    class StatusHelper
    {

        public static IEnumerable<Status> GetStatus()
        {
            var flag = new List<Status>()
            {
                new Status {IsActive = true, Text = "Active"},
                new Status {IsActive = false, Text = "Inactive"}
            };

            return flag;
        }

        public class Status
        {
            public bool IsActive { get; set; }
            public string Text { get; set; }
        }
    }
}

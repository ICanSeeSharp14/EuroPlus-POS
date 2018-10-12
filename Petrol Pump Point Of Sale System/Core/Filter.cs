using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Pump_Point_Of_Sale_System.Core
{
    public class Filter
    {
        public string SearchKey { get; set; }
        public bool IsActive { get; set; }

        public int Take { get; set; }
        public int Skip { get; set; }
    }
}

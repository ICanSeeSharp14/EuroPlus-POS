using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public partial class DatabaseContext
    {
        public DatabaseContext(string connectionString)
            : base(string.Format("provider connection string='{0}'"
                , connectionString))
        {
        }
    }
}

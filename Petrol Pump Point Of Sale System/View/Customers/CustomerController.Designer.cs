using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petrol_Pump_Point_Of_Sale_System.Entities;
using Petrol_Pump_Point_Of_Sale_System.Models;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;

namespace Petrol_Pump_Point_Of_Sale_System.View.Customers
{
    public partial class CustomerView
    {
        private dynamic GetCustomers()
        {
            using (var db = new DbRepository(new DatabaseContext()))
            {
                return db.Customers.GetAll("", paginator.GetCurrentPage, paginator.GetRecordsPerPage);
            }
        }

        public dynamic DisplayCustomers()
        {
            return dgvCustomerList.DataSource = GetCustomers();   
        }
    }
}

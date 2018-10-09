using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.View.Account
{
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            if (Created)
            {
                using (var db = new DatabaseContext())
                {
                    dgvAccounts.DataSource = db.Products.OrderBy(p => p.ProductId).Skip(0).Take(50).ToList();
                }
            }
        }
    }
}

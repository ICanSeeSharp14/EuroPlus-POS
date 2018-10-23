using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Components;

namespace Petrol_Pump_Point_Of_Sale_System.View.Product
{
    public partial class CreateProductView : FlatForm
    {
        public CreateProductView()
        {
            InitializeComponent();
            txtProductName.Focus();

        }

        private void CreateProductView_Load(object sender, EventArgs e)
        {
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {

        }
    }
}

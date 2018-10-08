using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.View.Main
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
             Initialize();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POS();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            tcMenu.SelectTab(0);
         
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Manage();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            //SetSelectedButtonProperties(btnAccount);
        }
    }
}

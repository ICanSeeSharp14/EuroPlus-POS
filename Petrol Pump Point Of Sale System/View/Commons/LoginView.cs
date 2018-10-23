using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Components;

namespace Petrol_Pump_Point_Of_Sale_System.View.Commons
{
    public partial class LoginView : FlatForm
    {
        public LoginView()
        {
            LoadSplashScreen();
            InitializeComponent();
        }

        private void btnSumit_Click(object sender, System.EventArgs e)
        {
            Login();

        }
    }
}

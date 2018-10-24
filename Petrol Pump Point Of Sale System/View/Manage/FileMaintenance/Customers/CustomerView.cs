using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Customers
{
    public partial class CustomerView : UserControl
    {
        public CustomerView()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnDetails_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, System.EventArgs e)
        {
            SaveChanges();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            CancelChanges();

        }
    }
}

using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.View.Manage.FileMaintenance.Supplier
{
    public partial class SupplierView : UserControl
    {
        public SupplierView()
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

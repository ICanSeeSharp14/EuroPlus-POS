using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Models;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;

namespace Petrol_Pump_Point_Of_Sale_System.View.Products
{
    public partial class ProductView : UserControl 
    {
        private readonly DbRepository _repository = new DbRepository(new DatabaseContext());

        public ProductView() 
        {
            InitializeComponent();

            pgProduct.SetRecordsPerPage(2);
            //SetTotalPage();

            InitializeEvents();

            //Initialize();
        }
        private void ProductView_Load(object sender, System.EventArgs e)
        {
            //GetProducts();
            
            
                    var products = _repository.Products
                        .GetAll(txtSearch.Text,
                            pgProduct.GetSkipPage,
                            pgProduct.GetRecordsPerPage);
                    dgvProductList.DataSource = products;
            
            
    }

        private void btnRateHistory_Click(object sender, System.EventArgs e)
        {
            MessageAlert.Show("You cannot deactivate your own account.", "Error", AlertType.Error);
       
        }
    }
}

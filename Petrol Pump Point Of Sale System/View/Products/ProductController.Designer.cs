using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Core;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;
using Petrol_Pump_Point_Of_Sale_System.Models;

namespace Petrol_Pump_Point_Of_Sale_System.View.Products
{
    public partial class ProductView 
    {
        
        public void Initialize()
        {
            
            GetProducts();  
        }

        private bool DisplayControlsOnCreated()
        {
           if (Created)
            {
                foreach (var control in this.Controls.Cast<Control>())
                {
                    control.Visible = true;
                }

                return true;
            }

            return false;

        }

        private void InitializeEvents()
        {
         
            pgProduct.PageNavigationButtonClicked += (s, e) =>
            {
                GetProducts();
            };
            pgProduct.RefreshButtonClicked += (s, e) =>
            {
           
                GetProducts();

            };

            pgProduct.RecordCountChanged += (s, e) =>
            {
               SetTotalPage();
               GetProducts();
            };

            
        }

        private void GetProducts()
        {
            SetTotalPage();
            using (var db = new DbRepository(new DatabaseContext()))
            {
                var products =  db.Products
                                    .GetAll(txtSearch.Text,
                                            pgProduct.GetSkipPage,
                                            pgProduct.GetRecordsPerPage);
                dgvProductList.DataSource = products;

            }
        }


        public UserControl Instance()
        {
            return new ProductView();
        }


        private void SetTotalPage()
        {
            pgProduct.SetMaxPage(new DatabaseContext().Products.Count());

        }
    }
}

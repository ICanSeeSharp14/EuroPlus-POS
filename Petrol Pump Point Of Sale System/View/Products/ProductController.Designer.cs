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
        
        private void Initialize()
        {
            DisplayProducts();  
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
                DisplayProducts();
            };
            pgProduct.RefreshButtonClicked += (s, e) =>
            {

                DisplayProducts();

            };

            pgProduct.RecordCountChanged += (s, e) =>
            {
               SetTotalPage();
               DisplayProducts();
            };

            
        }

        public dynamic GetProducts()
        {
           
            using (var db = new DbRepository(new DatabaseContext()))
            {
                var products =  db.Products
                                    .GetAll(txtSearch.Text,
                                            pgProduct.GetSkipPage,
                                            pgProduct.GetRecordsPerPage);
                return products;
               

            }
        }

        public dynamic DisplayProducts()
        {
           return  dgvProductList.DataSource = GetProducts();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Properties;

namespace Petrol_Pump_Point_Of_Sale_System.View.Custom
{
    public partial class LoadingView : UserControl
    {
        private int _loaderImageIndex = 0;

       
        public LoadingView()
        {
            InitializeComponent();
            pbLoading.Image = Resources._1;
        }

        private void tmrImageLoader_Tick(object sender, EventArgs e)
        {
            _loaderImageIndex += 1;
            pbLoading.Image = imgLoadingList.Images[_loaderImageIndex];
            if (_loaderImageIndex == 7)
            {
                _loaderImageIndex = 0;
            }
        }
    }
}

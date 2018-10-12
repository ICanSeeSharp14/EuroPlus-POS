using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.View.Custom
{
    public partial class PreloaderView : UserControl
    {
        private int _counter;

        public PreloaderView()
        {
            InitializeComponent();

            tmrPreloader.Enabled = true;
        }

        private async void tmrPreloader_Tick(object sender, EventArgs e)
        {
            await Task.Run(() => { BeginAnimation(++_counter); });

            if (_counter == Controls.Count)
                _counter = -1;
        }

        private void BeginAnimation(int bulletIndex)
        {
            pbPreloader1.Image = bulletIndex == 1 ? imgPreloader.Images[0] : imgPreloader.Images[1];
            pbPreloader2.Image = bulletIndex == 2 ? imgPreloader.Images[0] : imgPreloader.Images[1];
            pbPreloader3.Image = bulletIndex == 3 ? imgPreloader.Images[0] : imgPreloader.Images[1];

            
        }
      
    }
}

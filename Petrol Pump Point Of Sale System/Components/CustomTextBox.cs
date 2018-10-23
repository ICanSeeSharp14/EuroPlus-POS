using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.Components
{
    public class CustomTextBox : TextBox
    {
        
        private string _placeHolder;

        public CustomTextBox()
        {
            Text = PlaceHolder;
        }
        

        [Category("Custom")]
        public string PlaceHolder
        {
            get
            {
               return _placeHolder;
            }
            set { _placeHolder = value; }
        }

        protected  override  void OnEnter(EventArgs e)
        {
            Text = "";
        }

        protected override void OnLeave(EventArgs e)
        {
            PropertiesOnLeave();

        }

        private void PropertiesOnLeave()
        {
            if (Text == "")
            {
                Text = PlaceHolder;
            }
        }
    }
}

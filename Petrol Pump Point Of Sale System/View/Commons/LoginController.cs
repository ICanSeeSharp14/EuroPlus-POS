using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Pump_Point_Of_Sale_System.View.Commons
{
    public partial class LoginController : Component
    {
        public LoginController()
        {
            InitializeComponent();
        }

        public LoginController(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

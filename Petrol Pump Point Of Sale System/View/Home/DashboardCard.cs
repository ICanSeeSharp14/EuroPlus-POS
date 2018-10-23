using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.View.Home
{
    public partial class DashboardCard : UserControl
    {
        public DashboardCard()
        {
            InitializeComponent();
        }

        [Category("Custom")]
        public Image CardIcon
        {
            get { return pbIcon.Image; }
            set { pbIcon.Image = value; }
        }

        [Category("Custom")]
        public string CardText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("Custom")]
        public string CardValue
        {
            get { return lblValue.Text; }
            set { lblValue.Text = value; }
        }

        [Category("Custom")]
        public string NavigationText
        {
            get { return lnkNavigate.Text; }
            set { lnkNavigate.Text = value; }
        }

        public Color NavigationBackColor
        {
            get { return lnkNavigate.BackColor; }
            set { lnkNavigate.BackColor = value; }
        }

        [Category("Custom")]
        public event EventHandler NavigateClick
        {
            add { lnkNavigate.Click += value; }
            remove { lnkNavigate.Click -= value; }
        }

    }
}

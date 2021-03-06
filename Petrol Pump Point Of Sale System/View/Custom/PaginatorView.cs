﻿using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.View.Custom
{
    public partial class PaginatorView : UserControl
    {
        public PaginatorView()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnNextPage_Click(object sender, System.EventArgs e)
        {
            GoToNextPage();
        }

        private void btnLastPage_Click(object sender, System.EventArgs e)
        {
            GoToLastPage();
        }

        private void btnPreviousPage_Click(object sender, System.EventArgs e)
        {
            GoToPreviousPage();
        }

        private void btnFirstPage_Click(object sender, System.EventArgs e)
        {
            GoToFirstPage();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Pump_Point_Of_Sale_System.View.Custom
{
     public partial class PaginatorView
     {
        private int _maxPage = 1;
         private int _currentPage = 1;

         private void Initialize()
        {
            cbRecords.SelectedIndex = 0;
        }

        private void GoToFirstPage()
        {
            SetCurrentPage(GetCurrentPage = 1);
        }

        private void GoToNextPage()
        {
            if (GetCurrentPage == _maxPage) return;

            SetCurrentPage(++GetCurrentPage);
        }

        private void GoToPreviousPage()
        {
            if (GetCurrentPage == 1) return;

            SetCurrentPage(--GetCurrentPage);
        }

        private void GoToLastPage()
        {
            SetCurrentPage(GetCurrentPage = _maxPage);
        }

        public void ResetPage()
        {
            GetCurrentPage = 1;
            lblCurrentPage.Text = GetCurrentPage.ToString();
        }

        private void SetCurrentPage(int currentPage)
         {
             lblCurrentPage.Text = currentPage.ToString();
         }

         public void SetMaxPage(int recordCount)
        {
            _maxPage = ((recordCount / GetRecordsPerPage));

            if (recordCount % GetRecordsPerPage != 0 || _maxPage == 0) _maxPage++;

            lblLastPage.Text = _maxPage.ToString();
        }

         //public int GetCurrentPage
         //{
            
         //    get { return _currentPage; }
         //    set { _currentPage = Convert.ToInt32(lblCurrentPage.Text ); }
         //}

         public int GetCurrentPage
         {
             get { return _currentPage; }
             set { _currentPage = value; }
         }


         public int GetRecordsPerPage
         {
             get
             {
                 int count;
                 return int.TryParse(cbRecords.Text, result: out count) ? count : 0;
             }
         }

         public int SetRecordsPerPage(int index)
         {
             return cbRecords.SelectedIndex = index;
         }

         public int GetSkipPage
         {
             get { return (GetCurrentPage - 1) * GetRecordsPerPage; }
         }


         [Category("Custom")]
        public bool HasRecordCount
         {
             get { return pnlPaginatorL.Visible; }
             set { pnlPaginatorL.Visible = value; }
         }

         [Category("Custom")]
        public bool HasRefresh
         {
             get { return pnlPaginatorR.Visible; }
             set { pnlPaginatorR.Visible = value; }
         }

         public event EventHandler RecordCountChanged
         {
             add { cbRecords.SelectedIndexChanged += value; }
             remove { cbRecords.SelectedIndexChanged += value; }
         }

         public event EventHandler PageNavigationButtonClicked
        {
            add
            {
                btnFirstPage.Click += value;
                btnPreviousPage.Click += value;
                btnNextPage.Click += value;
                btnLastPage.Click += value;
            }
            remove
            {
                btnFirstPage.Click -= value;
                btnPreviousPage.Click -= value;
                btnNextPage.Click -= value;
                btnLastPage.Click -= value;
            }
        }

        public event EventHandler RefreshButtonClicked
        {
            add { btnRefresh.Click += value; }
            remove { btnRefresh.Click -= value; }
        }
     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSpecialProject.Components;

namespace Petrol_Pump_Point_Of_Sale_System.Commons.Helper
{
    public class ControlHelper
    {
        public static int GetRowIndex(FlatTable dgv)
        {
            return dgv.CurrentRow?.Index ?? 0;
        }
        public static dynamic GetDataGridViewKey(FlatTable dgv, dynamic column)
        {
            return dgv.Rows[GetRowIndex(dgv)].Cells[column].Value.ToString();
        }
    }
}

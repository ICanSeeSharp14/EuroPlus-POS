using System.Windows.Forms;

namespace Petrol_Pump_Point_Of_Sale_System.Core.Repositories
{
    public interface IGenericMethod
    {
        void NumbersOnly(KeyPressEventArgs e);
        void NumbersAndLettersOnly(KeyPressEventArgs e);
        void NumbersWithDecimal(KeyPressEventArgs e);
        void LettersOnly(KeyPressEventArgs e);

        //int GetPrimaryKey(MetroGrid metroGrid ,int columnIndex,int rowIndex);

        //string GetPrimaryKey(MetroGrid metroGrid, string columnName, int rowIndex);
        //string GetPrimaryKey(MetroGrid metroGrid, string columnName, int rowIndex);

    }

}

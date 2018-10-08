using Petrol_Pump_Point_Of_Sale_System.View;
using Petrol_Pump_Point_Of_Sale_System.View.Commons;

namespace Petrol_Pump_Point_Of_Sale_System.Controllers
{
    public class LoginController : Controller
    {
        private readonly IView _view;

        //public override IView View
        //{
        //    //get { return _view ?? new LoginView(); }
        //}

        public override IView View
        {
            get { throw new System.NotImplementedException(); }
        }

        public override bool Loadable()
        {
            return true;
        }

        public LoginController(IView view)
        {
            _view = view;
        }

        private void ExitApplication()
        {
           View.Form.Close();
        }
    }
}

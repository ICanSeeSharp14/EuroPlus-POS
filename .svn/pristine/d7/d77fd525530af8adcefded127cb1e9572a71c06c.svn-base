using System;
using System.Threading;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Controllers;
using Petrol_Pump_Point_Of_Sale_System.View;

namespace Petrol_Pump_Point_Of_Sale_System
{
    public class AppManager
    {
        private static bool _started;

        private static AppManager _instance;

        public static AppManager Instance
        {
            get
            {
                if (!_started)
                    throw new Exception("Tried to call the singleton instance of the AppManager before the AppManager started.");

                return _instance;
            }
        }

        /// <summary>
        /// The current WinForms-Form instance
        /// </summary>
        private IView _currentView;

        /// <summary>
        /// Private constructor to prevent instantiation
        /// </summary>
        private AppManager() { }

        /// <summary>
        /// Starts the AppManager and creates a singleton for this class
        /// </summary>
        public static void Start<T>()
            where T : Controller
        {
            if (_started) return;

            _started = true;

            T controller = Activator.CreateInstance<T>();

            _instance = new AppManager()
            {
                _currentView = controller.View
            };

            _instance.OpenForm();
        }

        /// <summary>
        /// Loads a Controller, handles the loading state
        /// </summary>
        /// <typeparam name="T">Generic Type where T extends Controller</typeparam>
        public void Load<T>()
            where T : Controller
        {
            T controller = Activator.CreateInstance<T>();

            if (controller.Loadable())
            {
                controller.OnLoadSuccess(EventArgs.Empty);
            }
            else
            {
                controller.OnLoadFailure(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Shows the View of the Controller parameter  
        /// </summary>
        /// <param name="controller">The controller instance</param>
        public void Show(Controller controller)
        {
            if (_currentView != null)
            {
                _currentView.Close();
                _currentView.Form.Dispose();
            }

            _currentView = controller.View;

            var th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        /// <summary>
        /// Used as single-threaded appartment thread-callback to keep the main thread running
        /// </summary>
        private void OpenForm()
        {
            Application.Run(_currentView.Form);
        }
    }
}

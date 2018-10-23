using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Dialogs;
using Petrol_Pump_Point_Of_Sale_System.Models;
using Petrol_Pump_Point_Of_Sale_System.Monostates;
using Petrol_Pump_Point_Of_Sale_System.Persistence.Repositories;
using Petrol_Pump_Point_Of_Sale_System.View.Main;

namespace Petrol_Pump_Point_Of_Sale_System.View.Commons
{
    public partial class LoginView
    {
        private void LoadSplashScreen()
        {
            var isDone = false;

            ThreadPool.QueueUserWorkItem((x) =>
            {
                using (var splash = new SplashScreenView())
                {
                    splash.Show();

                    while (!isDone)
                    {
                        Application.DoEvents();
                    }

                    splash.Close();
                }
            });

            Thread.Sleep(5000);

            isDone = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter) Login();

            //if (keyData == (Keys.Alt | Keys.Q)) QrLogin();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Login()
        {
            using (var repository = new DbRepository(new DatabaseContext()))
            {
                var exist = repository.Users.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (!exist)
                {
                    ShowErrorMessage();
                    return;
                }
                ShowMain(new User());
            }
        }

        private void ShowErrorMessage()
        {
            MessageAlert.Show("Invalid Credentials", "Error", alertType: AlertType.BadInfo);

        }

        private void ShowMain(User account)
        {
            AccountSession.SetAccount(account);
            var main = new MainView();
            main.FormClosed += (s, e) => { this.Show(); };
            main.Show();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}

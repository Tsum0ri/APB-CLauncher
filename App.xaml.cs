using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace CLauncher2._0
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            this.CloseSplashIfOpen();
            this.StartMainFormWhenError();
            MessageBox.Show("Error" + Environment.NewLine + e.Exception.Message, "Error");
            e.Handled = true;
        }


        private async void StartMainFormWhenError()
        {
            await Task.Delay(2000);
            Window.test MainWindow = new Window.test();
            MainWindow.Show();
            MainWindow = (Window.test)null;
        }

        private void CloseSplashIfOpen()
        {
            SplashScreen splash = new SplashScreen();
            splash.Hide();
        }

    }
}

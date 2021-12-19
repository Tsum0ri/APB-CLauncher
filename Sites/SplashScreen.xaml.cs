using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace CLauncher2._0
{
    /// <summary>
    /// Interaktionslogik für SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {

        string Version = "0.952";




        public SplashScreen()
        {
            InitializeComponent();
            this.splashscreen_status.Content = "checking for updates...";
            string oldPath = (Environment.CurrentDirectory) + @"\APB CLauncher_old.exe"; //!!!!!!!
            File.Delete(oldPath);

        }

        private System.Windows.Forms.Timer holder;
        private readonly System.Windows.Forms.Label say;

        public string getVersion() => this.Version;
        public void checkForUpdate()
        {
            string str = new StreamReader(WebRequest.Create("https://elygate.com/APB-CLauncher/" + "version.txt").GetResponse().GetResponseStream()).ReadLine();
            if (this.getVersion() != str)
            {
                this.splashscreen_status.Content = "Update found!";
                this.StartPatchForm();
            }
            else
            {
                this.splashscreen_status.Content = "Launcher is on latest version...";
                this.StartMainForm();
            }
        }

        private async void StartMainForm()
        {
            await Task.Delay(2000);
            this.Hide();
            Sites.test MainWindow = new Sites.test();
            MainWindow.Closed += (EventHandler)((s, args) => this.Close());
            MainWindow.Show();
            MainWindow = (Sites.test)null;
        }


        private async void StartPatchForm()
        {
            await Task.Delay(3000);
            this.Hide();
            frmPatcher PatchForm = new frmPatcher();
            PatchForm.Closed += (EventHandler)((s, args) => this.Close());
            PatchForm.Show();
            PatchForm = (frmPatcher)null;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(3000);
            if (UserSettings.Default.AutoUpdate == true)
            {
                this.checkForUpdate();
            }
            else
            {
                this.splashscreen_status.Content = "Auto Update deactivated...";
                this.StartMainForm();
            }
        }
    }
}
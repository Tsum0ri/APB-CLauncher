using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CLauncher2._0.Window;

namespace CLauncher2._0
{
    /// <summary>
    /// Interaktionslogik für SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : System.Windows.Window
    {

        string Version = "vb1.70";




        public SplashScreen()
        {
            InitializeComponent();
            checkIfLauncherIsInDirectory();
            this.splashscreen_status.Content = "checking for updates...";
            string oldPath = (Environment.CurrentDirectory) + @"\APB CLauncher_old.exe"; //!!!!!!!
            File.Delete(oldPath);
        }

        private System.Windows.Forms.Timer holder;
        private readonly System.Windows.Forms.Label say;

        public string getVersion() => this.Version;
        public void checkForUpdate()
        {
            string str = new StreamReader(WebRequest.Create("https://beta.clauncher.download/" + "version.txt").GetResponse().GetResponseStream()).ReadLine();
            if (this.getVersion() != str)
            {
                this.splashscreen_status.Content = "Update found! Would you like to update?";
                this.Yes.Visibility = Visibility.Visible;
                this.No.Visibility = Visibility.Visible;
            }
            else
            {
                this.splashscreen_status.Content = "Launcher is on latest version...";
                this.StartMainForm();
            }

        }

        public void checkIfLauncherIsInDirectory()
        {
                String path = Environment.CurrentDirectory;
                String target = "\\Binaries\\APB.exe";

                if (File.Exists(path + target))
                {

                }
                else
                {
                this.Hide();
                Windows.Fatal_Error FatalError = new Windows.Fatal_Error();
                FatalError.Show();
                FatalError.ErrorCode.Content = "<Error:FatalError Informations=" + '\u0022' + "Launcher is not located in the APB directory" + '\u0022' + ">";
            }

        }


        private async void StartMainForm()
        {
            await Task.Delay(2000);
            this.Hide();
            Window.test MainWindow = new Window.test();
            MainWindow.Closed += (EventHandler)((s, args) => this.Close());
            MainWindow.Show();
            MainWindow = (Window.test)null;
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

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            this.StartPatchForm();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            this.StartMainForm();
        }
    }
}
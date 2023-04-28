using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.IO;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace CLauncher2._0.Window
{
    public partial class test : System.Windows.Window
    {

        string Version = "vb1.70";


        public test()
        {

            InitializeComponent();
            Site_Content.Content = new Site_Home();
            this.checkForUpdate();
            string[] bgs = new string[] { "/Resources/Backgrounds/BG_1_2.png", "/Resources/Backgrounds/BG_2.png", "/Resources/Backgrounds/BG_3.png", "/Resources/Backgrounds/BG_4.png", "/Resources/Backgrounds/BG_5.png", "/Resources/Backgrounds/BG_6.png", "/Resources/Backgrounds/BG_7.png", "/Resources/Backgrounds/BG_8.png", "/Resources/Backgrounds/BG_9.png", "/Resources/Backgrounds/BG_10.png", "/Resources/Backgrounds/BG_11.png" };
            string selectedbg = bgs[0];
            Random rng = new Random();
            int index = rng.Next(bgs.Length);
            this.LauncherBG.Source = new BitmapImage(new Uri(bgs[index], UriKind.Relative));

            try 
            {
            LoadBackgroundImage(); // Should Ignore the DynamicBG feature
            }
            catch (Exception ex) 
            {
                Windows.Fatal_Error FatalError = new Windows.Fatal_Error();
                FatalError.Show();
                FatalError.ErrorCode.Content = "<Error:Error Informations=" + '\u0022' + "Unable to load background" + '\u0022' + ">";
            }

            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public string getVersion() => this.Version;
        public void checkForUpdate()
        {
            string str = new StreamReader(WebRequest.Create("https://beta.clauncher.download/" + "version.txt").GetResponse().GetResponseStream()).ReadLine();
            if (getVersion() != str)
            {
                this.updateStatus.Content = "Update found!";
            }
            else
            {
                this.updateStatus.Content = "Launcher is on latest version";
            }
        }

        private void MainGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private void Exit_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Launcher_Settings_Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Sites.Site_LauncherSettings();
        }

        private void Info_Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Site_Info();
        }

        private void Home_Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Site_Home();
        }

        private void Settings_Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Settings.site_main_settings();
        }

        private void Configs_Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Configs.site_main_configs();
        }

        private void Exit_Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void discord_btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Window.site_discord();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Sites.News();
        }

        // Load background image on program startup
        private void LoadBackgroundImage()
        {
            // Check if a last selected file was saved
            if (!string.IsNullOrEmpty(UserSettings.Default.LastSelectedImagePath))
            {
                var bitmap = new BitmapImage(new Uri(UserSettings.Default.LastSelectedImagePath));
                LauncherBG.Source = bitmap;
            }
        }
    }
}

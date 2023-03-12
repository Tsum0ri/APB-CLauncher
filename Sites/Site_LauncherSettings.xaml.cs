using System;
using System.Configuration;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using CLauncher2._0.Window;
using Microsoft.Win32;

namespace CLauncher2._0.Sites
{
    public partial class Site_LauncherSettings : Page
    {
        public Site_LauncherSettings()
        {
            InitializeComponent();
            // ========================================== Loading (User)Launcher-Settings ==========================================
            this.AutoUpdateBox.IsChecked = UserSettings.Default.AutoUpdate;
            this.DynamicBGBox.IsChecked = UserSettings.Default.DynamicBG;

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(1);
        }

        public void SavingSettings()
        {
            // ================================================ Save User-Settings ==================================================
            UserSettings.Default.AutoUpdate = (bool)AutoUpdateBox.IsChecked;
            UserSettings.Default.DynamicBG = (bool)DynamicBGBox.IsChecked;
            UserSettings.Default.Save();
        }

        private void btn_import_Click(object sender, RoutedEventArgs e)
        {
            //Imports Settings
            var dialog = new OpenFileDialog();
            dialog.Filter = "Config files (*.config)|*.config|All files (*.*)|*.*";

            if (dialog.ShowDialog() == true)
            {
                File.Copy(dialog.FileName, ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath, true);
            }
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {
            //Exports Settings
            var dialog = new SaveFileDialog();
            dialog.Filter = "Config files (*.config)|*.config|All files (*.*)|*.*";

            if (dialog.ShowDialog() == true)
            {
                File.Copy(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath, dialog.FileName, true);
            }
        }

        private void btn_background_Click(object sender, RoutedEventArgs e)
        {
            //Select Background-Image
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (dialog.ShowDialog() == true)
            {
                var bitmap = new BitmapImage(new Uri(dialog.FileName));
                Window.test Home = new Window.test();
                Home.LauncherBG.Source = bitmap;

                lastSelectedImagePath = dialog.FileName;

                // Speichern des Pfads zur zuletzt ausgewählten Datei
                UserSettings.Default.LastSelectedImagePath = lastSelectedImagePath;
                UserSettings.Default.Save();

            }
        }

        // Path to the last selected background image file
        private string lastSelectedImagePath = "";

        private void btn_backgroundreset_Click(object sender, RoutedEventArgs e)
        {
            UserSettings.Default.LastSelectedImagePath = "";
            UserSettings.Default.Save();
        }
    }
}

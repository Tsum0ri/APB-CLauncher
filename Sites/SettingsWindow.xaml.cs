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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CLauncher2._0
{
    /// <summary>
    /// Interaktionslogik für SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            site_settings.Content = new Settings.site_ingame();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        //SideBar Buttons ================================================================ |>
        private void Ingame_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_settings.Content = new Settings.site_ingame();
        }

        private void Settings_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_settings.Content = new Settings.site_s_settings();
        }

        private void Textures_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_settings.Content = new Settings.site_textures();
        }

        private void Other_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_settings.Content = new Settings.site_s_other();
        }

    }
}

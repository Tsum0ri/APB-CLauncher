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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CLauncher2._0.Settings
{
    /// <summary>
    /// Interaktionslogik für site_main_settings.xaml
    /// </summary>
    public partial class site_main_settings : Page
    {
        public site_main_settings()
        {
            InitializeComponent();
            site_settings.Content = new Settings.site_ingame();
        }

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

        private void Input_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_settings.Content = new Settings.site_s_other();
            //site_settings.Content = new site_wip();
        }

        private void Lod_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_settings.Content = new Settings.site_s_memlod();
        }
    }
}

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

namespace CLauncher2._0.Configs
{
    /// <summary>
    /// Interaktionslogik für site_main_configs.xaml
    /// </summary>
    public partial class site_main_configs : Page
    {
        public site_main_configs()
        {
            InitializeComponent();
            site_configs.Content = new Configs.site_c_mission();
        }

        private void Mission_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new Configs.site_c_mission();
        }

        private void Description_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new site_c_description();
        }

        private void Killfeed_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new Configs.site_c_killfeed();
        }

        private void Other_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new site_wip();
        }

        private void Pre_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new Configs.site_c_pre();
        }

    }
}

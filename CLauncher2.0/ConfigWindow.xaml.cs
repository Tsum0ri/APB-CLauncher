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
    /// Interaktionslogik für ConfigWindow.xaml
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
        }


        private void pre_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new Configs.site_c_pre();
        }

        private void Mission_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new Configs.site_c_mission();
        }

        private void Killfeed_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new Configs.site_c_killfeed();
        }

        private void Description_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            site_configs.Content = new site_wip();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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

namespace CLauncher2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Site_Content.Content = new Site_Home();
            //Site_Content.Content = new Site_Info();
            Sites.test t = new Sites.test();
            t.Show();

        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Info_Btn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Site_Content.Content = new Site_Info();
        }

        private void Info_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Site_Info();
        }

        private void Home_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Site_Content.Content = new Site_Home();
        }

        private void Settings_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SettingsWindow SWIN = new SettingsWindow();
            SWIN.Show();
        }

        private void Configs_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ConfigWindow SWIN = new ConfigWindow();
            SWIN.Show();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            LauncherSettings LS = new LauncherSettings();
            LS.Show();
        }
    }
}

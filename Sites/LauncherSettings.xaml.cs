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
    /// Interaktionslogik für LauncherSettings.xaml
    /// </summary>
    public partial class LauncherSettings : Window
    {
        public LauncherSettings()
        {
            InitializeComponent();

            // ========================================== Loading User-Settings ==========================================
            this.AutoUpdateBox.IsChecked = UserSettings.Default.AutoUpdate;
            this.DynamicBGBox.IsChecked = UserSettings.Default.DynamicBG;
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            // ========================================== Save User-Settings ==========================================
            UserSettings.Default.AutoUpdate = (bool)AutoUpdateBox.IsChecked;
            UserSettings.Default.DynamicBG = (bool)DynamicBGBox.IsChecked;
            UserSettings.Default.Save();
        }

        private void header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}

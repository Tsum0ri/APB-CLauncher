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

namespace CLauncher2._0
{
    /// <summary>
    /// Interaktionslogik für Site_Info.xaml
    /// </summary>
    public partial class Site_Info : Page
    {
        public Site_Info()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string targetURL = @"https://paypal.me/elygate";
            System.Diagnostics.Process.Start(targetURL);
        }
    }
}

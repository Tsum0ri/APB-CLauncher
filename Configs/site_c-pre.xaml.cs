using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
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
    /// Interaktionslogik für site_c_pre.xaml
    /// </summary>
    public partial class site_c_pre : Page
    {
        public site_c_pre()
        {
            InitializeComponent();
        }

        WebClient client = new WebClient();



        void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded");
        }
        private void TsumoriInstall_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);

            client.DownloadDataAsync(new Uri("https://clauncher.download/pre-configs/1.zip"), (Environment.CurrentDirectory) + @"\1.zip");
        }
    }
}

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
    /// Interaktionslogik für site_c_description.xaml
    /// </summary>
    public partial class site_c_description : Page
    {
        public site_c_description()
        {


            InitializeComponent();

            DefaultSelected = false;
            SimpleSelected = false;


            if (DefaultSelected == true)
            {
                DefaultStatus.Visibility = Visibility.Visible;
            }
            else
            {
                DefaultStatus.Visibility = Visibility.Collapsed;
            }

            if (SimpleSelected == true)
            {
                SimpleStatus.Visibility = Visibility.Visible;
            }
            else
            {
                SimpleStatus.Visibility = Visibility.Collapsed;
            }
        }

        public bool DefaultSelected { get; private set; }
        public bool SimpleSelected { get; private set; }

        private void Default_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DefaultSelected = true;
            SimpleSelected = false;

        }

        private void Simple_Btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SimpleSelected = true;
            DefaultSelected = false;
        }

    }
}

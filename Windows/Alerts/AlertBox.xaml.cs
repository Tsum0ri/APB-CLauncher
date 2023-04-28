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

namespace CLauncher2._0.Windows.Alerts
{
    /// <summary>
    /// Interaktionslogik für AlertBox.xaml
    /// </summary>
    public partial class AlertBox : System.Windows.Window
    {
        public AlertBox()
        {
            InitializeComponent();
            ClosingMySelf();
        }

        private async void ClosingMySelf()
        {
            await Task.Delay(2000);
            this.Hide();
        }

    }
}

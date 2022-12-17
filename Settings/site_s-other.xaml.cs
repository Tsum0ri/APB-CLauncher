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
using Launcher;
using System.IO;

namespace CLauncher2._0.Settings
{
    /// <summary>
    /// Interaktionslogik für site_s_other.xaml
    /// </summary>
    public partial class site_s_other : Page
    {

        //HoldLean
        string LeanLeft = "LeanLeft";
        string LeanLeftKeyDown = "LeanLeftKeyDown";
        string LeanRight = "LeanRight";
        string LeanRightKeyDown = "LeanRightKeyDown";

        //HoldCrouch
        string Duck = "Duck";
        string Button = "Button m_bDuckButton";

        //AlwaysSprint



        public site_s_other()
        {
            InitializeComponent();
        }

        //HoldLean
        private void HoldLean_Checked(object sender, RoutedEventArgs e)
        {

            string[] Input = File.ReadAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBInput.ini");

            Input[55] = "Bindings=(Name=" + LeanLeft + ",Command=" + LeanLeftKeyDown + " | OnRelease LeanLeftKeyDown)";
            Input[56] = "Bindings=(Name=" + LeanRight + ",Command=" + LeanRightKeyDown + " | OnRelease LeanRightKeyDown)";

            File.WriteAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBInput.ini", Input, Encoding.Unicode);
        }

        private void HoldLean_Unchecked(object sender, RoutedEventArgs e)
        {

            string[] Input = File.ReadAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBInput.ini");

            Input[55] = "Bindings=(Name=" + LeanLeft + ",Command=" + LeanLeftKeyDown + ")";
            Input[56] = "Bindings=(Name=" + LeanRight + ",Command=" + LeanRightKeyDown + ")";

            File.WriteAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBInput.ini", Input, Encoding.Unicode);
        }

        //HoldCrouch
        private void HoldCrouch_Checked(object sender, RoutedEventArgs e)
        {
            string[] Input = File.ReadAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBInput.ini");

            Input[45] = "Bindings=(Name=" + Duck + ",Command=" + Button + "| InputToggleDuck" + ")";

            File.WriteAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBInput.ini", Input, Encoding.Unicode);
        }

        private void HoldCrouch_Unchecked(object sender, RoutedEventArgs e)
        {
            string[] Input = File.ReadAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBInput.ini");

            Input[45] = "Bindings=(Name=" + Duck + ",Command=" + Button + "| InputToggleDuck | OnRelease InputToggleDuck" + ")";

            File.WriteAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBInput.ini", Input, Encoding.Unicode);
        }

        //AlwaysSprint
        private void AlwaysSprint_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AlwaysSprint_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}

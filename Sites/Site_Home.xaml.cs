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
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using HandyControl.Tools.Extension;

namespace CLauncher2._0
{
    /// <summary>
    /// Interaktionslogik für Site_Home.xaml
    /// </summary>
    public partial class Site_Home : Page
    {
        public Site_Home()
        {
            InitializeComponent();

            LanguageSelector.SelectedIndex = UserSettings.Default.LanguageSelectorSetting;
            this.NoMovies.IsChecked = UserSettings.Default.NoMoviesSetting;



            var test = new WebClient().DownloadString("https://elygate.com/Smdb.json");//test
            stats d = JsonConvert.DeserializeObject<stats>(test); //test


            var json = new WebClient().DownloadString("https://will.io/apb/stats.php");
            stats c = JsonConvert.DeserializeObject<stats>(json);
            CpopNumber.Content = c.Citadel[c.Citadel.Length - 1];
            JpopNumber.Content = c.Jericho[c.Jericho.Length - 1];

            //string[] Citadeloff = new string[c.Citadel.Length - 1];
            //Citadeloff[c.Citadel.Length - 1] = "null";

            if (d.Citadel == null) //set Status Text & Color
            {
                c_status.Content = "OFFLINE";
                c_status.Foreground = new SolidColorBrush(Colors.Red);
                CpopNumber.Content = "0";
            }
            else
            {
                c_status.Content = "ONLINE";
                c_status.Foreground = new SolidColorBrush(Colors.Green);
            }

            if (c.Jericho is null) //set Status Text & Color
            {
                j_status.Content = "OFFLINE";
                j_status.Foreground = new SolidColorBrush(Colors.Red);
                JpopNumber.Content = "0";
            }
            else
            {
                j_status.Content = "ONLINE";
                j_status.Foreground = new SolidColorBrush(Colors.Green);
            }

        }



        public class stats
        {

            [JsonProperty("3103")]
            public string[] Citadel { get; set; } //Citadel

            [JsonProperty("3002")]
            public string[] Jericho { get; set; } //Jericho

            public string[] times { get; set; } //time of entry

        }

        private void LanguageSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.LanguageSelector.SelectedIndex == 1)
            {
                this.LanguageSelector.SelectedIndex = 6;
            }
            else if (this.LanguageSelector.SelectedIndex == 2)
            {
                this.LanguageSelector.SelectedIndex = 6;
            }
            else if (this.LanguageSelector.SelectedIndex == 3)
            {
                this.LanguageSelector.SelectedIndex = 6;
            }
            else if (this.LanguageSelector.SelectedIndex == 4)
            {
                this.LanguageSelector.SelectedIndex = 6;
            }
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.LanguageSelector.SelectedIndex == 0)
            {
                if ((bool)this.NoMovies.IsChecked)
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1033 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
                else
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1033", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
            }
            else if (this.LanguageSelector.SelectedIndex == 1)
            {
                if ((bool)this.NoMovies.IsChecked)
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1036 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
                else
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1036", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
            }
            else if (this.LanguageSelector.SelectedIndex == 2)
            {
                if ((bool)this.NoMovies.IsChecked)
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1031 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
                else
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1031", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
            }
            else if (this.LanguageSelector.SelectedIndex == 3)
            {
                if ((bool)this.NoMovies.IsChecked)
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1040 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
                else
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1040", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
            }
            else if (this.LanguageSelector.SelectedIndex == 4)
            {
                if ((bool)this.NoMovies.IsChecked)
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1034 -nomoviestartup", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
                else
                {
                    try
                    {
                        Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe -language=1034", AppWinStyle.MinimizedFocus, false, -1);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                        ProjectData.ClearProjectError();
                    }
                }
            }
            else
            {
                try
                {
                    Interaction.Shell(Environment.CurrentDirectory + "\\Binaries\\APB.exe", AppWinStyle.MinimizedFocus, false, -1);
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.Critical, (object)null);
                    ProjectData.ClearProjectError();
                }
            }

            UserSettings.Default.NoMoviesSetting = (bool)this.NoMovies.IsChecked;
            UserSettings.Default.LanguageSelectorSetting = this.LanguageSelector.SelectedIndex;
            UserSettings.Default.Save();
            System.Windows.Application.Current.Shutdown();
        }

    }
}



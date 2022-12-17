using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Net;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


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
            
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            

            
            var json = new WebClient().DownloadString("https://will.io/apb/stats.php");
            stats c = JsonConvert.DeserializeObject<stats>(json);
            CpopNumber.Content = c.Citadel[c.Citadel.Length - 1];
            JpopNumber.Content = c.Jericho[c.Jericho.Length - 1];

            //string[] Citadeloff = new string[c.Citadel.Length - 1];
            //Citadeloff[c.Citadel.Length - 1] = "null";

            if (c.Citadel == null) //set Status Text & Color
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

        private void Start_Game_Click(object sender, RoutedEventArgs e)
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
            else if (this.LanguageSelector.SelectedIndex == 5)
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
            else if (this.LanguageSelector.SelectedIndex == 6)
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



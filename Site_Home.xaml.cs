using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Net;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Windows.Media.Imaging;
using HtmlAgilityPack;
using System.Linq;
using System.IO;

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
            /* LoadBanner(); */
            LanguageSelector.SelectedIndex = UserSettings.Default.LanguageSelectorSetting;
            this.NoMovies.IsChecked = UserSettings.Default.NoMoviesSetting;
            
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            

            try
            {

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
            catch (Exception ex) 
            {
                Windows.Fatal_Error FatalError = new Windows.Fatal_Error();
                FatalError.Show();
                FatalError.ErrorCode.Content = "<Error:Error Informations=" + '\u0022' + "Unable to Load Population from https://will.io/apb/" + '\u0022' + ">";
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


        /*
        private void LoadBanner()
        {


            // Create a WebClient object to download the webpage HTML
            using (var client = new WebClient())
            {
                // Download the webpage HTML as a string
                var html = client.DownloadString("https://www.gamersfirst.com/launchers/apb/");

                // Load the HTML into an HtmlDocument using HtmlAgilityPack
                var doc = new HtmlDocument();
                doc.LoadHtml(html);

                // Find the "ul" element with an "id" attribute value of "banner"
                var bannerUl = doc.DocumentNode.SelectSingleNode("//ul[@id='banners']");

                // Get the first "img" element inside the "ul" element and extract its "src" attribute value
                var imgSrc = bannerUl?.Descendants("img").FirstOrDefault()?.GetAttributeValue("src", null);

                if (!string.IsNullOrEmpty(imgSrc))
                {
                    // Combine the base URL of the webpage with the relative image URL
                    var baseUrl = "https://www.gamersfirst.com/launchers/apb/";
                    var imageUrl = new Uri(new Uri(baseUrl), imgSrc).AbsoluteUri;

                    // Download the image using WebClient
                    var imageData = client.DownloadData(imageUrl);

                    // Convert the image data to a BitmapImage and set it as the source of an Image control
                    var image = new BitmapImage();
                    using (var stream = new MemoryStream(imageData))
                    {
                        image.BeginInit();
                        image.CacheOption = BitmapCacheOption.OnLoad;
                        image.StreamSource = stream;
                        image.EndInit();
                    }
                    bannerImage.Source = image;
                }
            }
        }
        */
    }
}



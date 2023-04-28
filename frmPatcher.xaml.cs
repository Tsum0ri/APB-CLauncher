//Code by Tsumori 2021 feat. USPStyle
//APB Reloaded CLauncher
//© 2021 GamersFirst.com, Little Orbit, LLC. All rights reserved

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CLauncher2._0
{
    /// <summary>
    /// Interaktionslogik für frmPatcher.xaml
    /// </summary>
    public partial class frmPatcher : System.Windows.Window
    {

        private readonly string Version = "vb1.69";
        private WebClient client = new WebClient();
        private Stopwatch dlrate = new Stopwatch();
        private string URL = "https://beta.clauncher.download/";
        private string AppName = "APB CLauncher.exe";
        private string OldAppName = "APB CLauncher_old.exe";
        private string DL = "https://beta.clauncher.download//APB CLauncher.exe";
        private string AppPath = (Environment.CurrentDirectory);
        private string ServerVersion;
        private string serverVersionName = "version.txt";



        public frmPatcher()
        {
            InitializeComponent();
            
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
        }

        private void Window_Loaded(object sender, EventArgs e) => this.checkForUpdate();

        private string getVersion() => this.Version;

        private Stopwatch sw = new Stopwatch();
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            CtrlProgressBar.Value = e.ProgressPercentage;
            // Calculate download speed
            this.lblDownloadSpeed.Content = frmPatcher.BytesToString(e.BytesReceived / this.sw.Elapsed.TotalSeconds);

        }
        private static String BytesToString(double byteCount)
        {
            // Converts the download speed
            string[] suf = { "B/s", "KB/s", "MB/s", "GB/s" }; //Longs run out around EB
            if (byteCount == 0)
            return "0" + suf[0];
            long bytes = Math.Abs((long)byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + " " + suf[place];
        }


        private void checkForUpdate()
        {
            this.ServerVersion = new StreamReader(WebRequest.Create(this.URL + this.serverVersionName).GetResponse().GetResponseStream()).ReadLine();
            if (this.getVersion() != this.ServerVersion)
            {
                System.IO.File.Move(this.AppPath + @"\APB CLauncher.exe", this.AppPath + @"\APB CLauncher_old.exe");
                this.dlrate.Start();
                this.client.DownloadFileAsync(new Uri(this.DL), this.AppPath + @"\" + this.AppName);
                this.client.DownloadFileCompleted += new AsyncCompletedEventHandler(this.Completed);
                updatingText();
                this.sw.Start();
            }
            else
            {
                int num = (int)System.Windows.Forms.MessageBox.Show("Launcher is on latest version.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private async void Completed(object sender, AsyncCompletedEventArgs e)
        {
            this.dlrate.Reset();
            if (e.Cancelled)
            {
                this.lblStatusText.Content = "Download has been canceled. Starting Launcher...";
                this.StartMainForm();
            }
            else
            {
                this.lblStatusText.Content = "Download completed!";
                await Task.Delay(1000);
                var currentExecutablePath = Process.GetCurrentProcess().MainModule.FileName;
                Process.Start(currentExecutablePath);
                System.Windows.Application.Current.Shutdown();
            }
        }


        private async void updatingText()
        {
            int x = 0;

            while (true)
            {
                this.lblStatusText.Content = "Downloading.";
                await Task.Delay(250);
                this.lblStatusText.Content = "Downloading..";
                await Task.Delay(250);
                this.lblStatusText.Content = "Downloading...";
                await Task.Delay(250);
                x++;

                if (this.lblStatusText.Content == "Download completed!")
                    break;
            }
        }

        private async void StartMainForm()
        {
            await Task.Delay(2000);
            this.Hide();
            MainWindow MainForm = new MainWindow();
            MainForm.Closed += (EventHandler)((s, args) => this.Close());
            MainForm.Show();
            MainForm = (MainWindow)null;
        }

    }
}

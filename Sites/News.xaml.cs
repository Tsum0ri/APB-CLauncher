using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;

namespace CLauncher2._0.Sites
{
    /// <summary>
    /// Interaktionslogik für News.xaml
    /// </summary>
    public partial class News : Page
    {


        public News()
        {
            InitializeComponent();
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string path = (sender as Button).Tag as string;
            Process.Start(path);
        }

        async Task<string> GetJsonData()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.apbdb.com/beacon/tracker/"))
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    return jsonData;
                }
            }
        }

        async Task<List<Tracker>> GetTrackerData()
        {
            string jsonData = await GetJsonData();
            List<Tracker> trackerData = JsonConvert.DeserializeObject<List<Tracker>>(jsonData);
            return trackerData;
        }

        public class Tracker
        {
            public string ID { get; set; }
            public string AuthorID { get; set; }
            public string ForumName { get; set; }
            public string ThreadLink { get; set; }
            public string ThreadName { get; set; }
            public string PubDate { get; set; }
            public string PostLink { get; set; }
            public string Name { get; set; }
            public string ProfileLink { get; set; }
            public string ImageLink { get; set; }
            public string GroupName { get; set; }
            public string GroupColor { get; set; }


        }

        async Task<string> GetTrackerJson()
        {
            List<Tracker> trackerData = await GetTrackerData();
            string json = JsonConvert.SerializeObject(trackerData, Formatting.Indented);
            return json;
        }
    }
}

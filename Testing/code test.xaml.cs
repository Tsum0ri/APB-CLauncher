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

namespace CLauncher2._0.Testing
{
    /// <summary>
    /// Interaktionslogik für code_test.xaml
    /// </summary>
    public partial class code_test : System.Windows.Window
    {
        public code_test()
        {
            InitializeComponent();
            PopulateTrackerList();


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

        async Task PopulateTrackerList()
        {
            List<Tracker> trackerData = await GetTrackerData();
            trackerListView.ItemsSource = trackerData;
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


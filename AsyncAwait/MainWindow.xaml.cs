using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var html = await GetHtmlAsync("https://www.google.com/");
            MessageBox.Show(html.Substring(0, 10));
            //DownlodHtmlAsync("https://www.google.com/");
        }
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }
        public async Task DownlodHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);
            using (var streamWriter = new StreamWriter(@"d:\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var streamWriter = new StreamWriter(@"d:\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}

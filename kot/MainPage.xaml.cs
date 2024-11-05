using System.Net;

namespace kot
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string kot1 = "https://cataas.com/cat";
            string kot2;
            using (var webClient = new WebClient())
            {
                kot2 = webClient.DownloadString(kot1);
            }

            kot.Source = kot1;
        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            string kot10 = "https://cataas.com/cat/gif";
            string kot20;
            using (var webClient = new WebClient())
            {
                kot20 = webClient.DownloadString(kot10);
            }

            kot11.Source = kot10;
        }
    }

}

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
            string kot01 = "https://cataas.com/cat";
            string kot02;
            using (var webClient = new WebClient())
            {
                kot02 = webClient.DownloadString(kot01);
            }

            kot0.Source = kot01;
        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            string kot11 = "https://cataas.com/cat/gif";
            string kot12;
            using (var webClient = new WebClient())
            {
                kot12 = webClient.DownloadString(kot11);
            }

            kot1.Source = kot11;
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            string kot2s = kot2say.Text;
            string kot21 = "https://cataas.com/cat/says/"+kot2s;
            string kot22;
            using (var webClient = new WebClient())
            {
                kot22 = webClient.DownloadString(kot21);
            }

            kot2.Source = kot21;
        }
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            string kot3s = kot3say.Text;
            string kot31 = "https://cataas.com/cat/gif/says/" + kot3s;
            string kot32;
            using (var webClient = new WebClient())
            {
                kot32 = webClient.DownloadString(kot31);
            }

            kot3.Source = kot31;
        }
        
            private void OnCounterClicked4(object sender, EventArgs e)
        {
            string kot4s = kot4say.Text;
            string kot4fs = kot4font.Text;
            string kot4fc = kot4color.Text;
            string kot41 = "https://cataas.com/cat/gif/says/" + kot4s+ "?fontSize="+kot4fs+"&fontColor="+kot4fc;
            string kot42;
            using (var webClient = new WebClient())
            {
                kot42 = webClient.DownloadString(kot41);
            }

            kot4.Source = kot41;
        }
    }

}

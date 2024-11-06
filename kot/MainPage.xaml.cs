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
            kot0.Source = kot01;
        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            string kot11 = "https://cataas.com/cat/gif";
            string kot12;
            kot1.Source = kot11;
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            string kot2s = kot2say.Text;
            string kot21 = "https://cataas.com/cat/says/"+kot2s;
            kot2.Source = kot21;
        }
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            string kot3s = kot3say.Text;
            string kot31 = "https://cataas.com/cat/gif/says/" + kot3s;
            kot3.Source = kot31;
        }
            private void OnCounterClicked4(object sender, EventArgs e)
        {
            string kot4s = kot4say.Text;
            string kot4fs = kot4font.Text;
            string kot4fc = kot4color.Text;
            string kot41 = "https://cataas.com/cat/gif/says/" + kot4s+ "?fontSize="+kot4fs+"&fontColor="+kot4fc;
            kot4.Source = kot41;
        }
    }
}

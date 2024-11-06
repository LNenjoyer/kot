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
            kot0.Source = "https://cataas.com/cat";
        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            kot1.Source = "https://cataas.com/cat/gif";
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            string kot2s = kot2say.Text;
            kot2.Source = "https://cataas.com/cat/says/" + kot2s;
        }
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            string kot3s = kot3say.Text;
            kot3.Source = "https://cataas.com/cat/gif/says/" + kot3s;
        }
            private void OnCounterClicked4(object sender, EventArgs e)
        {
            string kot4s = kot4say.Text;
            string kot4fs = kot4font.Text;
            string kot4fc = kot4color.Text;
            kot4.Source = "https://cataas.com/cat/gif/says/" + kot4s + "?fontSize=" + kot4fs + "&fontColor=" + kot4fc;
        }
    }
}

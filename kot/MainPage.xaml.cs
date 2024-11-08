using System.Net;

namespace kot
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            bigkatze0.ValueChanged += (s, e) =>
            {
                double pct = Math.Round(e.NewValue);
                kot0.HeightRequest = pct;
            };
            bigkatze1.ValueChanged += (s, e) =>
            {
                double pct = Math.Round(e.NewValue);
                kot1.HeightRequest = pct;
            };
            bigkatze2.ValueChanged += (s, e) =>
            {
                double pct = Math.Round(e.NewValue);
                kot2.HeightRequest = pct;
            };
            bigkatze3.ValueChanged += (s, e) =>
            {
                double pct = Math.Round(e.NewValue);
                kot3.HeightRequest = pct;
            };
            bigkatze4.ValueChanged += (s, e) =>
            {
                double pct = Math.Round(e.NewValue);
                kot4.HeightRequest = pct;
            };

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

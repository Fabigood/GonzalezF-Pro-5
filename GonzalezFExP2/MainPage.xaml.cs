namespace GonzalezFExP2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnVerChistesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chistes());
        }

        private async void OnAcercaDeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About1());
        }
    }
}


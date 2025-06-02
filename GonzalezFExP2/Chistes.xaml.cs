using System.Net.Http.Json;

namespace GonzalezFExP2;

public partial class Chistes : ContentPage
{
    private readonly HttpClient _httpClient;

    public Chistes()
    {
        InitializeComponent();
        _httpClient = new HttpClient();
        CargarChiste();
    }

    private async void CargarChiste()
    {
    }

    private void OnOtroChisteClicked(object sender, EventArgs e)
    {
        CargarChiste();
    }
}


public class Joke
{
    public string Setup { get; set; }
    public string Punchline { get; set; }
}
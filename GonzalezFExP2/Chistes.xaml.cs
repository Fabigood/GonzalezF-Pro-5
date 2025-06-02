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
        try
        {
            var url = "https://official-joke-api.appspot.com/random_joke";
            var chiste = await _httpClient.GetFromJsonAsync<Joke>(url);

            if (chiste != null)
            {
                lblChiste.Text = $"{chiste.Setup}\n\n{chiste.Punchline}";
            }
            else
            {
                lblChiste.Text = "No se pudo cargar el chiste.";
            }
        }
        catch
        {
            lblChiste.Text = "Error al obtener el chiste.";
        }
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
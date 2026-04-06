using Newtonsoft.Json;

namespace SicilyLinesMobile;

public partial class EditProfile : ContentPage
{
    private static readonly HttpClient _client = new HttpClient();

    public EditProfile()
    {
        InitializeComponent();
        LoadDataFromAPI();
    }

    public async void LoadDataFromAPI()
    {
        try
        {
            HttpResponseMessage response = await _client.GetAsync("http://localhost:5028/User/1");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<User>(content);
                Identifiant.Text = user.Identifiant;
                Mail.Text = user.Email;
                Password.Text = user.Password;
                Nom.Text = user.Nom;
                Prenom.Text = user.Prenom;
                Identifiant.Text = user.Identifiant; // ← modifiable
                Mail.Text = user.Email;
                Password.Text = user.Password;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erreur", ex.Message, "OK");
        }
    }

    private async void OnValidateClicked(object sender, EventArgs e)
    {
        var userModifie = new User
        {
            Id = 1,
            Identifiant = Identifiant.Text,
            Email = Mail.Text,
            Password = Password.Text
        };

        var json = JsonConvert.SerializeObject(userModifie);
        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        var response = await _client.PostAsync("http://localhost:5028/User/Update", content);

        if (response.IsSuccessStatusCode)
            await DisplayAlert("Info", "Modification réussie", "OK");
        else
            await DisplayAlert("Erreur", "La modification a échoué", "OK");
    }

    private async void OnDeconnexionClicked(object sender, EventArgs e)
    {
        Application.Current.Resources.Remove("UserPseudo");
        await Shell.Current.GoToAsync("//MainPage");
    }
}



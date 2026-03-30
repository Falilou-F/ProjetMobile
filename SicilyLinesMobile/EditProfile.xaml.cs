using Newtonsoft.Json;

namespace SicilyLinesMobile;

public partial class EditProfile : ContentPage
{
	public EditProfile()
	{
        InitializeComponent();
        loadDataFromAPI();
    }

    public async void loadDataFromAPI()
    {
        HttpClient client = new HttpClient();
        var restURL = "http://localhost:5028/User/1";

        try
        {
            HttpResponseMessage response = await client.GetAsync(restURL);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<User>(content);
                Identifiant.Text = user.Identifiant;
                Mail.Text = user.Email;
                Password.Text = user.Password;
            }
        }
        catch { }
    }

    private async void OnValidateClicked(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        var restURL = "http://localhost:5028/User/Update";

        var userModifie = new User
        {
            Identifiant = Identifiant.Text,
            Email = Mail.Text,
            Password = Password.Text
        };

        string json = JsonConvert.SerializeObject(userModifie);
        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

        var response = await client.PostAsync(restURL, content);
        if (response.IsSuccessStatusCode)
        {
            await DisplayAlert("Info", "Modification réussie", "OK");
            await Shell.Current.GoToAsync("//Dashboard");
        }
        else 
        {             
            await DisplayAlert("Erreur", "La modification a échoué", "OK");
        }
    }


}
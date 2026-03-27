

namespace SicilyLinesMobile
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public void OnForgotPasswordTapped(object sender, TappedEventArgs e)
        {
            DisplayAlertAsync("Info", "Lien cliqué !", "OK");
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();

                string pseudo = IdentifiantEntry.Text;
                string password = PasswordEntry.Text;

                var restURL = "http://localhost:5028/Login/" + pseudo + "/" + password;

                HttpResponseMessage response = await client.GetAsync(restURL);

                var content = await response.Content.ReadAsStringAsync();

                if (content == "true")
                {
                    await Shell.Current.GoToAsync("DashboardPage");
                }
                else
                {
                    await DisplayAlert("Erreur", "Login ou mot de passe incorrect", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erreur", ex.Message, "Ok");
            }

        }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace SicilyLinesMobile;

public partial class ReservationsPage : ContentPage
{
    public ReservationsPage()
    {
        InitializeComponent();
        LoadReservations();
    }

    private async void LoadReservations()
    {
        try
        {
            var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:5028/Reservation/client/1");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var reservations = JsonConvert.DeserializeObject<List<Reservation>>(json);
                ListeReservations.ItemsSource = reservations;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erreur", ex.Message, "OK");
        }

    }
    private async void OnReservationsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ReservationsPage");
    }
    private async void OnDeconnexionClicked(object sender, EventArgs e)
    {
        // 1. Effacer les données de session
        Application.Current.Resources.Remove("UserPseudo");

        // 2. Retourner à la page de login (le // empêche le retour arrière)
        await Shell.Current.GoToAsync("//MainPage");
    }
}
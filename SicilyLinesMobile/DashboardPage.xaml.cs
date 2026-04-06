namespace SicilyLinesMobile;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

	private async void OnEditProfileClicked(Object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//EditProfile");
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
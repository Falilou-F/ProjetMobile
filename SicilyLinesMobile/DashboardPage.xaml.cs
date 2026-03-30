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


}
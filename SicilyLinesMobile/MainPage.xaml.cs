

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
            await Shell.Current.GoToAsync("DashboardPage");
        }
    }
}

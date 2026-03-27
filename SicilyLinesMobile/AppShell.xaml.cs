namespace SicilyLinesMobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("DashboardPage", typeof(DashboardPage));

        }
    }
}

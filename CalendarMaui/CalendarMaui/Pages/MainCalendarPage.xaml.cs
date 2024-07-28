namespace CalendarMaui.Pages
{

	public partial class MainCalendarPage : ContentPage
    {

		public MainCalendarPage()
        {
			InitializeComponent();

            // Disables page navigation bar
            NavigationPage.SetHasNavigationBar(this, false);
        }

	}

}
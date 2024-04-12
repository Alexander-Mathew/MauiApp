namespace DemoApp.Views;

public partial class LogoutView : ContentPage
{
	public LogoutView()
	{
		InitializeComponent();
		App.Current.MainPage = new AppShell();
	}
}

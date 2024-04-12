namespace DemoApp.Views;

public partial class CustomAppShell : Shell
{
	public CustomAppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(DetailView), typeof(DetailView));
    }
}

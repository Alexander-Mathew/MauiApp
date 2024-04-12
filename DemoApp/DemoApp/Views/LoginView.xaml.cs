using DemoApp.ViewModels;

namespace DemoApp.Views;

public partial class LoginView : ContentPage
{
	public LoginView(LoginViewModel loginViewModel)
	{
		BindingContext = loginViewModel;

        InitializeComponent();
	}
}

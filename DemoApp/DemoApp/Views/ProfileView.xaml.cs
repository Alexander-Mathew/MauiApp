using DemoApp.ViewModels;

namespace DemoApp.Views;

public partial class ProfileView : ContentPage
{
	public ProfileView(ProfileViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}

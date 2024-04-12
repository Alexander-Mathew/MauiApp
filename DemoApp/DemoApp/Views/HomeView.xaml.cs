using DemoApp.ViewModels;

namespace DemoApp.Views;

public partial class HomeView : ContentPage
{
	public HomeView(HomeViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}

using DemoApp.ViewModels;

namespace DemoApp.Views;

public partial class DetailView : ContentPage
{
	public DetailView(DetailViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}

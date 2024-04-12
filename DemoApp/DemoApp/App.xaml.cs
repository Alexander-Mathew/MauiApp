using System.Globalization;
using DemoApp.Services;
using DemoApp.Views;

namespace DemoApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        SetUICulture();
        InitializeComponent();
        MainPage = new AppShell();

    }

    private void SetUICulture()
    {
        Application.Current.UserAppTheme = AppTheme.Light;
        CultureInfo appCulture = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = appCulture;
        Thread.CurrentThread.CurrentUICulture = appCulture;

    }
}


using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoApp.Services;
using DemoApp.Views;

namespace DemoApp.ViewModels
{
	public partial class LoginViewModel : ViewModelBase
	{
        IApiService _apiService;
		public LoginViewModel(IApiService apiservice)
		{
            _apiService = apiservice;
		}

		[ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        string userName;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        string password;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        bool isTermsChecked;

        [RelayCommand(CanExecute = nameof(VaildUser))]
        void Login()
        {
            var response = _apiService.LoginAsync(UserName, Password);
            var result = response.Result;
            //App.Current.MainPage = new CustomAppShell();
        }

        private bool VaildUser()
        {
            return !string.IsNullOrWhiteSpace(UserName) && UserName == "eve.holt@regres.in" && !string.IsNullOrWhiteSpace(Password) && IsTermsChecked;
        }
    }
}


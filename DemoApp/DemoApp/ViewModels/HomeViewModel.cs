using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoApp.Model;
using DemoApp.Views;

namespace DemoApp.ViewModels
{
	public partial class HomeViewModel : ViewModelBase
	{
        [ObservableProperty]
        ObservableCollection<User> users;

        [ObservableProperty]
        string fullName;

		public HomeViewModel()
		{
			Users = new ObservableCollection<User>();
            Initialise();

		}

        [RelayCommand]
        async void Detail(User user)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("UserDetail", user);
            await Shell.Current.GoToAsync(nameof(DetailView),parameter);
        }

        private void Initialise()
        {
            Users = new ObservableCollection<User>(GetUsers());
        }

        private IEnumerable<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Alex",
                    LastName = "Mathew",
                    Email = "alex@gmail.com",
                    Avatar = "https://reqres.in/img/faces/9-image.jpg"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Alex2",
                    LastName = "Mathew2",
                    Email = "alex@gmail.com2",
                    Avatar = "https://reqres.in/img/faces/10-image.jpg"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Alex3",
                    LastName = "Mathew3",
                    Email = "alex@gmail.com3",
                    Avatar = "https://reqres.in/img/faces/11-image.jpg"
                },
            };
        }
    }
}


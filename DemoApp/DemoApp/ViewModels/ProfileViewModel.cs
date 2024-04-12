using System;
using CommunityToolkit.Mvvm.ComponentModel;
using DemoApp.Model;

namespace DemoApp.ViewModels
{
	public partial class ProfileViewModel : ViewModelBase
	{
        [ObservableProperty]
        User userDetail;

		public ProfileViewModel()
		{
			Initialise();
		}

        private void Initialise()
        {
			UserDetail =  GetUser();
        }

        private User GetUser()
        {
            return new User
            {
                Id = 1,
                FirstName = "Janet",
                LastName = "Weaver",
                Email = "janet.weaver@reqres.in",
                Avatar = "https://reqres.in/img/faces/2-image.jpg"
            };
        }
    }
}


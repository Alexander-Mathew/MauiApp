using System;
using CommunityToolkit.Mvvm.ComponentModel;
using DemoApp.Model;

namespace DemoApp.ViewModels
{
    [QueryProperty("UserDetail", "UserDetail")]
    public partial class DetailViewModel : ViewModelBase
	{
        private User _userDetail;
        public User UserDetail
        {
            get => _userDetail;
            set => SetProperty(ref _userDetail, value);
        }

        public DetailViewModel()
		{
            //var id = UserDetail.Id;
		}

	}
}


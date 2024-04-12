using System;
using DemoApp.Services;
using DemoApp.ViewModels;
using DemoApp.Views;
using Refit;
using Uri = System.Uri;

namespace DemoApp
{
	public static class AppInitializer
	{
        public static MauiAppBuilder AppServices(this MauiAppBuilder builder)
        {
            builder.RegisterViews()
                   .RegisterViewModels()
                   .AppDataServices();
            return builder;
        }

        private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<LoginView>();
            builder.Services.AddSingleton<HomeView>();
            builder.Services.AddSingleton<ProfileView>();
            builder.Services.AddSingleton<LogoutView>();
            builder.Services.AddTransient<DetailView>();
            return builder;
        }
        private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<ProfileViewModel>();
            builder.Services.AddTransient<DetailViewModel>();
            return builder;
        }
        private static MauiAppBuilder AppDataServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IDataService, DataService>();
            //builder.Services.AddSingleton<IDataService>();

            builder.Services.AddRefitClient<IApiService>().ConfigureHttpClient(j =>
            {
                j.BaseAddress = new Uri("https://reqres.in");
            });
            //RestService.For<IDataService>("https://reqres.in",
            //    new RefitSettings
            //    {
            //        ContentSerializer = new NewtonsoftJsonContentSerializer()
            //    });

            return builder;
        }

    }
}


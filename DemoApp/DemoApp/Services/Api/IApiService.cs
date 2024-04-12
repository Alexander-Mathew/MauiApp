using System;
using DemoApp.Model;
using Refit;

namespace DemoApp.Services
{
	public interface IApiService 
	{
        [Get("/api/login")]
        Task<string> LoginAsync(string email, string password);
    }
}


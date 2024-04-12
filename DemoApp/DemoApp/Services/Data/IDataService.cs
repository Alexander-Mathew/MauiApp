using System;
using Refit;

namespace DemoApp.Services
{
	public interface IDataService
	{
		[Get("/api/login")]
		Task<HttpResponseMessage> LoginAsync(string email, string password);
	}
}


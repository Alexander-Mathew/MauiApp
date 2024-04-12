using System;

namespace DemoApp.Services
{
	public class DataService : IDataService
	{
        IDataService _dataService;
		public DataService(IDataService dataService)
		{
            _dataService = dataService;
		}

        public async Task<HttpResponseMessage> LoginAsync(string email, string password)
        {
            var response = await _dataService.LoginAsync(email, password);
            return response;
        }
    }
}


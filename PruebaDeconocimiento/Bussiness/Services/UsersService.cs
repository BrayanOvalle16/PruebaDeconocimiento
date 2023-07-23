using PruebaDeconocimiento.Api.Interfaces;
using PruebaDeconocimiento.Api.Models;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace PruebaDeconocimiento.Bussiness.Services
{
    public class UsersService : IUsersService
    {
        private readonly IConfiguration _configuration;

        public UsersService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<User>?> GetAllUsersAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_configuration["URL"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //GET Method
            HttpResponseMessage response = await client.GetAsync("/users");
            if (response.IsSuccessStatusCode)
            {
                List<User> users = await response.Content.ReadFromJsonAsync<List<User>>();
                return users;
            }
            else
            {
                return null;
            }
        }
    }
}

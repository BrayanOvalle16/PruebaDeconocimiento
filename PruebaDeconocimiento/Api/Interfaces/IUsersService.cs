using PruebaDeconocimiento.Api.Models;

namespace PruebaDeconocimiento.Api.Interfaces
{
    public interface IUsersService
    {
        Task<List<User>?> GetAllUsersAsync();
    }
}

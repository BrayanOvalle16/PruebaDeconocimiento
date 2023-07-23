using Microsoft.AspNetCore.Mvc;
using PruebaDeconocimiento.Api.Interfaces;
using PruebaDeconocimiento.Api.Models;

namespace PruebaDeconocimiento.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet()]
        public async Task<ActionResult> GetAllAsync()
        {
            try
            {
                return Ok(await _usersService.GetAllUsersAsync());
            } catch(Exception ex)
            {
                return BadRequest();
            }

        }
    }
}

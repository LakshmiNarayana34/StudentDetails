using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Model;

namespace MyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }

        [HttpGet]
        public IActionResult GetAllResult()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
           var resultSet = _userService.GetUserById(id);
            return Ok(resultSet);
        }

        [HttpPost]
        public IActionResult CreateRecord([FromBody] User user) 
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRecord([FromRoute] int id, [FromBody] User user) 
        {
            _userService.UpdateUser(id, user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpDelete]
        public IActionResult DeleteById(int id) 
        {
            _userService.DeleteUser(id);
            return CreatedAtAction(nameof(GetById),User);
        }
    }
}

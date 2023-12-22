using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }



        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {


            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("Add")]

        public IActionResult Add([FromBody] User user )
        {
          var result = _userService.AddUser(user);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("GetById")]

        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("Update")]

        public IActionResult Update(User user)
        {

            return Ok(_userService.UpdateUser(user));
        }


        [HttpPost("Delete")]

        public IActionResult Delete(User user)
        {

            return Ok(_userService.DeleteUser(user));
        }
    }
}

using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("gettrendyoluser")]
        //[Authorize()]
        public IActionResult GetTrendyolUser()
        {
            var result = _userService.GetTrendyolUser();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getparasutuser")]
        //[Authorize()]
        public IActionResult GetParasutUser()
        {
            var result = _userService.GetParasutUser();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SofartBackend.Business.Contracts;
using SofartBackend.Business.ResponseModels;
using SofartBackend.Entities.Concrete;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [NonAction]
        public IActionResult GetResult(IResponse response)
        {
            if (response.Status == ResultStatus.SUCCESS)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
          var result =  await _userService.Add(user);
            return GetResult(result);

        }

    }
}

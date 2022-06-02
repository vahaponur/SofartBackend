using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SofartBackend.Business.ResponseModels;

namespace WebAPI.Helpers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelperController : ControllerBase
    {

        [NonAction]
        public  IActionResult GetResult(IResponse response)
        {
            if (response.Status == ResultStatus.SUCCESS)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
 
    }
}

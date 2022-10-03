using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SignInWithGoogleAPI.Models;

namespace SignInWithGoogleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecuredController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult ReturnIfAuthorized()
        {
            isAuthorized isAuthorized = new() { Text = "Jeeeee jeje jejejejje" };

            return Ok(isAuthorized);
        }
    }
}

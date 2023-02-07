using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebShopAAA.Controllers.API
{
    [Route("api/authenticationtttt")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        public class AuthenticationRequestBody
        {
            public string? Username { get; set; }
            public string? Password { get; set; }
        }
        //[HttpPost("authentication")]
        //public ActionResult <string> Authenticate()
        //{

        //}
    }
}

using Microsoft.AspNetCore.Mvc;

namespace JACMS.API.Controllers.User
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Create a User.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        /// <summary>
        /// Gets a user details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        /// <summary>
        /// Log user in.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

    }
}

using JACMS.API.Client.Commands.Abstractions;
using JACMS.API.Core.Models.Requests.User;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JACMS.API.Controllers.User
{
    [ApiController]
    [Route("Identity/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ICreateUserCommand _createUserCommand;
        private readonly ILogger<UserController> _logger;

        public UserController(ICreateUserCommand createUserCommand,
                              ILogger<UserController> logger)
        {
            _createUserCommand = createUserCommand;
            _logger = logger;
        }

        /// <summary>
        /// Create a User.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put(UserCreationRequest request)
        {
            try
            {
                var response = await _createUserCommand.CreateNewUserAsync(request);
                if (response.Successful)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(response.ErrorMessages);
                }
            }
            catch(Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets a user details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] long id)
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

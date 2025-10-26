using Microsoft.AspNetCore.Mvc;

namespace JACMS.API.Controllers.Admin
{
    [ApiController]
    [Route("admin/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
    }
}

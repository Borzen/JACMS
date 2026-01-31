using Microsoft.AspNetCore.Mvc;

namespace JACMS.API.Controllers.Identity
{
    [ApiController]
    [Route("Identity/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly ILogger<RoleController> _logger;
    }
}

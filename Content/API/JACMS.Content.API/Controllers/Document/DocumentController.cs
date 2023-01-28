using Microsoft.AspNetCore.Mvc;

namespace JACMS.Content.API.Controllers.Document
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        public dynamic Get(int id)
        {
            return "This test works";
        }
    }
}

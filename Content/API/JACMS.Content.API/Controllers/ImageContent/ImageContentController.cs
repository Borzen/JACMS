using JACMS.Content.APIClient.Models.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JACMS.Content.API.Controllers.ImageContent
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageContentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ImageContentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Put(ImageContentCreateRequest request)
        {
            //ya this one is going to happen a bit later as I am also going to need to create a whole file upload service as well
            return NotFound();
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JACMS.Content.APIClient.Models.Requests;
using JACMS.Content.Core.Commands;
using JACMS.Content.APIClient.Models.Results;

namespace JACMS.Content.API.Controllers.TextContent
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextContentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TextContentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Put(TextContentCreateRequest request)
        {
            DateTime createdDateTime = DateTime.UtcNow;
            int? createdByUser = null;
            var results = _mediator.Send(new CreateTextContentCommand(request.TextValue, request.TextTypeId, createdDateTime, createdByUser));
            if(results.Result.IsSuccessful)
            {
                return StatusCode(StatusCodes.Status201Created, results.Result.Value);
            }
            else
            {
                return BadRequest(results.Result.ErrorMessage);
            }
        }
    }
}

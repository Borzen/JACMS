using JACMS.Content.APIClient.Models.Requests;
using JACMS.Content.APIClient.Models.Results;
using JACMS.Content.Core.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JACMS.Content.API.Controllers.Section
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SectionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Put(SectionCreateRequest request)
        {
            DateTime createdDateTime = DateTime.UtcNow;
            int? createdBy = null;
            var results = _mediator.Send(new CreateSectionCommand(request.SectionName, request.DocumentId, request.ContentTypeId, request.ContentId, false, request.SectionOrder, createdDateTime, createdBy));
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

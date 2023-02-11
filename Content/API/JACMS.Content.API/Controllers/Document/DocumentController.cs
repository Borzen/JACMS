using JACMS.Content.APIClient.Models.Requests;
using JACMS.Content.Core.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JACMS.Content.API.Controllers.Document
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DocumentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Get(int id)
        {
            return NotFound();
        }

        public IActionResult Put(DocumentCreateRequest request)
        {
            DateTime createdDateTime = DateTime.UtcNow;
            int? createdByUser = null;
            var results = _mediator.Send(new CreateDocumentCommand(request.DocumentName,createdDateTime, createdByUser, false));
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

using JACMS.Content.APIClient.Models.Requests;
using JACMS.Content.APIClient.Models.Results;
using JACMS.Content.Core.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JACMS.Content.API.Controllers.TextType
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TextTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Get(int id)
        {
            return null;
        }

        public IActionResult Put(TextTypeRequest request)
        {
            var results = _mediator.Send(new CreateTextTypeCommand(request.TypeName, request.TypeDescription, request.Style));
            return StatusCode(StatusCodes.Status201Created,results.Result.Value);
        }
    }
}

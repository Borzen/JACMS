using JACMS.Content.Core.Commands;
using JACMS.Content.Core.Commands.ReturnTypes;
using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Core.Exceptions;
using JACMS.Content.Core.Repositories.Abstractions;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.CommandHandlers
{
    public class CreateTextContentHandler : RequestHandler<CreateTextContentCommand, IntReturn>
    {
        private readonly ITextContentDataService _textContentDataService;
        private readonly ITextTypeRepository _textTypeRepository;
        public CreateTextContentHandler(ITextContentDataService textContentDataService, ITextTypeRepository textTypeRepository)
        {
            _textContentDataService = textContentDataService;
            _textTypeRepository = textTypeRepository;
        }

        protected override IntReturn Handle(CreateTextContentCommand request)
        {
            if(!_textTypeRepository.TextTypeExists(request.TextTypeId))
            {
                var result = new IntReturn() { IsSuccessful = false, ErrorMessage = ContentExceptions.TextTypeNotFound() };
                return result;
            }
            TextContent content = new TextContent()
            {
                TextValue = request.TextValue,
                TextTypeId = request.TextTypeId,
                IsDeleted = false,
                CreatedDateTime = request.CreatedDateTime,
                CreatedBy = request.CreatedBy
            };
            _textContentDataService.Create(content);
            //get id somehow;
            var contentResult = new IntReturn() { Value = 1, IsSuccessful = true };
            return contentResult;
        }
    }
}

using JACMS.Content.Core.Commands;
using JACMS.Content.Core.Commands.ReturnTypes;
using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using MediatR;

namespace JACMS.Content.CommandHandlers
{
    public class CreateTextTypeHandler : RequestHandler<CreateTextTypeCommand, IntReturn>
    {
        private readonly ITextTypeDataService _textTypeDataService;
        public CreateTextTypeHandler(ITextTypeDataService textTypeDataService) 
        { 
            _textTypeDataService = textTypeDataService; 
        }
        protected override IntReturn Handle(CreateTextTypeCommand request)
        {
            TextType textType = new TextType()
            {
                TypeName= request.TypeName,
                TypeDescription = request.TypeDescription,
                Style = request.Style,
            };
            //get the ID
            return new IntReturn() { Value = 1, IsSuccessful = true };
        }
    }
}

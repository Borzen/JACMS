using JACMS.Content.Core.Commands;
using JACMS.Content.Core.Commands.ReturnTypes;
using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.CommandHandlers
{
    public class CreateDocumentHandler : RequestHandler<CreateDocumentCommand, IntReturn>
    {
        private IDocumentDataService _documentDataService;
        public CreateDocumentHandler(IDocumentDataService documentDataService)
        {
            _documentDataService = documentDataService;
        }

        protected override IntReturn Handle(CreateDocumentCommand request)
        {
            Document document = new Document()
            {
                DocumentName = request.DocumentName,
                CreatedDateTime = request.CreatedDateTime,
                CreatedBy = request.CreatedBy,
                IsDeleted = request.IsDeleted,
            };
            _documentDataService.Create(document);
            //get id;
            int id = 1;
            return new IntReturn(id);
        }
    }
}

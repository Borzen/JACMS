using JACMS.Content.Core.Commands;
using JACMS.Content.Core.Commands.ReturnTypes;
using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Core.Exceptions;
using JACMS.Content.Core.Repositories.Abstractions;
using MediatR;

namespace JACMS.Content.CommandHandlers
{
    public class CreateSectionHandler : RequestHandler<CreateSectionCommand, IntReturn>
    {
        private readonly ISectionDataService _sectionDataService;
        private readonly IDocumentRepository _documentRepository;
        private readonly IContentTypeRepository _contentTypeRepository;
        
        public CreateSectionHandler(ISectionDataService sectionDataService, IDocumentRepository documentRepository, IContentTypeRepository contentTypeRepository)
        {
            _sectionDataService = sectionDataService;
            _documentRepository = documentRepository;
            _contentTypeRepository = contentTypeRepository;
        }

        protected override IntReturn Handle(CreateSectionCommand request)
        {
            if(!_documentRepository.DocumentExists(request.DocumentId))
            {
                return new IntReturn(ContentExceptions.DocumentNotFound());
            }
            if(!_contentTypeRepository.ContentTypeExists(request.ContentTypeId))
            {
                return new IntReturn(ContentExceptions.ContentTypeNotFound());
            }
            Section section = new Section()
            {
                SectionName = request.SectionName,
                DocumentId = request.DocumentId,
                ContentTypeId = request.ContentTypeId,
                ContentId = request.ContentId,
                IsDeleted = request.IsDeleted,
                SectionOrder = request.SectionOrder,
                CreatedDateTime = request.CreatedDateTime,
                CreatedBy = request.CreatedBy,
            };
            _sectionDataService.Create(section);
            //get id;
            int id = 1;
            return new IntReturn(id);
        }
    }
}

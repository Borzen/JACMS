using JACMS.Content.Core.Commands.ReturnTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.Commands
{
    public class CreateSectionCommand : IRequest<IntReturn>
    {
        public string SectionName { get; }
        public int DocumentId { get; }
        public int ContentTypeId { get; }
        public int ContentId { get; }
        public bool IsDeleted { get; }
        public int SectionOrder { get; }
        public DateTime CreatedDateTime { get; }
        public int? CreatedBy { get; }
        public CreateSectionCommand(string sectionName, int documentId, int contentTypeId, int contentId, bool isDeleted, int sectionOrder, DateTime createdDateTime, int? createdBy)
        {
            SectionName = sectionName;
            DocumentId = documentId;
            ContentTypeId = contentTypeId;
            ContentId = contentId;
            IsDeleted = isDeleted;
            SectionOrder = sectionOrder;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
        }
    }
}

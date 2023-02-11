using JACMS.Content.Core.Commands.ReturnTypes;
using MediatR;

namespace JACMS.Content.Core.Commands
{
    public class CreateDocumentCommand : IRequest<IntReturn>
    {
        public string DocumentName { get; }
        public DateTime CreatedDateTime { get; }
        public int? CreatedBy { get; }
        public bool IsDeleted { get; }

        public CreateDocumentCommand(string documentName, DateTime createdDateTime, int? createdBy, bool isDeleted)
        {
            DocumentName = documentName;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            IsDeleted = isDeleted;
        }
    }
}

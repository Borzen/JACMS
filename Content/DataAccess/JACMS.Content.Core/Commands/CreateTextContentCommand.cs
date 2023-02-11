using JACMS.Content.Core.Commands.ReturnTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.Commands
{
    public class CreateTextContentCommand : IRequest<IntReturn>
    {
        public string TextValue { get; }
        public int TextTypeId { get; }
        public DateTime CreatedDateTime { get; }
        public int? CreatedBy { get; }

        public CreateTextContentCommand(string textValue, int textTypeId, DateTime createdDateTime, int? createdBy)
        {
            TextValue = textValue;
            TextTypeId = textTypeId;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
        }
    }
}

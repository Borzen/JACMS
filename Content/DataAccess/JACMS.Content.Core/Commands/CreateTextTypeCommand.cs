using JACMS.Content.Core.Commands.ReturnTypes;
using MediatR;

namespace JACMS.Content.Core.Commands
{
    public class CreateTextTypeCommand : IRequest<IntReturn>
    {
        public string TypeName { get; }
        public string TypeDescription { get; }
        public string Style { get; }

        public CreateTextTypeCommand(string typeName, string typeDescription, string style)
        {
            TypeName = typeName;
            TypeDescription = typeDescription;
            Style = style;
        }
    }
}

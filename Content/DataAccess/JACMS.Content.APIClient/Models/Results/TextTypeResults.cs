using JACMS.Content.APIClient.Models.Requests;

namespace JACMS.Content.APIClient.Models.Results
{
    public class TextTypeResults
    {
        public int TextTypeId { get; }
        public string TypeName { get; }
        public string TypeDescription { get; }
        public string Style { get; }

        public TextTypeResults(int textTypeId, string typeName, string typeDescription, string style)
        {
            TextTypeId = textTypeId;
            TypeName = typeName;
            TypeDescription = typeDescription;
            Style = style;
        }
        public TextTypeResults(int textTypeId, TextTypeRequest request)
        {
            TextTypeId = textTypeId;
            TypeName= request.TypeName;
            TypeDescription = request.TypeDescription;
            Style = request.Style;
        }
    }
}

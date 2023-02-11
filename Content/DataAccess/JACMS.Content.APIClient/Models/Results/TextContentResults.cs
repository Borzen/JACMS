using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.APIClient.Models.Results
{
    public class TextContentResults
    {
        public int TextContentId { get; }
        public string TextValue { get; }
        public int TextTypeId { get; }
        public bool IsDeleted { get; }
        public DateTime CreatedDateTime { get; }
        public int? CreatedBy { get; }
        public DateTime? ModifiedDateTime { get; }
        public int? ModifiedBy { get; }

        public TextContentResults(int textContentId, string textValue, int textTypeId, bool isDeleted, DateTime createdDateTime, int? createdBy = null, DateTime? modifiedDateTime = null, int? modifiedBy = null)
        {
            TextContentId = textContentId;
            TextValue = textValue;
            TextTypeId = textTypeId;
            IsDeleted = isDeleted;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            ModifiedDateTime = modifiedDateTime;
            ModifiedBy = modifiedBy;
        }
    }
}

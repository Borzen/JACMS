using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.APIClient.Models.Results
{
    public class SectionResults
    {
        public int SectionId { get; }
        public string SectionName { get; }
        public int DocumentId { get; }
        public int ContentTypeId { get; }
        public int ContentId { get; }
        public bool IsDeleted { get; }
        public int SectionOrder { get; }
        public DateTime CreatedDateTime { get; }
        public int? CreatedBy { get; }
        public DateTime? ModifiedDaetTime { get; }
        public int? ModifiedBy { get; }

        public SectionResults(int sectionId, string sectionName, int documentId, int contentTypeId, int contentId, bool isDeleted, int sectionOrder, DateTime createdDateTime, int? createdBy = null, DateTime? modifiedDaetTime = null, int? modifiedBy = null)
        {
            SectionId = sectionId;
            SectionName = sectionName;
            DocumentId = documentId;
            ContentTypeId = contentTypeId;
            ContentId = contentId;
            IsDeleted = isDeleted;
            SectionOrder = sectionOrder;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            ModifiedDaetTime = modifiedDaetTime;
            ModifiedBy = modifiedBy;
        }
    }
}

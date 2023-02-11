using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.Constants
{
    public class SQLParamaters
    {
        public const string CreatedDateTime = "CreatedDateTime";
        public const string CreatedBy = "CreatedBy";
        public const string ModifiedDateTime = "ModifiedDateTime";
        public const string ModifiedBy = "ModifiedBy";
        public const string IsDeleted = "IsDeleted";

        public const string DocumentId = "DocumentId";
        public const string DocumentName = "DocumentName";
        public const string DeletedBy = "DeletedBy";

        public const string ContentTypeId = "ContentTypeId";
        public const string ContentDescritpion = "ContentDescritpion";
        public const string TableName = "TableName";

        public const string ImageContentId = "ImageContentId";
        public const string ImageName = "ImageName";
        public const string FileExtension = "FileExtension";
        public const string StorageName = "StorageName";
        public const string AltText = "AltText";

        public const string SectionId = "SectionId";
        public const string SectionName = "SectionName";
        public const string ContentId = "ContentId";
        public const string SectionOrder = "SectionOrder";

        public const string TextContentId = "TextContentId";
        public const string TextValue = "TextValue";

        public const string TextTypeId = "TextTypeId";
        public const string TypeName = "TypeName";
        public const string TypeDescription = "TypeDescription";
        public const string Style = "Style";
    }
    public class SQLQueries
    {
        public const string DocumentSelectTemplate = "Select * From Document";
        public const string ContentTypeTemplate = "Select * From ContentType";
        public const string ImageContentTemplate = "Select * From ImageContent";
        public const string SectionTemplate = "Select * from Section";
        public const string TextContentTemplate = "Select * from TextContent";
        public const string TextTypeTemplate = "Select * from TextType";
    }
    public class SQLStoredProcedures
    {
        public const string ContentTypeCreate = "usp_ContentType_Create";
        public const string ContentTypeUpdate = "usp_ContentType_Update";
        public const string ContentTypeDelete = "usp_ContentType_Delete";
        public const string ContentTypeUndelete = "usp_ContentType_Undelete";


        public const string DocumentCreate = "usp_Document_Create";
        public const string DocumentUpdate = "usp_Document_Update";
        public const string DocumentDelete = "usp_Document_Delete";
        public const string DocumentUndelete = "usp_Document_Undelete";

        public const string ImageContentCreate = "usp_ImageContent_Create";
        public const string ImageContentUpdate = "usp_ImageContent_Update";
        public const string ImageContentDelete = "usp_ImageContent_Delete";
        public const string ImageContentUndelete = "usp_ImageContent_Undelete";

        public const string SectionCreate = "usp_Section_Create";
        public const string SectionUpdate = "usp_Section_Update";
        public const string SectionDelete = "usp_Section_Delete";
        public const string SectionUndelete = "usp_Section_Undelete";

        public const string TextContentCreate = "usp_TextContent_Create";
        public const string TextContentUpdate = "usp_TextContent_Update";
        public const string TextContentDelete = "usp_TextContent_Delete";
        public const string TextContentUndelete = "usp_TextContent_Undelete";


        public const string TextTypeCreate = "usp_TextType_Create";
        public const string TextTypeUpdate = "usp_TextType_Update";
        public const string TextTypeDelete = "usp_TextType_Delete";
        public const string TextTypeUndelete = "usp_TextType_Undelete";

    }

}

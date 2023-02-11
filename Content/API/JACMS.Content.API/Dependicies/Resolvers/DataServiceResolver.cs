using Autofac;
using JACMS.Content.API.Constants;
using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Core.Services.Abstractions;
using JACMS.Content.Infrastructure.Mongo.DataServices;
using JACMS.Content.Infrastructure.MariaDb.DataServices;
using System;

namespace JACMS.Content.API.Dependicies.Resolvers
{
    public class DataServiceResolver
    {
        public static Func<IComponentContext, IContentTypeDataService> GetContentTypeDataService = context =>
        {

            string mariaDbConnectionString = GetMariaDbConnectionString(context);

            IContentTypeDataService contentTypeDataService = new ContentTypeDataService(mariaDbConnectionString);
            return contentTypeDataService;
        };

        public static Func<IComponentContext, IDocumentDataService> GetDocumentDataService = context =>
        {
            string mariaDbConnectionString = GetMariaDbConnectionString(context);

            IDocumentDataService documentDataService = new DocumentDataService(mariaDbConnectionString);
            return documentDataService;
        };

        public static Func<IComponentContext, IImageContentDataService> GetImageContentDataService = context =>
        {
            string mariaDbConnectionString = GetMariaDbConnectionString(context);
            IImageContentDataService imageContentDataService = new ImageContentDataService(mariaDbConnectionString);
            return imageContentDataService;
        };

        public static Func<IComponentContext, IPageDataService> GetPageDataService = context =>
        {
            IMongoService<Page> mongoService = context.Resolve<IMongoService<Page>>();

            IPageDataService pageDataService = new PageDataService(mongoService);

            return pageDataService;
        };

        public static Func<IComponentContext, ISectionDataService> GetSectionDataService = context =>
        {
            string mariaDbContextString = GetMariaDbConnectionString(context);
            ISectionDataService sectionDataService = new SectionDataService(mariaDbContextString);
            return sectionDataService;
        };

        public static Func<IComponentContext, ITextContentDataService> GetTextContentDataService = context =>
        {
            string mariaDbContextString = GetMariaDbConnectionString(context);
            ITextContentDataService textContentDataService = new TextContentDataService(mariaDbContextString);
            return textContentDataService;
        };

        public static Func<IComponentContext, ITextTypeDataService> GetTextTypeDataService = context =>
        {
            string mariaDbContextString = GetMariaDbConnectionString(context);
            ITextTypeDataService textTypeDataService = new TextTypeDataService(mariaDbContextString);
            return textTypeDataService;
        };

        private static string GetMariaDbConnectionString(IComponentContext context)
        {
            var config = context.Resolve<IConfiguration>();
            string mariaDbConnectionStringTemplate = config.GetConnectionString(ConfigurationConstants.MariaDBConnectionString);
            string mariaDbUserName = config.GetValue<string>(ConfigurationConstants.MariaDBUserName);
            string mariaDbPassword = config.GetValue<string>(ConfigurationConstants.MariaDBPassword);

            return string.Format(mariaDbConnectionStringTemplate, mariaDbUserName, mariaDbPassword);
        }
    }
}

using Autofac;
using JACMS.Content.API.Constants;
using JACMS.Content.Core.Repositories.Abstractions;
using JACMS.Content.Infrastructure.MariaDb.Repositories;

namespace JACMS.Content.API.Dependicies.Resolvers
{
    public class RepositoryResolver
    {
        public static Func<IComponentContext, ITextTypeRepository> GetTextTypeRepository = context =>
        {
            string mariaDbConnectionString = GetMariaDbConnectionString(context);
            ITextTypeRepository textTypeRepository = new TextTypeRepository(mariaDbConnectionString);
            return textTypeRepository;
        };

        public static Func<IComponentContext, IDocumentRepository> GetDocumentRepository = context =>
        {
            string mariaDbConnectionString = GetMariaDbConnectionString(context);
            IDocumentRepository documentRepository = new DocumentRepository(mariaDbConnectionString);
            return documentRepository;
        };

        public static Func<IComponentContext, IContentTypeRepository> GetContentTypeRepository = context =>
        {
            string mariaDbConnectionString = GetMariaDbConnectionString(context);
            IContentTypeRepository contentTypeRepository = new ContentTypeRespository(mariaDbConnectionString);
            return contentTypeRepository;
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

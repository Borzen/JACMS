using Autofac;
using JACMS.Content.API.Constants;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Core.Services.Abstractions;
using JACMS.Content.Infrastructure.Mongo.Services;

namespace JACMS.Content.API.Dependicies.Resolvers
{
    public class ServiceResolver
    {
        public static Func<IComponentContext, IMongoService<Page>> ResolvePageMongoService = context =>
        {
            var config = context.Resolve<IConfiguration>();
            string mongoDbConnectionStringTemplate = config.GetConnectionString(ConfigurationConstants.MongoDBConnectionString);
            string mongoDbUserName = config.GetValue<string>(ConfigurationConstants.MongoDBUserName);
            string mongoDbPassword = config.GetValue<string>(ConfigurationConstants.MongoDBPassword);

            string mongoDbConnectionString = string.Format(mongoDbConnectionStringTemplate, mongoDbUserName, mongoDbPassword);

            string mongoDbDatabase = config.GetValue<string>(ConfigurationConstants.MongoDatabase);
            string mongoDbCollection = config.GetValue<string>(ConfigurationConstants.MongoPageCollection);

            IMongoService<Page> pageService = new MongoService<Page>(mongoDbConnectionString, mongoDbDatabase, mongoDbCollection);
            return pageService;
        };
    }
}

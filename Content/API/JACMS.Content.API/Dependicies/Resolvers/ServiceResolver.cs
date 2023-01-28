using Autofac;
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
            string mongoDbConnectionStringTemplate = config.GetConnectionString("");
            string mongoDbUserName = config.GetValue<string>("");
            string mongoDbPassword = config.GetValue<string>("");

            string mongoDbConnectionString = string.Format(mongoDbConnectionStringTemplate, mongoDbUserName, mongoDbPassword);

            string mongoDbDatabase = "";
            string mongoDbCollection = "";

            IMongoService<Page> pageService = new MongoService<Page>(mongoDbConnectionString, mongoDbDatabase, mongoDbCollection);
            return pageService;
        };
    }
}

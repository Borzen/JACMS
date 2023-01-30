using Autofac;
using JACMS.Content.API.Dependicies.Resolvers;
using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Core.Services.Abstractions;
using MediatR;

namespace JACMS.Content.API.Dependicies.Modules
{
    public class JACMSContentAPIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            #region DataServices
            builder.Register(DataServiceResolver.GetContentTypeDataService).As<IContentTypeDataService>();
            #endregion

            #region Services
            builder.Register(ServiceResolver.ResolvePageMongoService).As<IMongoService<Page>>();
            builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });
            #endregion
        }
    }
}

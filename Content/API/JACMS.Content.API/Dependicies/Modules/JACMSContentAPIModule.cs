using Autofac;
using JACMS.Content.API.Dependicies.Resolvers;
using JACMS.Content.CommandHandlers;
using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Core.Repositories.Abstractions;
using JACMS.Content.Core.Services.Abstractions;
using MediatR;

namespace JACMS.Content.API.Dependicies.Modules
{
    public class JACMSContentAPIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            #region Commands
            builder.RegisterType<CreateTextTypeHandler>().AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterType<CreateTextContentHandler>().AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterType<CreateSectionHandler>().AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterType<CreateDocumentHandler>().AsImplementedInterfaces().InstancePerDependency();
            #endregion

            #region DataServices
            builder.Register(DataServiceResolver.GetContentTypeDataService).As<IContentTypeDataService>();
            builder.Register(DataServiceResolver.GetDocumentDataService).As<IDocumentDataService>();
            builder.Register(DataServiceResolver.GetImageContentDataService).As<IImageContentDataService>();
            builder.Register(DataServiceResolver.GetPageDataService).As<IPageDataService>();
            builder.Register(DataServiceResolver.GetSectionDataService).As<ISectionDataService>();
            builder.Register(DataServiceResolver.GetTextContentDataService).As<ITextContentDataService>();
            builder.Register(DataServiceResolver.GetTextTypeDataService).As<ITextTypeDataService>();
            #endregion

            #region Repository
            builder.Register(RepositoryResolver.GetTextTypeRepository).As<ITextTypeRepository>();
            builder.Register(RepositoryResolver.GetDocumentRepository).As<IDocumentRepository>();
            builder.Register(RepositoryResolver.GetContentTypeRepository).As<IDocumentRepository>();
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

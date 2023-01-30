using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Core.Services.Abstractions;
using JACMS.Content.PageBuilder.Dependicies.Resolvers;

namespace JACMS.Content.PageBuilder.Dependicies.Modules
{
    public class PageBuilderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            #region Services
            builder.Register(ServiceResolver.ResolvePageMongoService).As<IMongoService<Page>>();
            #endregion
        }
    }
}

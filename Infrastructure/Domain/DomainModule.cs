using Autofac;
using Infrastructure.Repositories;

namespace Infrastructure.Domain
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitofWork>().As<UnitofWork>().InstancePerLifetimeScope();
        }
    }
}
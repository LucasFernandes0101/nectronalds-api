using Autofac;

namespace NecTronaldsAPI.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            ConfigurationIOC.Load(containerBuilder);
        }
    }
}

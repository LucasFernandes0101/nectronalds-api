using Autofac;
using NecTronaldsAPI.Application;
using NecTronaldsAPI.Application.Interfaces;
using NecTronaldsAPI.Application.Interfaces.Mappers;
using NecTronaldsAPI.Domain.Core.Interfaces.Repositories;
using NecTronaldsAPI.Domain.Core.Interfaces.Services;
using NecTronaldsAPI.Domain.Services;
using NecTronaldsAPI.Infrastructure.Data.Repositories;
using NecTronaldsAPI.Infrastructure.Mappers;

namespace NecTronaldsAPI.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            #region Applications
            builder.RegisterType<ApplicationServiceRestaurante>().As<IApplicationServiceRestaurante>();
            builder.RegisterType<ApplicationServiceLanche>().As<IApplicationServiceLanche>();
            #endregion
            #region Services
            builder.RegisterType<ServiceLanche>().As<IServiceLanche>();
            builder.RegisterType<ServiceRestaurante>().As<IServiceRestaurante>();
            #endregion
            #region Mappers
            builder.RegisterType<MapperLanche>().As<IMapperLanche>();
            builder.RegisterType<MapperRestaurante>().As<IMapperRestaurante>();
            #endregion
            #region Repositories
            builder.RegisterType<RepositoryLanche>().As<IRepositoryLanche>();
            builder.RegisterType<RepositoryRestaurante>().As<IRepositoryRestaurante>();
            #endregion
            #endregion
        }
    }
}

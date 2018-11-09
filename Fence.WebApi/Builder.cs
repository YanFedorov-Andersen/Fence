using Autofac;
using Autofac.Integration.WebApi;
using Fence.DataAccess;
using Fence.DataAccess.Interfaces;
using Fence.Domain;
using System.Reflection;
using System.Web.Http;
using Fence.Business;

namespace Fence.WebApi
{
    public class Builder
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UserStoreProceduresAccess>().As<IUserDataAccess>().SingleInstance();
            builder.RegisterType<MessageStoreProceduresAccess>().As<IMessageDataAccess>().SingleInstance();

            builder.RegisterType<MapMessage>().As<IMapper<MessageEntity, MessageDTO>>().SingleInstance();
            builder.RegisterType<MapUser>().As<IMapper<UserEntity, UserDTO>>().SingleInstance();

            builder.RegisterType<DisplayService>().As<IDisplayService>();

            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            IUserDataAccess userDataAccess = container.Resolve<IUserDataAccess>();
            IMessageDataAccess messageDataAccess = container.Resolve<IMessageDataAccess>();

            IDisplayService displayService = container.Resolve<IDisplayService>();
        }
    }
}
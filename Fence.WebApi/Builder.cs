using Autofac;
using Autofac.Integration.WebApi;
using Fence.DataAccess;
using Fence.DataAccess.Interfaces;
using System.Reflection;

namespace Fence.WebApi
{
    public class Builder
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UserStoreProceduresAccess>().As<IUserDataAccess>().SingleInstance();

            var container = builder.Build();

            IUserDataAccess userDataAccess = container.Resolve<IUserDataAccess>();
        }
    }
}
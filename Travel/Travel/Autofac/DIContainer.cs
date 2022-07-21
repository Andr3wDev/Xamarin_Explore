using Autofac;
using Travel.Interfaces;
using Travel.Services;

namespace Travel.Autofac
{
    public static class DIContainer
    {
        private static IContainer _container;
        public static IMockDbService MockDbService
            => _container.Resolve<IMockDbService>();
        public static INavigationService NavigationService
            => _container.Resolve<INavigationService>();

        public static void Initialize()
        {
            if (_container == null)
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<MockDbService>()
                    .As<IMockDbService>().SingleInstance();
                builder.RegisterType<NavigationService>()
                    .As<INavigationService>().SingleInstance();
                _container = builder.Build();
            }
        }
    }
}

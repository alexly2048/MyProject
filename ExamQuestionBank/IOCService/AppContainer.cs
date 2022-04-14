using Autofac;
using Autofac.Core.Lifetime;

namespace IOCService.Service
{
    public class AppContainer
    {
        private static IContainer container;
        public static IContainer Container
        {
            get { return container; }
            set { container = value; }
        }

        public static T Resolve<T>(ILifetimeScope scope = null)
        {
            if(scope == null)
            {
                scope = container.BeginLifetimeScope(MatchingScopeLifetimeTags.RequestLifetimeScopeTag);
            }
               return scope.Resolve<T>();            
        }
    }
}

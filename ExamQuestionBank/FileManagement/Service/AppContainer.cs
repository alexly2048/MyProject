using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Core.Lifetime;

namespace FileManagement.Service
{
    public class AppContainer
    {
        private static IContainer container;
        public static IContainer Container
        {
            get { return container; }
            set { container = value; }
        }

        public static T Resove<T>(ILifetimeScope scope = null)
        {
            if(scope == null)
            {
                scope = container.BeginLifetimeScope(MatchingScopeLifetimeTags.RequestLifetimeScopeTag);
            }
               return scope.Resolve<T>();            
        }
    }
}

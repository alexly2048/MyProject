using Autofac;
using FileManagement.Service.DataService;
using FileManagement.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Service.BaseService
{
    public partial  class RegisterService
    {
        private RegisterService()
        {

        }
        private static ContainerBuilder builder = new ContainerBuilder();
        public static void Register()
        {
            builder.RegisterType<DatabaseService>().As<IDatabaseService>().SingleInstance();
            builder.RegisterType<ProjectContractService>().SingleInstance();
            builder.RegisterType<CurrentExpenseService>().SingleInstance();
            builder.RegisterType<ConstructionCostService>().SingleInstance();
            builder.RegisterType<ClientService>().SingleInstance();
            

            builder.RegisterType<FrmBase>().InstancePerLifetimeScope();
            builder.RegisterType<FrmContract>().InstancePerLifetimeScope();
            builder.RegisterType<FrmEditProjectContract>().InstancePerLifetimeScope();
            builder.RegisterType<FrmConstructionCost>().InstancePerLifetimeScope();
            builder.RegisterType<FrmEditConstructionCost>().InstancePerLifetimeScope();
            builder.RegisterType<FrmClient>().InstancePerLifetimeScope();
            builder.RegisterType<FrmEditClient>().InstancePerLifetimeScope();
            builder.RegisterType<FrmCurrentExpense>().InstancePerLifetimeScope();
            builder.RegisterType<FrmEditCurrentExpense>().InstancePerLifetimeScope();
            AppContainer.Container = builder.Build();
        }
    }
}

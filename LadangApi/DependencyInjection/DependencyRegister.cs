using Autofac;
using LadangApi.Data;
using LadangApi.Interface;

namespace LadangApi.DependencyInjection
{
    public class DependencyRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PlantationDbContext>().As<IPlantationDbContext>();
        }
    }
}
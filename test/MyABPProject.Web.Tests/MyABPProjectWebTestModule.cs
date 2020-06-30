using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPProject.Web.Startup;
namespace MyABPProject.Web.Tests
{
    [DependsOn(
        typeof(MyABPProjectWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyABPProjectWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPProjectWebTestModule).GetAssembly());
        }
    }
}
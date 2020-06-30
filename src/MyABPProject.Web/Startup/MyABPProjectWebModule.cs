using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPProject.Configuration;
using MyABPProject.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace MyABPProject.Web.Startup
{
    [DependsOn(
        typeof(MyABPProjectApplicationModule), 
        typeof(MyABPProjectEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyABPProjectWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyABPProjectWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyABPProjectConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyABPProjectNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyABPProjectApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPProjectWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyABPProjectWebModule).Assembly);
        }
    }
}
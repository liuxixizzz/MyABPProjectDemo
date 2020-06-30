using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPProject.Localization;

namespace MyABPProject
{
    public class MyABPProjectCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyABPProjectLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPProjectCoreModule).GetAssembly());
        }
    }
}
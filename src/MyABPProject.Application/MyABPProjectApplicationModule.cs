using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyABPProject
{
    [DependsOn(
        typeof(MyABPProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyABPProjectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPProjectApplicationModule).GetAssembly());
        }
    }
}
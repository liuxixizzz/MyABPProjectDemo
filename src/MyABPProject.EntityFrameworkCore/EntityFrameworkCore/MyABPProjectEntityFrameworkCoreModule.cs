using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyABPProject.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyABPProjectCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyABPProjectEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPProjectEntityFrameworkCoreModule).GetAssembly());
        }
    }
}
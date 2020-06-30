using Abp.Application.Services;

namespace MyABPProject
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyABPProjectAppServiceBase : ApplicationService
    {
        protected MyABPProjectAppServiceBase()
        {
            LocalizationSourceName = MyABPProjectConsts.LocalizationSourceName;
        }
    }
}
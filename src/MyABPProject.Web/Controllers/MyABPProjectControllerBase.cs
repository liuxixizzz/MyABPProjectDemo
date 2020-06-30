using Abp.AspNetCore.Mvc.Controllers;

namespace MyABPProject.Web.Controllers
{
    public abstract class MyABPProjectControllerBase: AbpController
    {
        protected MyABPProjectControllerBase()
        {
            LocalizationSourceName = MyABPProjectConsts.LocalizationSourceName;
        }
    }
}
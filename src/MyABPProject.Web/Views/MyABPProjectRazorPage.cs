using Abp.AspNetCore.Mvc.Views;

namespace MyABPProject.Web.Views
{
    public abstract class MyABPProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyABPProjectRazorPage()
        {
            LocalizationSourceName = MyABPProjectConsts.LocalizationSourceName;
        }
    }
}

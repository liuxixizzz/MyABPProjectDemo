using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyABPProject.EntityFrameworkCore;
using MyABPProject.Tests.TestDatas;

namespace MyABPProject.Tests
{
    public class MyABPProjectTestBase : AbpIntegratedTestBase<MyABPProjectTestModule>
    {
        public MyABPProjectTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyABPProjectDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyABPProjectDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyABPProjectDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyABPProjectDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyABPProjectDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyABPProjectDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyABPProjectDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyABPProjectDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}

using MyABPProject.Configuration;
using MyABPProject.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyABPProject.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyABPProjectDbContextFactory : IDesignTimeDbContextFactory<MyABPProjectDbContext>
    {
        public MyABPProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyABPProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyABPProjectConsts.ConnectionStringName)
            );

            return new MyABPProjectDbContext(builder.Options);
        }
    }
}
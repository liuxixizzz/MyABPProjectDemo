using Microsoft.EntityFrameworkCore;

namespace MyABPProject.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyABPProjectDbContext> dbContextOptions,
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyABPProjectDbContext */
            dbContextOptions.UseMySql(connectionString);
        }
    }
}

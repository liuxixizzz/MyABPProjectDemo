using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyABPProject.Tasks;

namespace MyABPProject.EntityFrameworkCore
{
    public class MyABPProjectDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Task> Tasks { get; set; }

        public MyABPProjectDbContext(DbContextOptions<MyABPProjectDbContext> options) 
            : base(options)
        {

        }
    }
}

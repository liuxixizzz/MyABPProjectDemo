using MyABPProject.EntityFrameworkCore;

namespace MyABPProject.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyABPProjectDbContext _context;

        public TestDataBuilder(MyABPProjectDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}
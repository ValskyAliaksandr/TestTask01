using Microsoft.EntityFrameworkCore;
using TestTask01.Models;
namespace TestTask01.Data
{
    public class TestTask01DB:DbContext
    {
        public DbSet<Polzovatel> Polzovatels { get; set; }
        public DbSet<Controgent> Controgents { get; set; }

        public TestTask01DB(DbContextOptions<TestTask01DB> options) : base(options)
        { 
        }
    }
}

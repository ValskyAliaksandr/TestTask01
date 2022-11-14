using Microsoft.EntityFrameworkCore;
using TestTask01.Models;
namespace TestTask01.Data
{
    public class TestTask01DB: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Polzovatel> Polzovatels { get; set; }
        public DbSet<Controgent> Controgents { get; set; }
        public DbSet<OrderControgent> OrderControgents { get; set; }

        public TestTask01DB(DbContextOptions<TestTask01DB> options) : base(options)
        { 
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace TestingConnectionWithPostgre.Models
{
    public class MyWebApiContext : DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}

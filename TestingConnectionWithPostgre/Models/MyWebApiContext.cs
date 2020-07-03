using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

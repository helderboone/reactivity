using Microsoft.EntityFrameworkCore;
using domain;

namespace persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}
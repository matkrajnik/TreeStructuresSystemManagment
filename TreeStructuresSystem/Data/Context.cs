using Microsoft.EntityFrameworkCore;
using TreeStructuresSystem.Models;

namespace TreeStructuresSystem.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Node> Nodes { get; set; }
    }
}

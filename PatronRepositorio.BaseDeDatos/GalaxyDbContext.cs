using Microsoft.EntityFrameworkCore;
using PatronRepositorio.Entities;

namespace PatronRepositorio.BaseDeDatos
{
    public class GalaxyDbContext : DbContext
    {
        public GalaxyDbContext(DbContextOptions<GalaxyDbContext> options)
        : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; } = default!;
    }
}
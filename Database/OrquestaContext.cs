using Microsoft.EntityFrameworkCore;
using orquesta_server.Models;

namespace orquesta_server.Database
{
  public class OrquestaContext : DbContext
  {
    public DbSet<Instrumento> Instrumentos { get; set; }
    public DbSet<Musico> Musicos { get; set; }
    public OrquestaContext(DbContextOptions<OrquestaContext> options) : base(options) {}
  }
}

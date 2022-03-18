using Microsoft.EntityFrameworkCore;

namespace CRUDVACUNACIONT8.Data
{
    public class CrudDbContext : DbContext
    {
        public DbSet<Provincias>? Provincias { get; set; }
        public DbSet<VacunasRecibidas>? Vacunas { get; set; }
        public DbSet<Personas>? Personas { get; set; }
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options) { }
    }
}

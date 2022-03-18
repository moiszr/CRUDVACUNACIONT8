using Microsoft.EntityFrameworkCore;

namespace CRUDVACUNACIONT8.Data
{
    public class CrudDbContext : DbContext
    {
        public DbSet<Provincias> Provincias { get; set; } = default!;
        public DbSet<VacunasRecibidas> Vacunas { get; set; } = default!;
        public DbSet<Personas> Personas { get; set; } = default!;
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options) { }
    }
}

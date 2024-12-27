using Microsoft.EntityFrameworkCore;
using minicoreback.Models;

namespace minicoreback.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; } = null!;
        public DbSet<Departamento> Departamentos { get; set; } = null!;
        public DbSet<Gasto> Gastos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración adicional (opcional)
            modelBuilder.Entity<Empleado>().ToTable("Empleados");
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
            modelBuilder.Entity<Gasto>().ToTable("Gastos");
        }
    }
}

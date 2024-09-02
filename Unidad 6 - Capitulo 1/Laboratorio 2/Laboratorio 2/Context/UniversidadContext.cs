using Laboratorio_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Laboratorio_2.Context
{
    public class UniversidadContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }

        //public UniversidadContext(DbContextOptions<UniversidadContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Universidad3;Integrated Security=true");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        public UniversidadContext()
        {
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }
    }
}

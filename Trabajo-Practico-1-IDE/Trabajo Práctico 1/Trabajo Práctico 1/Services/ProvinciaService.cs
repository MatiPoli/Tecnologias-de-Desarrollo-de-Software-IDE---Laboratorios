using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Trabajo_Práctico_1.Model;

namespace Trabajo_Práctico_1.Services
{
    internal class ProvinciaContext : DbContext
    {
        public DbSet<Provincia> Provincias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Universidad;Integrated Security=true");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        public ProvinciaContext()
        {
            this.Database.EnsureCreated();
        }

    }

    public class ProvinciaService
    {
        public IEnumerable<Provincia> GetAll()
        {
            using ProvinciaContext context = new ProvinciaContext();

            return context.Provincias.ToList();
        }

        public Provincia Get(int Id)
        {
            using ProvinciaContext context = new ProvinciaContext();
            Provincia provincia = context.Provincias.Find(Id);
            return provincia;
        }

        public void Add(Provincia provincia)
        {
            using ProvinciaContext context = new ProvinciaContext();

            context.Provincias.Add(provincia);
            context.SaveChanges();
        }

        public void Update(Provincia provincia)
        {
            using ProvinciaContext context = new ProvinciaContext();

            Provincia provinciaActualizar = context.Provincias.Find(provincia.Id);

            if (provincia != null)
            {
                provinciaActualizar.Nombre = provincia.Nombre;
                context.SaveChanges();
            }
        }

        public void Remove(int Id)
        {
            using ProvinciaContext context = new ProvinciaContext();

            Provincia provincia = context.Provincias.Find(Id);

            if (provincia != null)
            {
                context.Provincias.Remove(provincia);
                context.SaveChanges();
            }
        }

    }
}

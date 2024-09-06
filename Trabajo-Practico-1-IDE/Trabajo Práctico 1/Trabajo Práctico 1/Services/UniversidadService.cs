using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Trabajo_Práctico_1.Model;



namespace Trabajo_Práctico_1.Services
{
    internal class UniversidadContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Universidad;Integrated Security=true");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        public UniversidadContext()
        {
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }

    }

    public class UniversidadService
    {
        public IEnumerable<Alumno> GetAll()
        {
            using UniversidadContext context = new UniversidadContext();

            return context.Alumnos.ToList();
        }

        public Alumno Get(int Id)
        {
            using UniversidadContext context = new UniversidadContext();
            Alumno alumno = context.Alumnos.Find(Id);
            return alumno;
        }

        public void Add(Alumno alumno)
        {
            using UniversidadContext context = new UniversidadContext();

            context.Alumnos.Add(alumno);
            context.SaveChanges();
        }

        public void Update(Alumno alumno)
        {
            using UniversidadContext context = new UniversidadContext();

            Alumno alumnoActualizar = context.Alumnos.Find(alumno.Id);

            if (alumno != null)
            {
                alumnoActualizar.Nombre = alumno.Nombre;
                alumnoActualizar.Apellido = alumno.Apellido;
                alumnoActualizar.Legajo = alumno.Legajo;
                alumnoActualizar.Direccion = alumno.Direccion;
                context.SaveChanges();
            }
        }

        public void Remove(int Id)
        {
            using UniversidadContext context = new UniversidadContext();

            Alumno alumno = context.Alumnos.Find(Id);

            if (alumno != null)
            {
                context.Alumnos.Remove(alumno);
                context.SaveChanges();
            }
        }

    }
}
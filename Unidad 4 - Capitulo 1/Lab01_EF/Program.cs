using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

Universidad universidad = new Universidad();
universidad.Crear();

public class Alumno
{
    public int Id { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public int Legajo { get; set; }
    public string Direccion { get; set; }


}

public class UniversidadContext : DbContext
{
    public DbSet<Alumno> Alumnos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Universidad;Integrated Security=true");
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }

    public UniversidadContext()
    {
        this.Database.EnsureCreated();
    }


}

public class Universidad
{
    public void Crear()
    {
        using UniversidadContext context = new UniversidadContext();
        Alumno alumno = new Alumno();
        //Console.Write("Ingrese id: ");
        //alumno.Id = Int32.Parse(Console.ReadLine());
        Console.Write("Ingrese apellido: ");
        alumno.Apellido = Console.ReadLine();
        Console.Write("Ingrese nombre: ");
        alumno.Nombre = Console.ReadLine();
        Console.Write("Ingrese legajo: ");
        alumno.Legajo = Int32.Parse(Console.ReadLine());
        Console.Write("Ingrese direccion: ");
        alumno.Direccion = Console.ReadLine();

        context.Alumnos.Add(alumno);
        context.SaveChanges();
    }

    public void Leer()
    {
        using UniversidadContext context = new UniversidadContext();
        Console.Write("Ingrese el nombre a buscar: ");
        string nom = Console.ReadLine();
        var alumno = context.Alumnos.FirstOrDefault(u => u.Nombre == nom);
        
        if (alumno == null)
        {
            Console.WriteLine("No se encontro");
        }
        else
        {
            Console.WriteLine("Usuario encontrado:");
            Console.WriteLine(alumno.Nombre + " " + alumno.Apellido );
        }
    }

    public void Actualizar()
    {
        using UniversidadContext context = new UniversidadContext();

        Console.Write("Ingrese id: ");
        int idAlumno = Int32.Parse(Console.ReadLine());
        Alumno alumno = context.Alumnos.Find(idAlumno);

        if (alumno != null) 
        {
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("Usuario no encontrado");
        }
    }

    public void Eliminar()
    {
        using UniversidadContext context = new UniversidadContext();

        Console.Write("Ingrese id: ");
        int idAlumno = Int32.Parse(Console.ReadLine());
        Alumno alumno = context.Alumnos.Find(idAlumno);

        if (alumno != null)
        {
            context.Alumnos.Remove(alumno);
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("Usuario no encontrado");
        }
    }

}
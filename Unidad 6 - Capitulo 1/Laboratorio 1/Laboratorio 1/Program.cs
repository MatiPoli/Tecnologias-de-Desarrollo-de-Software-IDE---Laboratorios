using Backend.Context;
using Backend.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UniversidadContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/alumnos", async (UniversidadContext context) =>
    await context.Alumnos.ToListAsync() is List<Alumno> alumnos
        ? Results.Ok(alumnos)
        : Results.NotFound());

app.MapGet("/alumnos/{id}", async (int id, UniversidadContext context) =>
    await context.Alumnos.FindAsync(id) is Alumno alumno
        ? Results.Ok(alumno)
        : Results.NotFound());

app.MapPost("/alumnos", async (Alumno alumno, UniversidadContext context) =>
{
    context.Alumnos.Add(alumno);
    await context.SaveChangesAsync();

    return Results.Created($"/alumnos/{alumno.Id}", alumno);
});

app.MapPut("/alumnos/{id}", async (int id, Alumno updatedAlumno, UniversidadContext context) =>
{
    var alumno = await context.Alumnos.FindAsync(id);
    if (alumno is null)
    {
        return Results.NotFound();
    }
    alumno.Apellido = updatedAlumno.Apellido;
    alumno.Nombre = updatedAlumno.Nombre;
    alumno.Legajo = updatedAlumno.Legajo;
    alumno.Direccion = updatedAlumno.Direccion;

    await context.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/alumnos/{id}", async (int id, UniversidadContext context) =>
{
    var alumno = await context.Alumnos.FindAsync(id);
    if (alumno is null)
    {
        return Results.NotFound();
    }

    context.Alumnos.Remove(alumno);
    await context.SaveChangesAsync();

    return Results.NoContent(); 
});


app.UseSwagger();
app.UseSwaggerUI();
app.Run();

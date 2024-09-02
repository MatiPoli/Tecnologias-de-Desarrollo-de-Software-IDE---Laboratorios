using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Laboratorio_2.Context;
using Laboratorio_2.Models;

namespace Laboratorio_2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnoController : ControllerBase
    {
        private readonly UniversidadContext _context;

        public AlumnoController(UniversidadContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetAlumno")]
        public ActionResult<IEnumerable<Alumno>> GetAll() 
        {
            return _context.Alumnos.ToList();
        }

        [HttpGet("{DNI}")]
        public ActionResult<Alumno> GetById(string DNI) 
        {
            var alumno = _context.Alumnos.Find(DNI);
            if (alumno == null) {
                return NotFound();
            }
            return alumno;
        }

        [HttpPost]
        public ActionResult<Alumno> Create(Alumno alumno) 
        {
            _context.Alumnos.Add(alumno);
            _context.SaveChanges();
            return CreatedAtRoute("GetById", new { DNI = alumno.DNI }, alumno);
        }

        [HttpPut("{DNI}", Name = "GetById")]
        public ActionResult Update(string DNI, Alumno alumno) 
        {
            if (DNI != alumno.DNI) {
                return BadRequest();
            }
            _context.Entry(alumno).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{DNI}")]
        public ActionResult<Alumno> Delete(string DNI) 
        {
            var alumno = _context.Alumnos.Find(DNI);
            if (alumno == null) {
                return NotFound();
            }
            _context.Alumnos.Remove(alumno);
            _context.SaveChanges();
            return alumno;
        }
    }
}

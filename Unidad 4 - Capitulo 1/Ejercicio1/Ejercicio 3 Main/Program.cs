using Ejercicio3;
dsUniversidad miUniversidad = new dsUniversidad();

dsUniversidad.dtAlumnosDataTable dtAlumnos = new dsUniversidad.dtAlumnosDataTable();
dsUniversidad.dtCursosDataTable dtCursos = new dsUniversidad.dtCursosDataTable();

rowAlumno.Apellido = "Perez";
rowAlumno.Nombre = "Juan";
dtAlumnos.AdddtAlumnosRow(rowAlumno);
dsUniversidad miUniversidad = new dsUniversidad();

dsUniversidad.dtAlumnosDataTable dtAlumnos = new dsUniversidad.dtAlumnosDataTable();
dsUniversidad.dtCursosDataTable dtCursos = new dsUniversidad.dtCursosDataTable();
dsUniversidad.dtAlumnosRow rowAlumno = dtAlumnos.NewdtAlumnosRow();

rowAlumno.Apellido = "Perez";
rowAlumno.Nombre = "Juan";
dtAlumnos.AdddtAlumnosRow(rowAlumno);

dtUniversidad.dtCursosRow rowCurso = dtCursos.NewdtCursosRow();
rowCurso.Curso = "Informatica";
dtCursos.AdddtCursosRow(rowCurso);

dsUniversidad.dtAlumnos_CursosDataTable dtAlumnos_Cursos = newdsUniversidad.dtAlumnos_CursosDataTable();

dsUniversidad.dtAlumnos_CursosRow = rowAlumnosCursos = dtAlumnos_Cursos.NewdtAlumnosRow();

dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno, rowCurso);

rowAlumno = dtAlumnos.NewdtAlumnosRow();
rowAlumno.Nombre = "Marcelo";
rowAlumno.Apellido = "Perez";
dtAlumnos.AdddtAlumnosRow(rowAlumno);

dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno, rowCurso);
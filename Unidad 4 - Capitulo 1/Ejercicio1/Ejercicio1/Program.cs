using System.Data;
using System.Data.SqlClient;

DataTable dtAlumnos = new DataTable();

DataColumn colIDAlumno = new DataColumn("IDAlumno", typeof(int));
colIDAlumno.ReadOnly = true;
colIDAlumno.AutoIncrement = true;
colIDAlumno.AutoIncrementSeed = 0;
colIDAlumno.AutoIncrementStep = 1;

DataColumn colNombre = new DataColumn("Nombre", typeof(string));
DataColumn colApellido = new DataColumn("Apellido", typeof(string));

dtAlumnos.Columns.Add(colIDAlumno);
dtAlumnos.Columns.Add(colNombre);
dtAlumnos.Columns.Add(colApellido);

dtAlumnos.PrimaryKey = new DataColumn[] { colIDAlumno };

DataRow rwalumno = dtAlumnos.NewRow();
rwalumno[colApellido] = "Chiplote";
rwalumno[colNombre] = "Cachin";
dtAlumnos.Rows.Add(rwalumno);

DataRow rwAlumno2 = dtAlumnos.NewRow();
rwAlumno2["Apellido"] = "Ho";
rwAlumno2["Nombre"] = "Zung";
dtAlumnos.Rows.Add(rwAlumno2);

DataRow rwAlumno3 = dtAlumnos.NewRow();
rwAlumno3["Apellido"] = "Jodoy";
rwAlumno3["Nombre"] = "Marjitos";
dtAlumnos.Rows.Add(rwAlumno3);


DataTable dtCursos = new DataTable();

DataColumn colIDCurso = new DataColumn("IDCurso", typeof(int));
colIDCurso.ReadOnly = true;
colIDCurso.AutoIncrement = true;
colIDCurso.AutoIncrementSeed = 0;
colIDCurso.AutoIncrementStep = 1;
DataColumn colCurso = new DataColumn("Curso", typeof (string));

dtCursos.Columns.Add(colIDCurso);
dtCursos.Columns.Add(colCurso);

dtCursos.PrimaryKey = new DataColumn[] { colIDCurso };

DataRow rwCurso = dtCursos.NewRow();
rwCurso[colCurso] = "Informatica";
dtCursos.Rows.Add(rwCurso);


DataSet dsUniversidad = new DataSet();
dsUniversidad.Tables.Add(dtAlumnos);
dsUniversidad.Tables.Add(dtCursos);
dsUniversidad.EnforceConstraints = false;


DataTable dtAlumnos_Cursos = new DataTable("Alumnos_Cursos");
DataColumn col_ac_IDAlumno = new DataColumn("IDAlumno", typeof(int));
DataColumn col_ac_IDCurso = new DataColumn("IDCurso", typeof(int));
dtAlumnos_Cursos.Columns.Add(col_ac_IDAlumno);
dtAlumnos_Cursos.Columns.Add(col_ac_IDCurso);

dsUniversidad.Tables.Add(dtAlumnos_Cursos);


DataRelation relAlumno_ac = new DataRelation("Alumno_Cursos", colIDAlumno, col_ac_IDAlumno);
DataRelation relCurso_ac = new DataRelation("Cursos_Alumnos", colIDCurso, col_ac_IDCurso);
dsUniversidad.Relations.Add(relAlumno_ac);
dsUniversidad.Relations.Add(relCurso_ac);

DataRow rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
rwAlumnosCursos[col_ac_IDAlumno] = 0;
rwAlumnosCursos[col_ac_IDCurso] = 1;
dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
rwAlumnosCursos[col_ac_IDAlumno] = 1;
rwAlumnosCursos[col_ac_IDCurso] = 1;
dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
rwAlumnosCursos[col_ac_IDAlumno] = 2;
rwAlumnosCursos[col_ac_IDCurso] = 1;
dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);


Console.Write("Ingrese el nombre del curso: ");
string curso = Console.ReadLine();

Console.WriteLine("Listado de Alumnos del curso " + curso);
DataRow[] row_CursoInf = dtCursos.Select("Curso = '" + curso + "'");
foreach (DataRow rowCu in row_CursoInf)
{
    DataRow[] row_AlumnosInf = rowCu.GetChildRows(relCurso_ac);
    foreach (DataRow rowAl in row_AlumnosInf)
    {
        Console.WriteLine(rowAl.GetParentRow(relAlumno_ac)[colApellido].ToString() + ',' + rowAl.GetParentRow(relAlumno_ac)[colNombre].ToString());
    }
}
Console.ReadLine();

//Console.WriteLine("Lisatado de alumnos:");
//foreach (DataRow row in dtAlumnos.Rows)
//{
//    Console.WriteLine(row[colApellido].ToString() + ", " + row[colNombre].ToString());
//}
//Console.ReadLine();
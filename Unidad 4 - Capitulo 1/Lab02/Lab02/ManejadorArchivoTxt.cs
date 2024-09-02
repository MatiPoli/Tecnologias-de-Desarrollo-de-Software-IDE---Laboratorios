using System.Data;
using System.Data.OleDb;

namespace Lab02
{
    public class ManejadorArchivoTxt: ManejadorArchivo
    {
        protected string connectionString
        {
            get
            {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Proyectos\Unidades\Unidad 04\Lab02\Lab02\bin\Debug;" + "Extended Properties='text;HDR=Yes;FMT=Delimited'";
            }
        }

        public override DataTable getTable()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdSelect = new OleDbCommand("select * from agenda.txt", Conn);
                Conn.Open();
                OleDbDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new DataTable();
                if (reader != NULL)
                {
                    contactos.Load(reader);
                }
                Conn.Close();
                return contactos;
            }
        }

        public override void aplicaCambios()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdInsert = new OleDbCommand("insert into agenda.txt values(@id,@nombre,@apellido,@email,@telefono)", Conn);
                cmdInsert.Parameters.Add("@id", OleDbType.Integer);
                cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@email", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdUpdate = new OleDbCommand("update agenda.txt set nombre=@nombre, apellido=@apellido, e-mail=@email, telefono=@telefono where id=@id", Conn);
                cmdUpdate.Parameters.Add("@id", OleDbType.Integer);
                cmdUpdate.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdDelete = new OleDbCommand("delete from agenda.txt where id=@id", Conn);
                cmdDelete.Parameters.Add("@id", OleDbType.Integer);

                DataTable filasNuevas = this.contactos.GetChanges(DataRowState.Added);
                DataTable filasBorradas = this.contactos.GetChanges(DataRowState.Deleted);
                DataTable filasModificadas = this.contactos.GetChanges(DataRowState.Modified);

                Conn.Open();

                if (filasNuevas != null)
                {
                    foreach (DataRow row in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters.Add["@id"].Value = row["id"];
                        cmdInsert.Parameters.Add["@nombre"].Value = row["nombre"];
                        cmdInsert.Parameters.Add["@apellido"].Value = row["apellido"];
                        cmdInsert.Parameters.Add["@email"].Value = row["e-mail"];
                        cmdInsert.Parameters.Add["@telefono"].Value = row["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                if (filasBorradas != null)
                {
                    foreach (DataRow row in filasBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = row["id", DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }

                if(filasModificadas != null)
                {
                    foreach (DataRow row in filasModificadas.Rows)
                    {
                        cmdUpdate.Parameters.Add["@id"].Value = row["id"];
                        cmdUpdate.Parameters.Add["@nombre"].Value = row["nombre"];
                        cmdUpdate.Parameters.Add["@apellido"].Value = row["apellido"];
                        cmdUpdate.Parameters.Add["@email"].Value = row["e-mail"];
                        cmdUpdate.Parameters.Add["@telefono"].Value = row["telefono"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}

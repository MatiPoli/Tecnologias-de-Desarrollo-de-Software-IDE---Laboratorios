using System.Data;

namespace Lab02
{
    public class ManejadorArchivo
    {
        protected DataTable contactos;

        public ManejadorArchivo()
        {
            this.contactos = this.getTable();
        }

        public virtual DataTable getTable()
        {
            return new DataTable();
        }

        public virtual void aplicaCambios()
        {

        }

        public void listar()
        {
            foreach (DataRow fila in this.contactos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    foreach (DataColumn col in this.contactos.Columns)
                    {
                        Console.WriteLine("{0}: {1}", col.ColumnName, fila[col]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void nuevaFila()
        {
            DataRow fila = this.contactos.NewRow();
            foreach (DataColumn col in this.contactos.Columns)
            {
                Console.Write("Ingrese {0}:", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
            this.contactos.Rows.Add(fila);
        }

        public void editarFila()
        {
            Console.Write("Ingrese el numero de fila a editar: ");
            int nroFila = int.Parse(Console.ReadLine());
            DataRow fila = this.contactos.Rows[nroFila - 1];
            for (int nroCol = 1; nroCol < this.contactos.Columns.Count; nroCol++)
            {
                DataColumn col = this.contactos.Columns[nroCol];
                Console.Write("Ingrese {0}:", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
        }

        public void eliminarFila()
        {
            Console.Write("Ingrese el numero de fila a eliminar: ");
            int fila = int.Parse(Console.ReadLine());
            this.contactos.Rows[fila - 1].Delete();
        }
    }
}

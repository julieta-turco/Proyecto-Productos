using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    class DatosConexion
    {
        protected OleDbConnection conexion;
        protected string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\juli_\source\repos\proyecto\DB_producto.accdb";
        public DatosConexion()
        {
            conexion = new OleDbConnection(CadenaConexion);
        }
        // Y los métodos para abrir y cerrar la Conexión
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}

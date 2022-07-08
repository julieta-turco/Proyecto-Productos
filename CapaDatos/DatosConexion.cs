using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class DatosConexion
    {
        protected OleDbConnection conexion;
        protected string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\juli_\source\repos\proyecto\DB_producto.accdb";

        #region contructor
        public DatosConexion()
        {
            conexion = new OleDbConnection(cadenaConexion);
            //aqui se crea una conexion con la cadena
        }
        #endregion
        #region metodo
        public void Abrirconexion()
        {
            try
            {
                //aqui abre la conexion si es estado esta roto o cerrado.
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
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
        #endregion
    }
}

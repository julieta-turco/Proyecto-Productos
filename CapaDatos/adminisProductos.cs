using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using entidades;

namespace CapaDatos
{
   public class AdminisProductos : DatosConexion
    {
        public int abmProductos (string accion, producto objProductos)
        {
            int resultado = -1;
            string orden = string.Empty;
           
            if (accion == "Alta")
                orden = "insert into productos values (" + objProductos.P_Codigo +
                ",'" + objProductos.P_Descripcion+ "', "+objProductos.P_Stock + ");";
            if (accion == "Modificar")
                orden = "update productos set descripcion='" + objProductos.P_Descripcion +
                    "', stock=" + objProductos.P_Stock + "where codigo = "+ objProductos.P_Codigo + "; ";
            if (accion == "Borrar")
                orden = "delete productos get codigo'" + objProductos.P_Codigo + ",'" +
                    objProductos.P_Descripcion + ",'" + objProductos.P_Stock + ");";

        
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception ("Error al tratar de guardar,borrar o modificar de productos ",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

   
        }
        public DataSet listadoProductos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Profesionales where CodProf = " + int.Parse(cual) + ";";
            else
                orden = "select * from Profesionales;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }

}

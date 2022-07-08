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
        public int abmProductos(string accion, producto objProducto)
        {
            int resultado = -1;//controla que se realiza la operacion con exito
            string orden = string.Empty;//guarda consulta SQL

            if (accion == "Alta")
                orden = "insert into producto values (" + objProducto.P_Codigo +
                ",'" + objProducto.P_Descripcion + objProducto.P_Stock + "');";

            if (accion == "Modificar")
                orden = "update producto set descripcion='" + objProducto.P_Descripcion +
                    ", stock=" + objProducto.P_Stock + "'where codigo = " + objProducto.P_Codigo + "; ";

            if (accion == "Borrar")
                orden = "delete from producto where codigo" + objProducto.P_Codigo;
            // falta la orden de borrar

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de productos ", e);
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
                orden = "Select * from productos where codigo =" + int.Parse(cual) + ";";
            else
                orden = "Select * from productos";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand=cmd;
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
   
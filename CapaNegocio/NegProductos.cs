using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using entidades;

namespace CapaNegocio
{
    public class NegProductos
    {
        AdminisProductos objDatosPrd = new CapaDatos.AdminisProductos();
        public int abmProductos(string accion, producto objProductos)
        {
            return objDatosPrd.abmProductos(accion, objProductos);
        }
        public DataSet listadoproductos(string cual)
        {
            return objDatosPrd.listadoProductos(cual);
        }
    }
}

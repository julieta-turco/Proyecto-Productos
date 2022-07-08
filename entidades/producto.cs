using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class producto
    {
        #region Atributos
        private
        int codigo;
        string descripcion;
        int stock;
        #endregion

        #region propiedades
        public int P_Codigo
        {
            set { codigo = value; }
            get { return codigo; }
           
        }
        public string P_Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; } 

        }
        public int P_Stock
        {
            get { return stock; }

        }
        #endregion

        #region contructores
        public producto()
        {
        }
        //este contructor sirve para inicializar los objetos. uno por defecto, el otro con parametros
        public producto (int cod, string desc)
        {
            codigo = cod;
            descripcion = desc;
            stock = 0; //empieza en cero para ingresar un producto nuevo.
        }

        public producto(int cod, string desc, int cant)
        {
            codigo = cod;
            descripcion = desc;
            stock = cant;
        }
        #endregion

        #region Metodos
        //metodo de manejo de entradas y salidas del stock
        public void Ingreso(int cant)
        {
            stock += cant; 
        }
        public void Salida(int cant)
        {
            stock -= cant;
        }
        #endregion
    }

}
 
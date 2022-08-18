using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;

namespace WindowsFormsProductos
{
    public partial class formproductos : Form
    {
        public formproductos()
        {
            InitializeComponent();
            CrearDgv();
        }
        private void CrearDgv()
        {
            //no es necesario
            Dgv_productos.Columns.Add("0", "Código");
            Dgv_productos.Columns.Add("1", "Descripción");
            Dgv_productos.Columns.Add("2", "Stock");
            Dgv_productos.Columns[0].Width = 100;
            Dgv_productos.Columns[1].Width = 300;
            Dgv_productos.Columns[2].Width = 60;
        }
        private void cargar_Click(object sender, EventArgs e)
        {
            producto NuevoProducto;
            //instanciamos utilizando el constructor con parametros.
            NuevoProducto = new producto(int.Parse(codigo.Text), descripcion.Text);
            lbl_codigomov.Text = NuevoProducto.P_Codigo.ToString();
            lbl_codigodesc.Text = NuevoProducto.P_Descripcion;
            lbl_stock.Text = "HAY " + NuevoProducto.P_Stock.ToString() + "UNIDADES";

            //A PARTIR DE ACA NO ENTIENDO QUE HACE ESTE METODO.
            tabControl1.SelectedTab = tabPageMov;
            textBoxCantidad.Clear();
            textBoxCantidad.Focus();
            LlevarProdAldgv(NuevoProducto);
            //nuevo = true;
            //MessageBox.Show = "producto instanciado";
        }
        private void LlevarProdAldgv(producto Prod)
        {
            Dgv_productos.Rows.Add(Prod.P_Codigo.ToString(), Prod.P_Descripcion, Prod.P_Stock.ToString());
            //fila = (Dgv_productos.Rows.Count - 1);
        }

        private void aceptar_Click(object sender, EventArgs e)
        {

        }

        private void formproductos_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        producto NuevoProducto;
        producto ProdExistente;
        bool nuevo = true;
        int fila;

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
            //producto NuevoProducto;
            //instanciamos utilizando el constructor con parametros.
            NuevoProducto = new producto(int.Parse(textBoxCod.Text), textBoxDesc.Text);
            lbl_codigomov.Text = NuevoProducto.P_Codigo.ToString();
            lbl_descmov.Text = NuevoProducto.P_Descripcion;
            lbl_stock.Text = "HAY " + NuevoProducto.P_Stock.ToString() + "UNIDADES";

            tabControl1.SelectedTab = tabPageMov;
            textBoxCantidad.Clear();
            textBoxCantidad.Focus();
        }
       
    void LlevarProdAldgv(producto Prod, int lugar)
        {
            Dgv_productos[0, lugar].Value = Prod.P_Codigo.ToString();
            Dgv_productos[1, lugar].Value = Prod.P_Descripcion;
            Dgv_productos[2, lugar].Value = Prod.P_Stock.ToString();
            Dgv_productos.Rows.Add(Prod.P_Codigo.ToString(), Prod.P_Descripcion, Prod.P_Stock.ToString());
            fila = (Dgv_productos.Rows.Count - 1);
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                if (rdb_ing.Checked == true)
                {
                    NuevoProducto.Ingreso(int.Parse(textBoxCantidad.Text));
                }
                if (rdb_egr.Checked == true)
                {
                    NuevoProducto.Salida(int.Parse(textBoxCantidad.Text));
                }
                LlevarProdAldgv(NuevoProducto, fila);
            }
            else
            {
                if (rdb_ing.Checked == true)
                {
                    ProdExistente.Ingreso(int.Parse(textBoxCantidad.Text));
                }
                if (rdb_egr.Checked == true)
                {
                    ProdExistente.Salida(int.Parse(textBoxCantidad.Text));
                }
                LlevarProdAldgv(ProdExistente, fila);
            }
        }

        private void Dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdExistente = new producto(Convert.ToInt32(Dgv_productos.CurrentRow.Cells[0].Value), 
                Dgv_productos.CurrentRow.Cells[1].Value.ToString(), 
                Convert.ToInt32(Dgv_productos.CurrentRow.Cells[2].Value));
            lbl_codigomov.Text = ProdExistente.P_Codigo.ToString();
            lbl_descmov.Text = ProdExistente.P_Descripcion;
            lbl_stock.Text = "Hay " + ProdExistente.P_Stock.ToString() + "unidades";
            textBoxCantidad.Clear();
            fila = e.RowIndex;
            nuevo = false;
        }
    }
}

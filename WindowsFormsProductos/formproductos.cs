using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using entidades;

namespace WindowsFormsProductos
{
    public partial class Formproductos : Form
    {
        producto NuevoProducto;
        producto ProdExistente;
        NegProductos objNegProducto = new NegProductos();
        bool nuevo = true;
        int fila;
        
        public Formproductos()
        {
            InitializeComponent();
            CrearDgv();
            LlenarDgv();
        }
        private void LlenarDgv()
        {
            dgv_productos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProducto.listadoproductos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_productos.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString());
                }
            }
            else
                MessageBox.Show("No hay productos cargados");
        }
        private void CrearDgv()
        {
            dgv_productos.Columns.Add("0", "codigo");
            dgv_productos.Columns.Add("1", "descripcion");
            dgv_productos.Columns.Add("2", "stock");

            dgv_productos.Columns[0].Width = 100;
            dgv_productos.Columns[1].Width = 300;
            dgv_productos.Columns[2].Width = 60;
        }
        private void Btn_cargar()
        {
            int nGrabados = -1;
            NuevoProducto = new producto(int.Parse(textBoxCod.Text), textBoxDesc.Text);
            nGrabados = objNegProducto.abmProductos("Alta", NuevoProducto);

            if (nGrabados== -1)
            {
                MessageBox.Show("No se pudo grabar el producto");
            }
            else
            {
                lblCodMov.Text = NuevoProducto.P_Codigo.ToString();
                lblDescMov.Text = NuevoProducto.P_Descripcion;
                lblStockMov.Text = "Hay" + NuevoProducto.P_Stock.ToString() + "unidades";

                //tabCargar.SelectedTab = tabMov;
                textBoxcant.Clear();
                textBoxcant.Focus();

                nuevo = true;
                LlenarDgv();
            }
        }
        void LlevarProdAldgv(producto prod)
        {
            dgv_productos.Rows.Add(prod.P_Codigo.ToString(), prod.P_Stock.ToString());
            fila = (dgv_productos.Rows.Count - 1);
        }
        void LlevarProdAldgv (producto prod, int lugar)
        {
            dgv_productos[0, lugar].Value = prod.P_Codigo.ToString();
            dgv_productos[1, lugar].Value = prod.P_Descripcion;
            dgv_productos[2, lugar].Value = prod.P_Stock.ToString();
        }
        private void btn_aceptar (object sender, EventArgs e)
        {
            if (radioButtoning.Checked== true)
            {
                ProdExistente.Ingreso(int.Parse(textBoxcant.Text));
            }
            if (radioButtonegr.Checked==true)
            {
                ProdExistente.Salida(int.Parse(textBoxcant.Text));
            }
            int nresultado = -1;
            nresultado = objNegProducto.abmProductos("Modificar", ProdExistente);
            if (nresultado != -1)
            {
                LlenarDgv;
            }
            else
                MessageBox.Show("Error", "Se produjo un error al intentar modificar el producto");
        }
        private void dgv_productos (object sender, DataGridViewCellEventArgs e)
        {
            ProdExistente = new producto(Convert.ToInt32(dgv_productos.CurrentRow.Cells[0].value), dgv_productos.CurrentRow.Cells[1].value.ToString(),
                Convert.ToInt32(dgv_productos.CurrentRow.Cells[2].value));
            DataSet ds = new DataSet();

            ds = objNegProducto.listadoproductos(ProdExistente.P_Codigo.ToString());
            if (ds.Tables[0].Rows.Count>0)
            {
                Ds_a_Controles(ds);
            }
        }
        private void Ds_a_Controles (DataSet ds)
        {
            lblCodMov.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
            lblDescMov.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
            lblStockMov.Text ="hay" + ds.Tables[0].Rows[0]["stock"].ToString() + "unidades";
        }
    }
}


using System;

namespace WindowsFormsProductos
{
    partial class formproductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codigo = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCarga = new System.Windows.Forms.TabPage();
            this.cargar = new System.Windows.Forms.Button();
            this.tabPageMov = new System.Windows.Forms.TabPage();
            this.rdbt_egr = new System.Windows.Forms.RadioButton();
            this.rdbt_ing = new System.Windows.Forms.RadioButton();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_codigodesc = new System.Windows.Forms.Label();
            this.lbl_codigomov = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.Dgv_productos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageCarga.SuspendLayout();
            this.tabPageMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.codigo.Location = new System.Drawing.Point(78, 33);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(43, 16);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "codigo";
            this.codigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descripcion.Location = new System.Drawing.Point(78, 57);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(64, 16);
            this.descripcion.TabIndex = 1;
            this.descripcion.Text = "descripcion";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stock.Location = new System.Drawing.Point(78, 84);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(34, 16);
            this.stock.TabIndex = 2;
            this.stock.Text = "stock";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(160, 33);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(201, 22);
            this.textBoxCod.TabIndex = 4;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(160, 59);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(201, 22);
            this.textBoxDesc.TabIndex = 5;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(160, 84);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(201, 22);
            this.textBoxStock.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCarga);
            this.tabControl1.Controls.Add(this.tabPageMov);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(31, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 164);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageCarga
            // 
            this.tabPageCarga.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPageCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCarga.Controls.Add(this.cargar);
            this.tabPageCarga.Controls.Add(this.textBoxDesc);
            this.tabPageCarga.Controls.Add(this.textBoxStock);
            this.tabPageCarga.Controls.Add(this.codigo);
            this.tabPageCarga.Controls.Add(this.descripcion);
            this.tabPageCarga.Controls.Add(this.textBoxCod);
            this.tabPageCarga.Controls.Add(this.stock);
            this.tabPageCarga.Location = new System.Drawing.Point(4, 25);
            this.tabPageCarga.Name = "tabPageCarga";
            this.tabPageCarga.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageCarga.Size = new System.Drawing.Size(532, 135);
            this.tabPageCarga.TabIndex = 0;
            this.tabPageCarga.Text = "carga de productos";
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(450, 82);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(75, 23);
            this.cargar.TabIndex = 7;
            this.cargar.Text = "cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // tabPageMov
            // 
            this.tabPageMov.BackColor = System.Drawing.Color.MistyRose;
            this.tabPageMov.Controls.Add(this.rdbt_egr);
            this.tabPageMov.Controls.Add(this.rdbt_ing);
            this.tabPageMov.Controls.Add(this.lbl_stock);
            this.tabPageMov.Controls.Add(this.lbl_codigodesc);
            this.tabPageMov.Controls.Add(this.lbl_codigomov);
            this.tabPageMov.Controls.Add(this.aceptar);
            this.tabPageMov.Controls.Add(this.textBoxCantidad);
            this.tabPageMov.Controls.Add(this.lbl_cantidad);
            this.tabPageMov.Location = new System.Drawing.Point(4, 25);
            this.tabPageMov.Name = "tabPageMov";
            this.tabPageMov.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageMov.Size = new System.Drawing.Size(532, 135);
            this.tabPageMov.TabIndex = 1;
            this.tabPageMov.Text = "Movimiento de productos";
            // 
            // rdbt_egr
            // 
            this.rdbt_egr.AutoSize = true;
            this.rdbt_egr.Location = new System.Drawing.Point(255, 107);
            this.rdbt_egr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbt_egr.Name = "rdbt_egr";
            this.rdbt_egr.Size = new System.Drawing.Size(61, 20);
            this.rdbt_egr.TabIndex = 9;
            this.rdbt_egr.TabStop = true;
            this.rdbt_egr.Text = "egreso";
            this.rdbt_egr.UseVisualStyleBackColor = true;
            // 
            // rdbt_ing
            // 
            this.rdbt_ing.AutoSize = true;
            this.rdbt_ing.Location = new System.Drawing.Point(255, 85);
            this.rdbt_ing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbt_ing.Name = "rdbt_ing";
            this.rdbt_ing.Size = new System.Drawing.Size(63, 20);
            this.rdbt_ing.TabIndex = 8;
            this.rdbt_ing.TabStop = true;
            this.rdbt_ing.Text = "ingreso";
            this.rdbt_ing.UseVisualStyleBackColor = true;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(29, 73);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(35, 16);
            this.lbl_stock.TabIndex = 7;
            this.lbl_stock.Text = "label1";
            // 
            // lbl_codigodesc
            // 
            this.lbl_codigodesc.AutoSize = true;
            this.lbl_codigodesc.Location = new System.Drawing.Point(29, 49);
            this.lbl_codigodesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigodesc.Name = "lbl_codigodesc";
            this.lbl_codigodesc.Size = new System.Drawing.Size(37, 16);
            this.lbl_codigodesc.TabIndex = 6;
            this.lbl_codigodesc.Text = "label2";
            // 
            // lbl_codigomov
            // 
            this.lbl_codigomov.AutoSize = true;
            this.lbl_codigomov.Location = new System.Drawing.Point(29, 22);
            this.lbl_codigomov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigomov.Name = "lbl_codigomov";
            this.lbl_codigomov.Size = new System.Drawing.Size(35, 16);
            this.lbl_codigomov.TabIndex = 5;
            this.lbl_codigomov.Text = "label1";
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.aceptar.Location = new System.Drawing.Point(396, 94);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(89, 23);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "ACEPTAR";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(97, 98);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 22);
            this.textBoxCantidad.TabIndex = 1;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(29, 98);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(51, 16);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "cantidad";
            // 
            // Dgv_productos
            // 
            this.Dgv_productos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_productos.Location = new System.Drawing.Point(13, 166);
            this.Dgv_productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_productos.Name = "Dgv_productos";
            this.Dgv_productos.RowHeadersWidth = 62;
            this.Dgv_productos.RowTemplate.Height = 28;
            this.Dgv_productos.Size = new System.Drawing.Size(574, 146);
            this.Dgv_productos.TabIndex = 8;
            // 
            // formproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(602, 323);
            this.Controls.Add(this.Dgv_productos);
            this.Controls.Add(this.tabControl1);
            this.Name = "formproductos";
            this.Text = "formproductos";
            this.Load += new System.EventHandler(this.formproductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCarga.ResumeLayout(false);
            this.tabPageCarga.PerformLayout();
            this.tabPageMov.ResumeLayout(false);
            this.tabPageMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_productos)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCarga;
        private System.Windows.Forms.TabPage tabPageMov;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.DataGridView Dgv_productos;
        private System.Windows.Forms.Label lbl_codigodesc;
        private System.Windows.Forms.Label lbl_codigomov;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.RadioButton rdbt_egr;
        private System.Windows.Forms.RadioButton rdbt_ing;
    }
}
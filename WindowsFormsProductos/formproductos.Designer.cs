
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
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_codigodesc = new System.Windows.Forms.Label();
            this.lbl_codigomov = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.Dgv_productos = new System.Windows.Forms.DataGridView();
            this.rdbt_ing = new System.Windows.Forms.RadioButton();
            this.rdbt_egr = new System.Windows.Forms.RadioButton();
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
            this.codigo.Location = new System.Drawing.Point(117, 51);
            this.codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(62, 23);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "codigo";
            this.codigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descripcion.Location = new System.Drawing.Point(117, 88);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(96, 23);
            this.descripcion.TabIndex = 1;
            this.descripcion.Text = "descripcion";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stock.Location = new System.Drawing.Point(117, 129);
            this.stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(48, 23);
            this.stock.TabIndex = 2;
            this.stock.Text = "stock";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(240, 51);
            this.textBoxCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(300, 29);
            this.textBoxCod.TabIndex = 4;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(240, 91);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(300, 29);
            this.textBoxDesc.TabIndex = 5;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(240, 129);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(300, 29);
            this.textBoxStock.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCarga);
            this.tabControl1.Controls.Add(this.tabPageMov);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(47, -4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 252);
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
            this.tabPageCarga.Location = new System.Drawing.Point(4, 32);
            this.tabPageCarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageCarga.Name = "tabPageCarga";
            this.tabPageCarga.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageCarga.Size = new System.Drawing.Size(802, 216);
            this.tabPageCarga.TabIndex = 0;
            this.tabPageCarga.Text = "carga de productos";
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(675, 126);
            this.cargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(112, 35);
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
            this.tabPageMov.Location = new System.Drawing.Point(4, 32);
            this.tabPageMov.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMov.Name = "tabPageMov";
            this.tabPageMov.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMov.Size = new System.Drawing.Size(802, 216);
            this.tabPageMov.TabIndex = 1;
            this.tabPageMov.Text = "Movimiento de productos";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(43, 113);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(53, 23);
            this.lbl_stock.TabIndex = 7;
            this.lbl_stock.Text = "label1";
            // 
            // lbl_codigodesc
            // 
            this.lbl_codigodesc.AutoSize = true;
            this.lbl_codigodesc.Location = new System.Drawing.Point(43, 76);
            this.lbl_codigodesc.Name = "lbl_codigodesc";
            this.lbl_codigodesc.Size = new System.Drawing.Size(55, 23);
            this.lbl_codigodesc.TabIndex = 6;
            this.lbl_codigodesc.Text = "label2";
            // 
            // lbl_codigomov
            // 
            this.lbl_codigomov.AutoSize = true;
            this.lbl_codigomov.Location = new System.Drawing.Point(43, 34);
            this.lbl_codigomov.Name = "lbl_codigomov";
            this.lbl_codigomov.Size = new System.Drawing.Size(53, 23);
            this.lbl_codigomov.TabIndex = 5;
            this.lbl_codigomov.Text = "label1";
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.aceptar.Location = new System.Drawing.Point(594, 145);
            this.aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(134, 35);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "ACEPTAR";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(145, 151);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(148, 29);
            this.textBoxCantidad.TabIndex = 1;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(43, 151);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(75, 23);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "cantidad";
            // 
            // Dgv_productos
            // 
            this.Dgv_productos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_productos.Location = new System.Drawing.Point(19, 256);
            this.Dgv_productos.Name = "Dgv_productos";
            this.Dgv_productos.RowHeadersWidth = 62;
            this.Dgv_productos.RowTemplate.Height = 28;
            this.Dgv_productos.Size = new System.Drawing.Size(861, 224);
            this.Dgv_productos.TabIndex = 8;
            // 
            // rdbt_ing
            // 
            this.rdbt_ing.AutoSize = true;
            this.rdbt_ing.Location = new System.Drawing.Point(382, 131);
            this.rdbt_ing.Name = "rdbt_ing";
            this.rdbt_ing.Size = new System.Drawing.Size(91, 27);
            this.rdbt_ing.TabIndex = 8;
            this.rdbt_ing.TabStop = true;
            this.rdbt_ing.Text = "ingreso";
            this.rdbt_ing.UseVisualStyleBackColor = true;
            // 
            // rdbt_egr
            // 
            this.rdbt_egr.AutoSize = true;
            this.rdbt_egr.Location = new System.Drawing.Point(382, 165);
            this.rdbt_egr.Name = "rdbt_egr";
            this.rdbt_egr.Size = new System.Drawing.Size(86, 27);
            this.rdbt_egr.TabIndex = 9;
            this.rdbt_egr.TabStop = true;
            this.rdbt_egr.Text = "egreso";
            this.rdbt_egr.UseVisualStyleBackColor = true;
            // 
            // formproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(903, 497);
            this.Controls.Add(this.Dgv_productos);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formproductos";
            this.Text = "formproductos";
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
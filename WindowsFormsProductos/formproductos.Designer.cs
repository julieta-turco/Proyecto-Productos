
using System;

namespace WindowsFormsProductos
{
    partial class Formproductos
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.tab_productos = new System.Windows.Forms.TabControl();
            this.tabCargar = new System.Windows.Forms.TabPage();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.tabMov = new System.Windows.Forms.TabPage();
            this.lblStockMov = new System.Windows.Forms.Label();
            this.labelcant = new System.Windows.Forms.Label();
            this.lblCodMov = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lblDescMov = new System.Windows.Forms.Label();
            this.radioButtonegr = new System.Windows.Forms.RadioButton();
            this.textBoxcant = new System.Windows.Forms.TextBox();
            this.radioButtoning = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.tab_productos.SuspendLayout();
            this.tabCargar.SuspendLayout();
            this.tabMov.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(55, 301);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(51, 20);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "label3";
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(42, 243);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(85, 33);
            this.btn_cargar.TabIndex = 5;
            this.btn_cargar.Text = "cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(162, 243);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(86, 33);
            this.btn_modificar.TabIndex = 6;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(355, 41);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersWidth = 62;
            this.dgv_productos.RowTemplate.Height = 28;
            this.dgv_productos.Size = new System.Drawing.Size(403, 278);
            this.dgv_productos.TabIndex = 7;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            // 
            // tab_productos
            // 
            this.tab_productos.AccessibleName = "";
            this.tab_productos.Controls.Add(this.tabCargar);
            this.tab_productos.Controls.Add(this.tabMov);
            this.tab_productos.Location = new System.Drawing.Point(12, 12);
            this.tab_productos.Name = "tab_productos";
            this.tab_productos.SelectedIndex = 0;
            this.tab_productos.Size = new System.Drawing.Size(337, 391);
            this.tab_productos.TabIndex = 8;
            // 
            // tabCargar
            // 
            this.tabCargar.Controls.Add(this.textBoxDesc);
            this.tabCargar.Controls.Add(this.labelMessage);
            this.tabCargar.Controls.Add(this.textBoxCod);
            this.tabCargar.Controls.Add(this.btn_cargar);
            this.tabCargar.Controls.Add(this.textBoxStock);
            this.tabCargar.Controls.Add(this.btn_modificar);
            this.tabCargar.Controls.Add(this.labelStock);
            this.tabCargar.Controls.Add(this.labelDescripcion);
            this.tabCargar.Controls.Add(this.labelCodigo);
            this.tabCargar.Location = new System.Drawing.Point(4, 29);
            this.tabCargar.Name = "tabCargar";
            this.tabCargar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCargar.Size = new System.Drawing.Size(329, 358);
            this.tabCargar.TabIndex = 0;
            this.tabCargar.Text = "carga productos";
            this.tabCargar.UseVisualStyleBackColor = true;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(148, 126);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(100, 26);
            this.textBoxDesc.TabIndex = 14;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(148, 63);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(100, 26);
            this.textBoxCod.TabIndex = 13;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(148, 190);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 26);
            this.textBoxStock.TabIndex = 12;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(80, 190);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(47, 20);
            this.labelStock.TabIndex = 11;
            this.labelStock.Text = "stock";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(38, 132);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(89, 20);
            this.labelDescripcion.TabIndex = 10;
            this.labelDescripcion.Text = "descripcion";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(71, 69);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(56, 20);
            this.labelCodigo.TabIndex = 9;
            this.labelCodigo.Text = "codigo";
            // 
            // tabMov
            // 
            this.tabMov.Controls.Add(this.lblStockMov);
            this.tabMov.Controls.Add(this.labelcant);
            this.tabMov.Controls.Add(this.lblCodMov);
            this.tabMov.Controls.Add(this.btn_aceptar);
            this.tabMov.Controls.Add(this.lblDescMov);
            this.tabMov.Controls.Add(this.radioButtonegr);
            this.tabMov.Controls.Add(this.textBoxcant);
            this.tabMov.Controls.Add(this.radioButtoning);
            this.tabMov.Location = new System.Drawing.Point(4, 29);
            this.tabMov.Name = "tabMov";
            this.tabMov.Padding = new System.Windows.Forms.Padding(3);
            this.tabMov.Size = new System.Drawing.Size(329, 358);
            this.tabMov.TabIndex = 1;
            this.tabMov.Text = "movimiento productos";
            this.tabMov.UseVisualStyleBackColor = true;
            // 
            // lblStockMov
            // 
            this.lblStockMov.AutoSize = true;
            this.lblStockMov.Location = new System.Drawing.Point(30, 146);
            this.lblStockMov.Name = "lblStockMov";
            this.lblStockMov.Size = new System.Drawing.Size(51, 20);
            this.lblStockMov.TabIndex = 20;
            this.lblStockMov.Text = "label1";
            // 
            // labelcant
            // 
            this.labelcant.AutoSize = true;
            this.labelcant.Location = new System.Drawing.Point(30, 176);
            this.labelcant.Name = "labelcant";
            this.labelcant.Size = new System.Drawing.Size(70, 20);
            this.labelcant.TabIndex = 19;
            this.labelcant.Text = "cantidad";
            // 
            // lblCodMov
            // 
            this.lblCodMov.AutoSize = true;
            this.lblCodMov.Location = new System.Drawing.Point(30, 50);
            this.lblCodMov.Name = "lblCodMov";
            this.lblCodMov.Size = new System.Drawing.Size(51, 20);
            this.lblCodMov.TabIndex = 15;
            this.lblCodMov.Text = "label1";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(226, 241);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(86, 35);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lblDescMov
            // 
            this.lblDescMov.AutoSize = true;
            this.lblDescMov.Location = new System.Drawing.Point(30, 106);
            this.lblDescMov.Name = "lblDescMov";
            this.lblDescMov.Size = new System.Drawing.Size(51, 20);
            this.lblDescMov.TabIndex = 16;
            this.lblDescMov.Text = "label2";
            // 
            // radioButtonegr
            // 
            this.radioButtonegr.AutoSize = true;
            this.radioButtonegr.Location = new System.Drawing.Point(67, 252);
            this.radioButtonegr.Name = "radioButtonegr";
            this.radioButtonegr.Size = new System.Drawing.Size(83, 24);
            this.radioButtonegr.TabIndex = 5;
            this.radioButtonegr.TabStop = true;
            this.radioButtonegr.Text = "egreso";
            this.radioButtonegr.UseVisualStyleBackColor = true;
            // 
            // textBoxcant
            // 
            this.textBoxcant.Location = new System.Drawing.Point(139, 170);
            this.textBoxcant.Name = "textBoxcant";
            this.textBoxcant.Size = new System.Drawing.Size(100, 26);
            this.textBoxcant.TabIndex = 18;
            // 
            // radioButtoning
            // 
            this.radioButtoning.AutoSize = true;
            this.radioButtoning.Location = new System.Drawing.Point(67, 221);
            this.radioButtoning.Name = "radioButtoning";
            this.radioButtoning.Size = new System.Drawing.Size(86, 24);
            this.radioButtoning.TabIndex = 4;
            this.radioButtoning.TabStop = true;
            this.radioButtoning.Text = "ingreso";
            this.radioButtoning.UseVisualStyleBackColor = true;
            // 
            // Formproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_productos);
            this.Controls.Add(this.dgv_productos);
            this.Name = "Formproductos";
            this.Text = "Formproductos";
            this.Load += new System.EventHandler(this.Formproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.tab_productos.ResumeLayout(false);
            this.tabCargar.ResumeLayout(false);
            this.tabCargar.PerformLayout();
            this.tabMov.ResumeLayout(false);
            this.tabMov.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Formproductos_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.TabControl tab_productos;
        private System.Windows.Forms.TabPage tabCargar;
        private System.Windows.Forms.TabPage tabMov;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.RadioButton radioButtonegr;
        private System.Windows.Forms.RadioButton radioButtoning;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label lblCodMov;
        private System.Windows.Forms.Label lblDescMov;
        private System.Windows.Forms.TextBox textBoxcant;
        private System.Windows.Forms.Label labelcant;
        private System.Windows.Forms.Label lblStockMov;
    }
}
namespace SistemaGestorPyME
{
    partial class FrmVentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DtgProductos = new System.Windows.Forms.DataGridView();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCancelarVenta = new System.Windows.Forms.Button();
            this.pPagarTotal = new System.Windows.Forms.Panel();
            this.LblPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).BeginInit();
            this.pPagarTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 56);
            this.panel1.TabIndex = 0;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(1348, 8);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 40);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DtgProductos
            // 
            this.DtgProductos.AllowUserToAddRows = false;
            this.DtgProductos.AllowUserToDeleteRows = false;
            this.DtgProductos.AllowUserToResizeColumns = false;
            this.DtgProductos.AllowUserToResizeRows = false;
            this.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProductos.Location = new System.Drawing.Point(177, 96);
            this.DtgProductos.Name = "DtgProductos";
            this.DtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgProductos.Size = new System.Drawing.Size(814, 726);
            this.DtgProductos.TabIndex = 1;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1104, 98);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(258, 55);
            this.BtnAgregarProducto.TabIndex = 3;
            this.BtnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(1104, 195);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(258, 51);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "CANCELAR PRODUCTO";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCancelarVenta
            // 
            this.BtnCancelarVenta.Location = new System.Drawing.Point(1104, 291);
            this.BtnCancelarVenta.Name = "BtnCancelarVenta";
            this.BtnCancelarVenta.Size = new System.Drawing.Size(258, 54);
            this.BtnCancelarVenta.TabIndex = 5;
            this.BtnCancelarVenta.Text = "CANCELAR VENTA";
            this.BtnCancelarVenta.UseVisualStyleBackColor = true;
            this.BtnCancelarVenta.Click += new System.EventHandler(this.BtnCancelarVenta_Click);
            // 
            // pPagarTotal
            // 
            this.pPagarTotal.Controls.Add(this.LblPagar);
            this.pPagarTotal.Controls.Add(this.label1);
            this.pPagarTotal.Location = new System.Drawing.Point(1084, 505);
            this.pPagarTotal.Name = "pPagarTotal";
            this.pPagarTotal.Size = new System.Drawing.Size(278, 124);
            this.pPagarTotal.TabIndex = 6;
            // 
            // LblPagar
            // 
            this.LblPagar.AutoSize = true;
            this.LblPagar.Location = new System.Drawing.Point(49, 73);
            this.LblPagar.Name = "LblPagar";
            this.LblPagar.Size = new System.Drawing.Size(34, 13);
            this.LblPagar.TabIndex = 1;
            this.LblPagar.Text = "00.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL A PAGAR";
            // 
            // BtnPagar
            // 
            this.BtnPagar.Location = new System.Drawing.Point(1084, 749);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(262, 73);
            this.BtnPagar.TabIndex = 7;
            this.BtnPagar.Text = "PAGAR";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.pPagarTotal);
            this.Controls.Add(this.BtnCancelarVenta);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.DtgProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).EndInit();
            this.pPagarTotal.ResumeLayout(false);
            this.pPagarTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView DtgProductos;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCancelarVenta;
        private System.Windows.Forms.Panel pPagarTotal;
        private System.Windows.Forms.Label LblPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPagar;
    }
}
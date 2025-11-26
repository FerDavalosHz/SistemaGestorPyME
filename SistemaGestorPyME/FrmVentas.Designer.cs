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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DtgProductos = new System.Windows.Forms.DataGridView();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCancelarVenta = new System.Windows.Forms.Button();
            this.pPagarTotal = new System.Windows.Forms.Panel();
            this.LblPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).BeginInit();
            this.pPagarTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Location = new System.Drawing.Point(99, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 64);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(150, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 41);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ventas";
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(65, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 61);
            this.label7.TabIndex = 2;
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
            this.DtgProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(158)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgProductos.DefaultCellStyle = dataGridViewCellStyle20;
            this.DtgProductos.EnableHeadersVisualStyles = false;
            this.DtgProductos.Location = new System.Drawing.Point(229, 128);
            this.DtgProductos.Name = "DtgProductos";
            this.DtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgProductos.Size = new System.Drawing.Size(765, 579);
            this.DtgProductos.TabIndex = 1;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1088, 173);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(258, 55);
            this.BtnAgregarProducto.TabIndex = 3;
            this.BtnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnCancelar.Location = new System.Drawing.Point(1088, 270);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(258, 51);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "CANCELAR PRODUCTO";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCancelarVenta
            // 
            this.BtnCancelarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarVenta.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnCancelarVenta.Location = new System.Drawing.Point(1088, 366);
            this.BtnCancelarVenta.Name = "BtnCancelarVenta";
            this.BtnCancelarVenta.Size = new System.Drawing.Size(258, 54);
            this.BtnCancelarVenta.TabIndex = 5;
            this.BtnCancelarVenta.Text = "CANCELAR VENTA";
            this.BtnCancelarVenta.UseVisualStyleBackColor = false;
            this.BtnCancelarVenta.Click += new System.EventHandler(this.BtnCancelarVenta_Click);
            // 
            // pPagarTotal
            // 
            this.pPagarTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(158)))), ((int)(((byte)(196)))));
            this.pPagarTotal.Controls.Add(this.LblPagar);
            this.pPagarTotal.Controls.Add(this.label1);
            this.pPagarTotal.Location = new System.Drawing.Point(1058, 524);
            this.pPagarTotal.Name = "pPagarTotal";
            this.pPagarTotal.Size = new System.Drawing.Size(288, 93);
            this.pPagarTotal.TabIndex = 6;
            // 
            // LblPagar
            // 
            this.LblPagar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.LblPagar.Location = new System.Drawing.Point(51, 48);
            this.LblPagar.Name = "LblPagar";
            this.LblPagar.Size = new System.Drawing.Size(195, 29);
            this.LblPagar.TabIndex = 1;
            this.LblPagar.Text = "00.00";
            this.LblPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL A PAGAR";
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(158)))), ((int)(((byte)(196)))));
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.BtnPagar.Location = new System.Drawing.Point(1058, 642);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(288, 67);
            this.BtnPagar.TabIndex = 7;
            this.BtnPagar.Text = "PAGAR";
            this.BtnPagar.UseVisualStyleBackColor = false;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            this.BtnPagar.MouseEnter += new System.EventHandler(this.BtnPagar_MouseEnter);
            this.BtnPagar.MouseLeave += new System.EventHandler(this.BtnPagar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(158)))), ((int)(((byte)(196)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1244, 646);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 59);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1227, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(38, 31);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.BtnCategorias);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BtnUsuarios);
            this.panel2.Controls.Add(this.BtnVenta);
            this.panel2.Controls.Add(this.BtnProveedores);
            this.panel2.Controls.Add(this.BtnInicio);
            this.panel2.Controls.Add(this.BtnProductos);
            this.panel2.Controls.Add(this.BtnInventario);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 788);
            this.panel2.TabIndex = 40;
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCategorias.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnCategorias.Location = new System.Drawing.Point(0, 455);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(156, 100);
            this.BtnCategorias.TabIndex = 14;
            this.BtnCategorias.Text = "Categorias";
            this.BtnCategorias.UseVisualStyleBackColor = true;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(50, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 60);
            this.label3.TabIndex = 13;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 652);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(156, 100);
            this.BtnUsuarios.TabIndex = 12;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVenta.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnVenta.Location = new System.Drawing.Point(0, 162);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(156, 100);
            this.BtnVenta.TabIndex = 1;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.UseVisualStyleBackColor = false;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnProveedores.Location = new System.Drawing.Point(0, 553);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(156, 100);
            this.BtnProveedores.TabIndex = 11;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.UseVisualStyleBackColor = false;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnInicio.Location = new System.Drawing.Point(0, 63);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(156, 100);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click_1);
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnProductos.Location = new System.Drawing.Point(0, 357);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(156, 100);
            this.BtnProductos.TabIndex = 10;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnInventario.Location = new System.Drawing.Point(0, 259);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(156, 100);
            this.BtnInventario.TabIndex = 9;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click_1);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnInventario;
    }
}
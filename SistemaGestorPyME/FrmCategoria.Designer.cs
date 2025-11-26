namespace SistemaGestorPyME
{
    partial class FrmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCategorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(206, 699);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(1125, 50);
            this.BtnAgregar.TabIndex = 36;
            this.BtnAgregar.Text = "Agregar Categorias";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(1136, 120);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(118, 43);
            this.BtnBuscar.TabIndex = 35;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(158)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDatos.DefaultCellStyle = dataGridViewCellStyle16;
            this.DtgDatos.EnableHeadersVisualStyles = false;
            this.DtgDatos.Location = new System.Drawing.Point(206, 197);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(1125, 470);
            this.DtgDatos.TabIndex = 34;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(463, 116);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(637, 43);
            this.TxtBuscar.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 32;
            this.label1.Text = "Categoria:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Location = new System.Drawing.Point(99, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 64);
            this.panel1.TabIndex = 38;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(1348, 8);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 40);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = true;
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
            this.panel2.TabIndex = 39;
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
            this.BtnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
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
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
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
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1228, 17);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(38, 31);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(141, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categorias";
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(60, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 61);
            this.label7.TabIndex = 14;
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCategorias.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.BtnCategorias.Location = new System.Drawing.Point(0, 455);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(156, 100);
            this.BtnCategorias.TabIndex = 14;
            this.BtnCategorias.Text = "Categoria";
            this.BtnCategorias.UseVisualStyleBackColor = false;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCategorias;
    }
}
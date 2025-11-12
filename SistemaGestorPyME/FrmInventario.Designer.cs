namespace SistemaGestorPyME
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApartado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DtgDatosInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LsbCategoria = new System.Windows.Forms.ListBox();
            this.LsbProveedor = new System.Windows.Forms.ListBox();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.BtnAlertas = new System.Windows.Forms.Button();
            this.LblFechaUsuario = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.BtnInicio);
            this.panel2.Controls.Add(this.BtnUsuarios);
            this.panel2.Controls.Add(this.BtnProveedores);
            this.panel2.Controls.Add(this.BtnProductos);
            this.panel2.Controls.Add(this.BtnInventario);
            this.panel2.Controls.Add(this.BtnVentas);
            this.panel2.Controls.Add(this.ptbLogo);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 900);
            this.panel2.TabIndex = 5;
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.Location = new System.Drawing.Point(0, 62);
            this.BtnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(157, 115);
            this.BtnInicio.TabIndex = 6;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 616);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(157, 114);
            this.BtnUsuarios.TabIndex = 5;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.Location = new System.Drawing.Point(0, 504);
            this.BtnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(157, 114);
            this.BtnProveedores.TabIndex = 4;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.UseVisualStyleBackColor = false;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.Location = new System.Drawing.Point(0, 392);
            this.BtnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(157, 114);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.Location = new System.Drawing.Point(0, 282);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(157, 114);
            this.BtnInventario.TabIndex = 2;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Location = new System.Drawing.Point(0, 171);
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(157, 114);
            this.BtnVentas.TabIndex = 1;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = false;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::SistemaGestorPyME.Properties.Resources.logo_removebg_preview;
            this.ptbLogo.Location = new System.Drawing.Point(35, -2);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(64, 64);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblApartado);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(132, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 64);
            this.panel1.TabIndex = 4;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.BtnSalir.Location = new System.Drawing.Point(1208, 15);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(31, 28);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblApartado
            // 
            this.lblApartado.AutoSize = true;
            this.lblApartado.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartado.ForeColor = System.Drawing.Color.Black;
            this.lblApartado.Location = new System.Drawing.Point(104, 10);
            this.lblApartado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApartado.Name = "lblApartado";
            this.lblApartado.Size = new System.Drawing.Size(160, 36);
            this.lblApartado.TabIndex = 8;
            this.lblApartado.Text = "Inventario";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.btnCerrar.Location = new System.Drawing.Point(1649, 10);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(189, 105);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(877, 34);
            this.TxtBuscar.TabIndex = 6;
            // 
            // DtgDatosInventario
            // 
            this.DtgDatosInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatosInventario.Location = new System.Drawing.Point(189, 223);
            this.DtgDatosInventario.Name = "DtgDatosInventario";
            this.DtgDatosInventario.RowTemplate.Height = 24;
            this.DtgDatosInventario.Size = new System.Drawing.Size(1149, 552);
            this.DtgDatosInventario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categoría:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Proveedor:";
            // 
            // LsbCategoria
            // 
            this.LsbCategoria.FormattingEnabled = true;
            this.LsbCategoria.ItemHeight = 16;
            this.LsbCategoria.Location = new System.Drawing.Point(324, 171);
            this.LsbCategoria.Name = "LsbCategoria";
            this.LsbCategoria.Size = new System.Drawing.Size(173, 20);
            this.LsbCategoria.TabIndex = 10;
            this.LsbCategoria.SelectedIndexChanged += new System.EventHandler(this.LsbCategoria_SelectedIndexChanged);
            // 
            // LsbProveedor
            // 
            this.LsbProveedor.FormattingEnabled = true;
            this.LsbProveedor.ItemHeight = 16;
            this.LsbProveedor.Location = new System.Drawing.Point(683, 171);
            this.LsbProveedor.Name = "LsbProveedor";
            this.LsbProveedor.Size = new System.Drawing.Size(164, 20);
            this.LsbProveedor.TabIndex = 11;
            this.LsbProveedor.SelectedIndexChanged += new System.EventHandler(this.LsbProveedor_SelectedIndexChanged);
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExaminar.Location = new System.Drawing.Point(1094, 101);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(136, 38);
            this.BtnExaminar.TabIndex = 12;
            this.BtnExaminar.Text = "Examinar";
            this.BtnExaminar.UseVisualStyleBackColor = false;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // BtnAlertas
            // 
            this.BtnAlertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnAlertas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlertas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlertas.Location = new System.Drawing.Point(1249, 101);
            this.BtnAlertas.Name = "BtnAlertas";
            this.BtnAlertas.Size = new System.Drawing.Size(111, 38);
            this.BtnAlertas.TabIndex = 13;
            this.BtnAlertas.Text = "Alertas";
            this.BtnAlertas.UseVisualStyleBackColor = false;
            this.BtnAlertas.Click += new System.EventHandler(this.BtnAlertas_Click);
            // 
            // LblFechaUsuario
            // 
            this.LblFechaUsuario.AutoSize = true;
            this.LblFechaUsuario.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaUsuario.Location = new System.Drawing.Point(1108, 814);
            this.LblFechaUsuario.Name = "LblFechaUsuario";
            this.LblFechaUsuario.Size = new System.Drawing.Size(176, 21);
            this.LblFechaUsuario.TabIndex = 14;
            this.LblFechaUsuario.Text = "12/12/1212 USUARIO";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.LblFechaUsuario);
            this.Controls.Add(this.BtnAlertas);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.LsbProveedor);
            this.Controls.Add(this.LsbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgDatosInventario);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventario";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DtgDatosInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LsbCategoria;
        private System.Windows.Forms.ListBox LsbProveedor;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.Button BtnAlertas;
        private System.Windows.Forms.Label LblFechaUsuario;
    }
}
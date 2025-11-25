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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.Datos = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnEntradas = new System.Windows.Forms.Button();
            this.BtnNotificaciones = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApartado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.AllowUserToResizeColumns = false;
            this.Datos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(158)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Datos.EnableHeadersVisualStyles = false;
            this.Datos.Location = new System.Drawing.Point(194, 162);
            this.Datos.Margin = new System.Windows.Forms.Padding(4);
            this.Datos.Name = "Datos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Datos.RowHeadersVisible = false;
            this.Datos.RowHeadersWidth = 51;
            this.Datos.Size = new System.Drawing.Size(1177, 685);
            this.Datos.TabIndex = 0;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(194, 92);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(803, 40);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnEntradas
            // 
            this.BtnEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnEntradas.Enabled = false;
            this.BtnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntradas.Location = new System.Drawing.Point(1022, 95);
            this.BtnEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEntradas.Name = "BtnEntradas";
            this.BtnEntradas.Size = new System.Drawing.Size(178, 37);
            this.BtnEntradas.TabIndex = 2;
            this.BtnEntradas.Text = "Agregar entrada";
            this.BtnEntradas.UseVisualStyleBackColor = false;
            this.BtnEntradas.Click += new System.EventHandler(this.BtnEntradas_Click);
            // 
            // BtnNotificaciones
            // 
            this.BtnNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnNotificaciones.Enabled = false;
            this.BtnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotificaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotificaciones.Location = new System.Drawing.Point(1225, 95);
            this.BtnNotificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNotificaciones.Name = "BtnNotificaciones";
            this.BtnNotificaciones.Size = new System.Drawing.Size(146, 37);
            this.BtnNotificaciones.TabIndex = 4;
            this.BtnNotificaciones.Text = "Notificaciones";
            this.BtnNotificaciones.UseVisualStyleBackColor = false;
            this.BtnNotificaciones.Click += new System.EventHandler(this.BtnNotificaciones_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Red;
            this.zero.Location = new System.Drawing.Point(1359, 86);
            this.zero.Margin = new System.Windows.Forms.Padding(4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(17, 16);
            this.zero.TabIndex = 5;
            this.zero.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblApartado);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(153, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 64);
            this.panel1.TabIndex = 6;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.BtnSalir.Location = new System.Drawing.Point(1214, 15);
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
            this.panel2.Location = new System.Drawing.Point(-3, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 900);
            this.panel2.TabIndex = 7;
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.Location = new System.Drawing.Point(1, 62);
            this.BtnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(156, 115);
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
            this.BtnUsuarios.Location = new System.Drawing.Point(1, 616);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(156, 114);
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
            this.BtnProveedores.Location = new System.Drawing.Point(1, 504);
            this.BtnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(156, 114);
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
            this.BtnProductos.Location = new System.Drawing.Point(1, 392);
            this.BtnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(156, 114);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.Location = new System.Drawing.Point(1, 281);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(156, 114);
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
            this.BtnVentas.Location = new System.Drawing.Point(1, 171);
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(156, 114);
            this.BtnVentas.TabIndex = 1;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = false;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1410, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.BtnNotificaciones);
            this.Controls.Add(this.BtnEntradas);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnEntradas;
        private System.Windows.Forms.Button BtnNotificaciones;
        private System.Windows.Forms.Panel zero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnVentas;
    }
}
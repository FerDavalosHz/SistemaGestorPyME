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
            this.Datos = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnEntradas = new System.Windows.Forms.Button();
            this.BtnNotificaciones = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.AllowUserToResizeColumns = false;
            this.Datos.AllowUserToResizeRows = false;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(170, 74);
            this.Datos.Name = "Datos";
            this.Datos.RowHeadersVisible = false;
            this.Datos.Size = new System.Drawing.Size(876, 680);
            this.Datos.TabIndex = 0;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            this.Datos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellEnter);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(170, 21);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(622, 30);
            this.TxtBuscar.TabIndex = 1;
            // 
            // BtnEntradas
            // 
            this.BtnEntradas.Location = new System.Drawing.Point(814, 21);
            this.BtnEntradas.Name = "BtnEntradas";
            this.BtnEntradas.Size = new System.Drawing.Size(128, 30);
            this.BtnEntradas.TabIndex = 2;
            this.BtnEntradas.Text = "Agregar entrada";
            this.BtnEntradas.UseVisualStyleBackColor = true;
            this.BtnEntradas.Click += new System.EventHandler(this.BtnEntradas_Click);
            // 
            // BtnNotificaciones
            // 
            this.BtnNotificaciones.Enabled = false;
            this.BtnNotificaciones.Location = new System.Drawing.Point(958, 21);
            this.BtnNotificaciones.Name = "BtnNotificaciones";
            this.BtnNotificaciones.Size = new System.Drawing.Size(88, 30);
            this.BtnNotificaciones.TabIndex = 4;
            this.BtnNotificaciones.Text = "Notificaciones";
            this.BtnNotificaciones.UseVisualStyleBackColor = true;
            this.BtnNotificaciones.Click += new System.EventHandler(this.BtnNotificaciones_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Red;
            this.zero.Location = new System.Drawing.Point(1033, 15);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(13, 13);
            this.zero.TabIndex = 5;
            this.zero.Visible = false;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.BtnNotificaciones);
            this.Controls.Add(this.BtnEntradas);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.Datos);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnEntradas;
        private System.Windows.Forms.Button BtnNotificaciones;
        private System.Windows.Forms.Panel zero;
    }
}
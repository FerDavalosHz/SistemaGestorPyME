namespace SistemaGestorPyME
{
    partial class FrmAlertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlertas));
            this.LsbAlertas = new System.Windows.Forms.ListBox();
            this.BtnLeidas = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApartado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsbAlertas
            // 
            this.LsbAlertas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbAlertas.FormattingEnabled = true;
            this.LsbAlertas.ItemHeight = 19;
            this.LsbAlertas.Location = new System.Drawing.Point(24, 131);
            this.LsbAlertas.Name = "LsbAlertas";
            this.LsbAlertas.Size = new System.Drawing.Size(774, 555);
            this.LsbAlertas.TabIndex = 0;
            // 
            // BtnLeidas
            // 
            this.BtnLeidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnLeidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeidas.Location = new System.Drawing.Point(813, 142);
            this.BtnLeidas.Name = "BtnLeidas";
            this.BtnLeidas.Size = new System.Drawing.Size(208, 48);
            this.BtnLeidas.TabIndex = 1;
            this.BtnLeidas.Text = "Marcar como leidas ";
            this.BtnLeidas.UseVisualStyleBackColor = false;
            this.BtnLeidas.Click += new System.EventHandler(this.BtnLeidas_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(813, 222);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(208, 43);
            this.BtnAtras.TabIndex = 2;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.BtnSalir.Location = new System.Drawing.Point(1026, 14);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(23, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblApartado);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 52);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblApartado
            // 
            this.lblApartado.AutoSize = true;
            this.lblApartado.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartado.ForeColor = System.Drawing.Color.White;
            this.lblApartado.Location = new System.Drawing.Point(78, 8);
            this.lblApartado.Name = "lblApartado";
            this.lblApartado.Size = new System.Drawing.Size(160, 36);
            this.lblApartado.TabIndex = 8;
            this.lblApartado.Text = "Inventario";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.btnCerrar.Location = new System.Drawing.Point(1237, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 29);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL DE ALERTAS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(158)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(24, 88);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 43);
            this.panel3.TabIndex = 10;
            // 
            // FrmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 731);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnLeidas);
            this.Controls.Add(this.LsbAlertas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlertas";
            this.Load += new System.EventHandler(this.FrmAlertas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbAlertas;
        private System.Windows.Forms.Button BtnLeidas;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}
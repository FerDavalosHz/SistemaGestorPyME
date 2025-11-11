namespace SistemaGestorPyME
{
    partial class FrmAgregarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre:\r\n";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(144, 28);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(292, 31);
            this.TxtNombre.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Precio:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(144, 212);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(292, 30);
            this.TxtPrecio.TabIndex = 53;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnGuardar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(81, 297);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(130, 58);
            this.BtnGuardar.TabIndex = 55;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Chocolate;
            this.BtnCancelar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(215, 297);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 58);
            this.BtnCancelar.TabIndex = 56;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(144, 166);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(292, 30);
            this.CmbCategoria.TabIndex = 57;
            // 
            // TxtStock
            // 
            this.TxtStock.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.Location = new System.Drawing.Point(144, 125);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(292, 30);
            this.TxtStock.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Stock minimo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 60;
            this.label6.Text = "Categoria:";
            // 
            // CbEstado
            // 
            this.CbEstado.AutoSize = true;
            this.CbEstado.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.Location = new System.Drawing.Point(19, 251);
            this.CbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(80, 26);
            this.CbEstado.TabIndex = 61;
            this.CbEstado.Text = "Activo";
            this.CbEstado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Descripcion";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(144, 80);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(292, 30);
            this.TxtDescripcion.TabIndex = 63;
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 366);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.CmbCategoria);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescripcion;
    }
}
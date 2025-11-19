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
            this.LsbAlertas = new System.Windows.Forms.ListBox();
            this.BtnLeidas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsbAlertas
            // 
            this.LsbAlertas.FormattingEnabled = true;
            this.LsbAlertas.Location = new System.Drawing.Point(67, 70);
            this.LsbAlertas.Name = "LsbAlertas";
            this.LsbAlertas.Size = new System.Drawing.Size(738, 550);
            this.LsbAlertas.TabIndex = 0;
            // 
            // BtnLeidas
            // 
            this.BtnLeidas.Location = new System.Drawing.Point(661, 24);
            this.BtnLeidas.Name = "BtnLeidas";
            this.BtnLeidas.Size = new System.Drawing.Size(144, 23);
            this.BtnLeidas.TabIndex = 1;
            this.BtnLeidas.Text = "Marcar como leidas ";
            this.BtnLeidas.UseVisualStyleBackColor = true;
            this.BtnLeidas.Click += new System.EventHandler(this.BtnLeidas_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnLeidas);
            this.Controls.Add(this.LsbAlertas);
            this.Name = "FrmAlertas";
            this.Text = "FrmAlertas";
            this.Load += new System.EventHandler(this.FrmAlertas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbAlertas;
        private System.Windows.Forms.Button BtnLeidas;
        private System.Windows.Forms.Button button2;
    }
}
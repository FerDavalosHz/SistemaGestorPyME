using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Taller_Kike;

namespace SistemaGestorPyME
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();
        }

        private Form formularioActivo = null;


       
        private bool TienePermisoAdmin()
        {
            if (!Sesion.Rango.Equals("Administrador"))
            {
                MessageBox.Show(
                    $"{Sesion.Nombre} no tiene permiso de hacer eso. Inicie sesión como administrador.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }
            return true;
        }


        public void CargarPermisos()
        {
            if (Sesion.Rango.Equals("Administrador"))
            {
                btnUsuarios.Enabled = true;
                btnProveedores.Enabled = true;
                btnUsuarios.Enabled = true;
                btnProductos.Enabled = true;
            }
        }


     
        private void btnVentas_Click(object sender, EventArgs e)
        {

            FrmVentas fs = new FrmVentas();
            this.Hide(); // Oculta el menú
            fs.FormClosed += (s, args) => this.Show(); // Al cerrar ventas, muestra el menú
            fs.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            if (TienePermisoAdmin())
            {
                FrmProducto fs = new FrmProducto();
                this.Hide();
                fs.FormClosed += (s, args) => this.Show();
                fs.Show();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CargarPermisos();
            LblInfo.Text = Sesion.Nombre + " " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    
        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            if (TienePermisoAdmin())
            {
                FrmUsuarios usuarios = new FrmUsuarios();
                this.Hide();
                usuarios.FormClosed += (s, args) => this.Show();
                usuarios.Show();
            }
        }

     
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (TienePermisoAdmin())
            {
                FrmProveedor proveedores = new FrmProveedor();
                this.Hide();
                proveedores.FormClosed += (s, args) => this.Show();
                proveedores.Show();
            }
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario fi = new FrmInventario();
            this.Hide();
            fi.FormClosed += (s, args) => this.Show();
            fi.Show();
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            if (TienePermisoAdmin())
            {
                FrmCategoria fc = new FrmCategoria();
                this.Hide();
                fc.FormClosed += (s, args) => this.Show();
                fc.Show();
            }
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {

        }
    }
}

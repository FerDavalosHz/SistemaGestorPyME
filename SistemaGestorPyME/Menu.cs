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

        // Variable para saber qué formulario está abierto actualmente dentro del panel
        private Form formularioActivo = null;


        public void CargarPermisos() { 
        

            if (Sesion.Rango.Equals("Administrador")) { 
                btnUsuarios.Enabled = true;
                btnProveedores.Enabled = true;
                btnUsuarios.Enabled = true;
                btnProductos.Enabled = true;
            }
        
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmVentas fs = new FrmVentas();
            fs.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProducto fs = new FrmProducto();
            fs.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CargarPermisos();

            LblInfo.Text = Sesion.Nombre +" "+ DateTime.Now.ToString("dd/MM/yyyy"); 
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
            this.Close();
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProveedor proveedores = new FrmProveedor();  
            proveedores.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInventario fi = new FrmInventario();
            fi.ShowDialog();
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategoria fc = new FrmCategoria();
            fc.ShowDialog();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {

        }
    }
}

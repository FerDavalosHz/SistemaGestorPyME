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
            FrmVentas fs = new FrmVentas();
            fs.Show();
            fs.Focus();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProducto fs = new FrmProducto();
            fs.Show();
            fs.Focus();
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
      
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.Show();
            usuarios.Focus();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
           
            FrmProveedor proveedores = new FrmProveedor();  
            proveedores.Show();
            proveedores.Focus();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            
            FrmInventario fi = new FrmInventario();
            fi.Show();
            fi.Focus();
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
           
            FrmCategoria fc = new FrmCategoria();
            fc.Show();
            fc.Focus();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {

        }
    }
}

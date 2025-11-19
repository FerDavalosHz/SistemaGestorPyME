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

        public void CargarPermisos() { 
        

            if (Sesion.Rango.Equals("Administrador")) { 
                btnUsuarios.Enabled = true;
                btnProveedores.Enabled = true;
                btnUsuarios.Enabled = true;
            }
        
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
           FrmAgregarCategoria fs = new FrmAgregarCategoria();
            fs.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

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
            usuarios.ShowDialog();
        }
    }
}

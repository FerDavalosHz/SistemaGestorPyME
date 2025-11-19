using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using Entidades;
namespace Taller_Kike
{
    public partial class FrmDatosUsuarios : Form
    {
        ManejadorUsuarios mu;

        public FrmDatosUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();

            // Si estamos editando un usuario existente
            if (FrmUsuarios.usuario.IdUsuario > 0)
            {
                CargarDatosUsuario();
            }
        }

        private void CargarDatosUsuario()
        {
            TxtNombre.Text = FrmUsuarios.usuario.Nombre;
            TxtUsuario.Text = FrmUsuarios.usuario.UsuarioNombre;
            ChkActivo.Checked = FrmUsuarios.usuario.Activo;
            CboRango.Text = FrmUsuarios.usuario.Rango;

         
            TxtClave.Text = "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.usuario.IdUsuario == 0) 
            {
                mu.Guardar(new Usuario(
                    0,
                    TxtNombre.Text,
                    TxtUsuario.Text,
                    TxtClave.Text,
                    ChkActivo.Checked,
                    CboRango.Text
                ));
            }
            else 
            {
                mu.Modificar(new Usuario(
                    FrmUsuarios.usuario.IdUsuario,
                    TxtNombre.Text,
                    TxtUsuario.Text,
                    TxtClave.Text,
                    ChkActivo.Checked,
                    CboRango.Text
                ));
            }

            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorPyME
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }
>>>>>>> Agregue el FrmInventario y lo acomode para que al compilar se viera bien, aún falta que me digan si así lo dejo porque hay cosas que no me convencen. Tambien le di doble click a todos los botones tanto de este forms como el de Historial alerta y el de login.
    }
}

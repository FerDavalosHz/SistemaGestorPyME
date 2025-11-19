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
using Manejador;

namespace SistemaGestorPyME
{
    public partial class FrmAlertas : Form
    {

        ManejadorInventario mi;
        public FrmAlertas()
        {
            InitializeComponent();
            mi = new ManejadorInventario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLeidas_Click(object sender, EventArgs e)
        {
            mi.MarcarTodasLeidas();
            Close();
        }

        private void FrmAlertas_Load(object sender, EventArgs e)
        {

            if (!Sesion.Rango.Equals("Administrador"))
            {
                BtnLeidas.Enabled = false;
            }


            mi.LlenarAlertas(LsbAlertas);

        }
    }
}

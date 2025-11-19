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

namespace SistemaGestorPyME
{
    public partial class FrmHistorial : Form
    {

      
        private int idProducto;
        private ManejadorInventario mi;

        public FrmHistorial(int idProducto, string nombreProducto)
        {
            InitializeComponent();
            this.idProducto = idProducto;
            LblNombre.Text = nombreProducto; 
            mi = new ManejadorInventario();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
       
            mi.MostrarHistorial(idProducto, Datos, "inventario");
        }
    }
}


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
    public partial class FrmInventario : Form
    {

        ManejadorInventario mi;
        public FrmInventario()
        {
            InitializeComponent();
            mi = new ManejadorInventario();
        }

        private void BtnEntradas_Click(object sender, EventArgs e)
        {
            FrmMover fm = new FrmMover();
            fm.ShowDialog();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            mi.Mostrar("", Datos, "inventario");
            BtnNotificaciones.Enabled = mi.HayAlertasSinLeer();
            zero.Visible = mi.HayAlertasSinLeer();
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            int indiceBotonHistorial = Datos.Columns.Count - 2; 
            int indiceBotonQuitar = Datos.Columns.Count - 1;  

            int idProducto = Convert.ToInt32(Datos.Rows[e.RowIndex].Cells["id_producto"].Value);
            string nombreProducto = Datos.Rows[e.RowIndex].Cells["nombre_producto"].Value.ToString();

            if (e.ColumnIndex == indiceBotonHistorial)
            {
                FrmHistorial fh = new FrmHistorial(idProducto, nombreProducto);
                fh.ShowDialog();
            }
            else if (e.ColumnIndex == indiceBotonQuitar)
            {
                FrmQuitarInventario fq = new FrmQuitarInventario(idProducto, nombreProducto);
                fq.ShowDialog();

                mi.Mostrar("", Datos, "inventario");
            }
        }



        private void Datos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNotificaciones_Click(object sender, EventArgs e)
        {
            FrmAlertas fa = new FrmAlertas();
            fa.ShowDialog();
            BtnNotificaciones.Enabled = mi.HayAlertasSinLeer();
            zero.Visible = mi.HayAlertasSinLeer();
        }
    }
}

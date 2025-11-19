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
    public partial class FrmInventario : Form
    {
        ManejadorInventario mi;
        private Timer timerBusqueda;

        public FrmInventario()
        {
            InitializeComponent();
            mi = new ManejadorInventario();


            timerBusqueda = new Timer();
            timerBusqueda.Interval = 500;
            timerBusqueda.Tick += TimerBusqueda_Tick;

            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {

            if (Sesion.Rango.Equals("Administrador")) { 
            
                Datos.Enabled = true;
                BtnEntradas.Enabled = true;

            }
            mi.Mostrar("", Datos, "inventario");
            BtnNotificaciones.Enabled = mi.HayAlertasSinLeer();
            zero.Visible = mi.HayAlertasSinLeer();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            timerBusqueda.Stop();
            timerBusqueda.Start();
        }

        private void TimerBusqueda_Tick(object sender, EventArgs e)
        {
            timerBusqueda.Stop();

            string consulta = TxtBuscar.Text; 
            mi.Mostrar(consulta, Datos, "inventario");
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

                mi.Mostrar(TxtBuscar.Text, Datos, "inventario"); 
            }
        }

        private void BtnEntradas_Click(object sender, EventArgs e)
        {
            FrmMover fm = new FrmMover();
            fm.ShowDialog();
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

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SistemaGestorPyME
{

    public partial class FrmSeleccionProducto : Form
    {


        ManejadorVentas Mv;
        public FrmSeleccionProducto()
        {
            InitializeComponent();
            this.Size = new Size(1100, 900);
            Mv = new ManejadorVentas();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSeleccionProducto_Load(object sender, EventArgs e)
        {
            Mv.Mostrar(TxtBuscar.Text, DtgDatos,"tbl_lotes");
            DtgDatos.ClearSelection();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

           
            DataGridViewRow fila = DtgDatos.Rows[e.RowIndex];

          
            var productoSeleccionado = (
                   idProducto: Convert.ToInt32(fila.Cells["id_producto"].Value),
                     idLote: Convert.ToInt32(fila.Cells["id_lote"].Value),
                     nombre: fila.Cells["NombreProducto"].Value.ToString(),
                     categoria: fila.Cells["Categoria"].Value.ToString(),
                     codigoLote: fila.Cells["codigo_lote"].Value.ToString(),
                     precio: Convert.ToDecimal(fila.Cells["precio_venta_actual"].Value),
                     stock: Convert.ToInt32(fila.Cells["Stock"].Value),
                     fechaVencimiento: Convert.ToDateTime(fila.Cells["fecha_vencimiento"].Value)
            );

            LblSeleccion.Text = productoSeleccionado.nombre;
            TxtCantidad.Focus();
        }
    }
}

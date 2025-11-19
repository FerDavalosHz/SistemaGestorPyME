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
    public partial class FrmMover : Form
    {
        ManejadorProducto mp;
        int fila = 0; int columna = 0;
        public FrmMover()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
        }

        private void FrmMover_Load(object sender, EventArgs e)
        {
            mp.MostrarHistorialEntradas(dtgEntrada);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT id_producto, nombre, stock_minimo " + // Ya no está codigo_barras
                              "FROM tbl_productos " +
                              $"WHERE nombre LIKE '%{TxtBuscar.Text}%' AND activo = 1";

            mp.MostrarParaEntrada(consulta, dtgProductos, "tbl_productos");
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            fila = e.RowIndex;
            columna = e.ColumnIndex;

            if (dtgProductos.Columns[columna] is DataGridViewButtonColumn)
            {
                string nombreProducto = dtgProductos.Rows[fila].Cells["nombre"].Value.ToString();
                int idProducto = int.Parse(dtgProductos.Rows[fila].Cells["id_producto"].Value.ToString());

                DialogResult respuesta = MessageBox.Show($"¿Deseas agregar una entrada para el producto: {nombreProducto}?",
                                                         "Confirmar Entrada",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    int cantidad = 10; 
                    decimal precioCompra = 0; 

                    mp.RegistrarEntrada(idProducto, cantidad, precioCompra);

                    mp.MostrarHistorialEntradas(dtgEntrada);

                    MessageBox.Show("Producto agregado al historial correctamente.");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

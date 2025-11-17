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
    public partial class FrmVentas : Form
    {

        public static List<(int idProducto, int idLote, string nombre, string categoria, string codigoLote, decimal precio, int stock, int cantidad, DateTime fechaVencimiento)> ProductosSeleccionados
       = new List<(int, int, string, string, string, decimal, int, int, DateTime)>();
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmSeleccionProducto frmSeleccionProducto = new FrmSeleccionProducto();
            frmSeleccionProducto.ShowDialog();
            CargarProductosSeleccionados();
            ActualizarTotal();

        }


        private void CargarProductosSeleccionados()
        {
            if (DtgProductos.Columns.Count == 0)
            {
                DtgProductos.Columns.Add("idProducto", "ID Producto");
                DtgProductos.Columns["idProducto"].Visible = false;

                DtgProductos.Columns.Add("idLote", "ID Lote");
                DtgProductos.Columns["idLote"].Visible = false;

                DtgProductos.Columns.Add("nombre", "Producto");
                DtgProductos.Columns.Add("cantidad", "Cantidad");
                DtgProductos.Columns.Add("precio", "Precio Unitario");
                DtgProductos.Columns.Add("subtotal", "Subtotal");
            }

            DtgProductos.Rows.Clear();

            foreach (var p in ProductosSeleccionados)
            {
                decimal subtotal = p.precio * p.cantidad;
                DtgProductos.Rows.Add(p.idProducto, p.idLote, p.nombre, p.cantidad, p.precio.ToString("0.00"), subtotal.ToString("0.00"));
            }

            ActualizarTotal();
            DtgProductos.ClearSelection();
        }

        private void ActualizarTotal()
        {
            decimal total = ProductosSeleccionados.Sum(x => x.precio * x.cantidad);
            LblPagar.Text = $"$ {total}";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (DtgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = DtgProductos.SelectedRows[0];
            int idProducto = Convert.ToInt32(fila.Cells["idProducto"].Value);
            int idLote = Convert.ToInt32(fila.Cells["idLote"].Value);

            ProductosSeleccionados.RemoveAll(p => p.idProducto == idProducto && p.idLote == idLote);

            DtgProductos.Rows.Remove(fila);

            ActualizarTotal();
        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            decimal total = ProductosSeleccionados.Sum(x => x.precio * x.cantidad);
            Pagar p = new Pagar(total);
            p.ShowDialog();
        }
    }
}

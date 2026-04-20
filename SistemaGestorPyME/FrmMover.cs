using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_Kike;

namespace SistemaGestorPyME
{
    public partial class FrmMover : Form
    {
        ManejadorProducto mp;
        int idProductoSeleccionado = 0;
        private Timer timerBuscar;

        public FrmMover()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
        }

        private void FrmMover_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarProductos(); 
            LblNombreProducto.Text = "--- Seleccione un producto ---";
            DtpFecha.Value = DateTime.Now;
        }

        private void CargarProveedores()
        {
            CmbProveedor.DataSource = mp.ObtenerProveedores();
            CmbProveedor.DisplayMember = "nombre";
            CmbProveedor.ValueMember = "id_proveedor";
            CmbProveedor.SelectedIndex = -1;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductos(TxtBuscar.Text);
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProductoSeleccionado = int.Parse(dtgProductos.Rows[e.RowIndex].Cells["id_producto"].Value.ToString());
                LblNombreProducto.Text = dtgProductos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                TxtCantidad.Focus();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProductoSeleccionado == 0)
                {
                    MessageBox.Show("Por favor, seleccione un producto de la tabla izquierda.");
                    return;
                }
                if (string.IsNullOrEmpty(TxtCantidad.Text) || string.IsNullOrEmpty(TxtPrecio.Text))
                {
                    MessageBox.Show("Debe llenar la Cantidad y el Precio.");
                    return;
                }
                if (CmbProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un proveedor.");
                    return;
                }

        
                int cantidad = int.Parse(TxtCantidad.Text);
                decimal precio = decimal.Parse(TxtPrecio.Text);
                int idProveedor = int.Parse(CmbProveedor.SelectedValue.ToString());
                string nota = TxtNotas.Text;

                string fechaCad = DtpFecha.Value.ToString("yyyy-MM-dd");

       
                mp.RegistrarEntrada(idProductoSeleccionado, cantidad, precio, idProveedor, nota, fechaCad);

                MessageBox.Show($"Entrada registrada correctamente.\nSe sumaron {cantidad} unidades al inventario.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        public void LimpiarCampos()
        {
            TxtCantidad.Clear();
            TxtPrecio.Clear();
            TxtNotas.Clear();
            CmbProveedor.SelectedIndex = -1;
            LblNombreProducto.Text = "--- Seleccione un producto ---";
            idProductoSeleccionado = 0;
            DtpFecha.Value = DateTime.Now; 
        }

        private void CargarProductos(string filtro = "")
        {
            string consulta = "SELECT id_producto, nombre, descripcion, stock_minimo " +
                              "FROM tbl_productos " +
                              $"WHERE nombre LIKE '%{filtro}%' AND activo = 1";

            mp.MostrarParaEntrada(consulta, dtgProductos, "tbl_productos");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            timer1?.Stop();
            timer1?.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1?.Stop();

            CargarProductos(TxtBuscar.Text);
        }


        private void btnCerrar_Click(object sender, EventArgs e) { Application.Exit(); }
        private void btnVentas_Click(object sender, EventArgs e) { new FrmVentas().Show(); this.Hide(); }
        private void btnInventario_Click(object sender, EventArgs e) { new FrmInventario().Show(); this.Hide(); }
        private void btnProductos_Click(object sender, EventArgs e) { new FrmProducto().Show(); this.Hide(); }
        private void button1_Click(object sender, EventArgs e) { Close(); }

       
    }
}
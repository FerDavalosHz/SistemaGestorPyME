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
        int idProductoSeleccionado = 0;
        public FrmMover()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
        }

        private void FrmMover_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            LblNombreProducto.Text = "--- Seleccione un producto ---";
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
            string consulta = "SELECT id_producto, nombre, descripcion, stock_minimo " +
                              "FROM tbl_productos " +
                              $"WHERE nombre LIKE '%{TxtBuscar.Text}%' AND activo = 1";

            mp.MostrarParaEntrada(consulta, dtgProductos, "tbl_productos");
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                idProductoSeleccionado = int.Parse(dtgProductos.Rows[e.RowIndex].Cells["id_producto"].Value.ToString());
                string nombre = dtgProductos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

                LblNombreProducto.Text = nombre;

                TxtCantidad.Focus();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

                mp.RegistrarEntrada(idProductoSeleccionado, cantidad, precio, idProveedor, nota);

                MessageBox.Show($"Entrada registrada correctamente.\nSe sumaron {cantidad} unidades al inventario.");

                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Revise que la Cantidad y el Precio sean números válidos.");
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
        }
    }
}
